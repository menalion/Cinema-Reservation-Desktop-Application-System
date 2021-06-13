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
    public partial class Insert_Into_Screens : Form
    {
        static int SSN_Manger;
        string movie_Name;
        int screen_ID;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        string cinema_name; 
        public Insert_Into_Screens()
        {
            InitializeComponent();
        }

        public Insert_Into_Screens(int n)
        {
            SSN_Manger = n; 
            InitializeComponent();
        }
        //private increase_number_Shows()
        //{

        //}
        private void get_cinema_Name()
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CINEMA_NAME from Cinema where SSN_MANAGER = :SSN";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("SSN", SSN_Manger);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                cinema_name = rd[0].ToString();
            rd.Close();
            con.Dispose();
        } 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ALter_Screens als = new ALter_Screens();
            als.Show();
            this.Hide(); 
        }

        private void Insert_Into_Screens_Load(object sender, EventArgs e)
        {
            get_cinema_Name();
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            // to load the screen ID of the Cinema
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select SCREEN_ID from screen where Cinema_Name = :C_name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("C_Name", cinema_name);
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_screens.Items.Add(rd[0].ToString());
            rd.Close(); 

            // load Movies In The  Cinema  
            OracleCommand cmd_2 = new OracleCommand();
            cmd_2.Connection = con;
            cmd_2.CommandText = "select MOVIE_NAME From CINEMA_CONTAINS_MOVIES where CINEMA_NAME = :c"; 
            cmd_2.CommandType = CommandType.Text;
            cmd_2.Parameters.Add("c", cinema_name);
            OracleDataReader rd_2 = cmd_2.ExecuteReader();
            while (rd_2.Read())
                cmb_Movies.Items.Add(rd_2[0].ToString());
            rd_2.Close(); 

            con.Dispose(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmb_screens.Text == "" || cmb_Movies.Text == "" || txt_minute.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "" ||txt_Numberofseats.Text == "" )
            { MessageBox.Show("Fill Your Data Pelase", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;  } 
            movie_Name = cmb_Movies.SelectedItem.ToString() ;  
            screen_ID = Convert.ToInt32(cmb_screens.SelectedItem.ToString())  ;
            OracleConnection con = new OracleConnection(str_con);
            con.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into SCREEN_MOVIES values ( :SID , :movie  , :seats , :hour , :minute , :day , :Month)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("seats", Convert.ToInt32(txt_Numberofseats.Text));
            cmd.Parameters.Add("hour", Convert.ToInt32(textBox3.Text));
            cmd.Parameters.Add("minute", Convert.ToInt32(txt_minute.Text));
            cmd.Parameters.Add("day", textBox2.Text);
            cmd.Parameters.Add("Month", textBox4.Text);
            cmd.Parameters.Add("SID", screen_ID);
            cmd.Parameters.Add("movie", movie_Name);
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            con.Dispose(); 

        }

    }
}
