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
    public partial class Cancle_reservation : Form
    {
        string day, hour , month , cinema_Name;
        int seat_ID_for_the_Update , screen_ID , number_of_tickets; 
        static  int SSN_Customer ;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        public Cancle_reservation()
        {
            InitializeComponent();
        }
        public Cancle_reservation(int n )
        {
            SSN_Customer = n; 
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void update_Number_Of_Seats()
        {
            int Curren_seats = 0; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select sm.number_of_seats , s.screen_id  from  screen_movies sm , seat s 
                                where s.screen_id = sm.screen_id and s.seat_id = :seat_num";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("seat_Num" , seat_ID_for_the_Update); 
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Curren_seats = Convert.ToInt32(rd[0].ToString());
                screen_ID = Convert.ToInt32(rd[1].ToString()); 
            }


            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "Update screen_movies set number_of_seats = :total where SCREEN_ID = :ID";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Total", (number_of_tickets + Curren_seats));
            c.Parameters.Add("ID", screen_ID); 
            c.ExecuteNonQuery(); 
            rd.Close(); 
            con.Dispose();
        }
        private void Cancle_reservation_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select MOVIE_NAME from CUSTOMER_SELECT_MOVIES where SSN_CUSTOMER = :SSN and CANCLED = 'n' ";  
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("SSN", SSN_Customer);
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                comboBox1.Items.Add(rd[0].ToString()); 
            rd.Close(); 

            con.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            { MessageBox.Show("Fill The Data Please", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;  }
            DialogResult r = MessageBox.Show("Are You Sure You Want To Cancle You Have No Money , Capish", "Designers", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                return;
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "update CUSTOMER_SELECT_MOVIES  set CANCLED = 'y' where  SSN_CUSTOMER = :SSN and   MOVIE_NAME = :Movie";
            c.Parameters.Add("SSN", SSN_Customer);
            c.Parameters.Add("Movie", comboBox1.SelectedItem.ToString());
            c.ExecuteNonQuery(); 


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from CUSTOMER_SELECT_MOVIES where SSN_CUSTOMER = :SSN and MOVIE_NAME = :Movie";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("SSN", SSN_Customer);
            cmd.Parameters.Add("Movie", comboBox1.SelectedItem.ToString()); 
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                number_of_tickets = Convert.ToInt32(rd[2].ToString()) ; 
                month = rd[4].ToString() ; 
                day = rd[3].ToString() ; 
                hour = rd[5].ToString() ; 
            }
            rd.Close(); 


            OracleCommand cmd_2 = new OracleCommand();
            cmd_2.Connection = con;
            cmd_2.CommandText = "select Seat_ID from ticket where ssn_customer = :ID and date_day_book = :day and time_hour_book  = :hour and DATE_MONTH_BOOK =  :month";  
            cmd_2.CommandType = CommandType.Text;
            cmd_2.Parameters.Add("ID" , SSN_Customer) ; 
            cmd_2.Parameters.Add("Day" , Convert.ToInt32(day)) ;
            cmd_2.Parameters.Add("Hour" , Convert.ToInt32(hour)) ; 
            cmd_2.Parameters.Add("month" , Convert.ToInt32(month)) ; 
            OracleDataReader rd_2 = cmd_2.ExecuteReader(); 
            while(rd_2.Read())
            {
                int seat_ID = Convert.ToInt32(rd_2[0].ToString());
                OracleCommand cmd_3 = new OracleCommand();
                cmd_3.Connection = con;
                cmd_3.CommandText = "update SEAT set SEALED = 'n' where SEAT_ID = :ID"; 
                cmd_3.CommandType = CommandType.Text;
                cmd_3.Parameters.Add("seat_ID", seat_ID);  
                cmd_3.ExecuteNonQuery() ;
                seat_ID_for_the_Update = seat_ID; 
            }
            rd_2.Close();
            update_Number_Of_Seats(); 


            OracleCommand cmd_4 = new OracleCommand();
            cmd_4.Connection = con;
            cmd_4.CommandText = "delete from ticket where ssn_customer = :ID and date_day_book = :day and time_hour_book  = :hour and DATE_MONTH_BOOK =  :month";
            cmd_4.CommandType = CommandType.Text;
            cmd_4.Parameters.Add("ID", SSN_Customer);
            cmd_4.Parameters.Add("Day", Convert.ToInt32(day));
            cmd_4.Parameters.Add("Hour", Convert.ToInt32(hour));
            cmd_4.Parameters.Add("month", Convert.ToInt32(month));
            cmd_4.ExecuteNonQuery();
            comboBox1.Items.Remove(comboBox1.SelectedItem);  
            con.Dispose(); 
        }
    }
}
