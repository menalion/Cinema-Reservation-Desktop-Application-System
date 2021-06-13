using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types; 
namespace Cinema_Reservation_System
{
    public partial class Select_Seats : Form
    {
        string str_con = "data source = orcl ; user id = scott ;   password = scott ; ";
        int number_of_tickets  , temp   , screen_ID , Cunstomer_SSN; 
        public Select_Seats()
        {
            InitializeComponent();
        }
        public Select_Seats(int num_of_seats , int s_ID , int SSn)
        {
            Cunstomer_SSN = SSn; 
            screen_ID = s_ID; 
            temp  =  number_of_tickets = num_of_seats ; 
            InitializeComponent();
        }
        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show(); 
            this.Hide(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seat_ID = 0 , new_ID  ;
            if (temp == 0)
            { MessageBox.Show("You Can Not Choose More Seats ", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;  }

            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            string fullseat = comboBox1.SelectedItem.ToString();
             string row_c = fullseat[0].ToString();
             string num = fullseat[1].ToString(); 

            cmd.CommandText = @"select  Seat_ID from seat where screen_id = :ID
                            and seat_row_name = :Row_c and seat_row_number = :Row_n";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ID", screen_ID);
            cmd.Parameters.Add("Row", row_c.ToString());
            cmd.Parameters.Add("num", Convert.ToInt32(num));
            OracleDataReader rd = cmd.ExecuteReader(); 
            if (rd.Read())
                seat_ID = Convert.ToInt32(rd[0].ToString()) ;
            // MessageBox.Show("ID Seat is : " + seat_ID.ToString()); 


            OracleCommand cmd_2 = new OracleCommand();
            cmd_2.Connection = con;
            cmd_2.CommandText = "Get_Max_Ticket"; 
            cmd_2.CommandType = CommandType.StoredProcedure;
            cmd_2.Parameters.Add("MAX", OracleDbType.Int32, ParameterDirection.Output);
            cmd_2.ExecuteNonQuery() ; 

            try { 
                new_ID = Convert.ToInt32(cmd_2.Parameters["MAX"].Value.ToString()) +1 ; 
            }
            catch
            {
                new_ID = 1 ; 
            }
            // 
            OracleCommand cmd_3 = new OracleCommand();
            cmd_3.Connection = con;
            cmd_3.CommandText = "insert into TICKET values (:tID , :thour , :tminute , :day_date , :month_date , :SSN , :SEAT_ID)";
            cmd_3.CommandType = CommandType.Text;

            cmd_3.Parameters.Add("tid", new_ID);
            cmd_3.Parameters.Add("thour", DateTime.Now.Hour);
            cmd_3.Parameters.Add("tminute", DateTime.Now.Minute);
            cmd_3.Parameters.Add("day_date", DateTime.Now.Day);
            cmd_3.Parameters.Add("month_date", DateTime.Now.Month);
            cmd_3.Parameters.Add("SSN", Cunstomer_SSN);
            cmd_3.Parameters.Add("SEAT_ID", seat_ID);

            cmd_3.ExecuteNonQuery();

            OracleCommand cmd_4 = new OracleCommand();
            cmd_4.Connection = con;
            cmd_4.CommandText = "update SEAT set SEALED = 'y' where SCREEN_ID = :screen_ID and SEAT_ID = :seatid"; 
            cmd_4.CommandType = CommandType.Text;


            cmd_4.Parameters.Add("screen_ID" , screen_ID);
            cmd_4.Parameters.Add("Seat_ID", seat_ID);
            cmd_4.ExecuteNonQuery(); 

            comboBox1.Items.Remove(comboBox1.SelectedItem); 
            temp--;
            con.Dispose(); 
        }

        private void Select_Seats_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  seat_row_name , seat_row_number from seat where screen_id = :ID and sealed = 'n' "; 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ID", screen_ID); 
            OracleDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string full_seat = rd[0].ToString() + rd[1].ToString();
                comboBox1.Items.Add(full_seat); 
            }
            rd.Close(); 

            con.Dispose(); 
        }
    }
}
