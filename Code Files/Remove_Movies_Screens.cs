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
    public partial class Remove_Movies_Screens : Form
    {
        string movie_Name;
        int screen_ID;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        static int SSN_Manager = 0;
        string cinema_name; 
        public Remove_Movies_Screens()
        {
            InitializeComponent();
        }


        public Remove_Movies_Screens(int SSN)
        {
            SSN_Manager = SSN; 
            InitializeComponent();
        }
        private void get_cinema_Name()
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CINEMA_NAME from Cinema where SSN_MANAGER = :SSN";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("SSN", SSN_Manager);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                cinema_name = rd[0].ToString();
            rd.Close();
            con.Dispose();
        } 
        private bool check_number_of_shows()
        {
            int number_of_shows = 0; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            // get the number of shows ; 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select NUMBER_OF_SHOWS from CINEMA_CONTAINS_MOVIES
                                 where MOVIE_NAME = :mov  and CINEMA_NAME = :cin"; 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("mov", movie_Name);
            cmd.Parameters.Add("cin", cinema_name);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                number_of_shows = Convert.ToInt32(rd[0].ToString());
            rd.Close();
            if (number_of_shows == 0)
            {MessageBox.Show("There Is No Screens For This Movie", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop) ; return false ;}
            else
                number_of_shows--;

            OracleCommand cmd_update = new OracleCommand();
            cmd_update.Connection = con;
            cmd_update.CommandText = @"update CINEMA_CONTAINS_MOVIES set NUMBER_OF_SHOWS = :num 
                                        where MOVIE_NAME = :mov and CINEMA_NAME = :cinema";
            cmd_update.CommandType = CommandType.Text;
            cmd_update.Parameters.Add("Num", number_of_shows); 
            cmd_update.Parameters.Add("mov", movie_Name);
            cmd_update.Parameters.Add("cinema", cinema_name);
            cmd_update.ExecuteNonQuery(); 
            con.Dispose();
            if (number_of_shows == 0)
                return true; 
            return false; 
        }
        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ALter_Screens als = new ALter_Screens();
            als.Show();
            this.Hide(); 
        }

        private void Remove_Movies_Screens_Load(object sender, EventArgs e)
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
            con.Dispose(); 
        }

        private void cmb_screens_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Movies.Items.Clear();
            cmb_Movies.Text = ""; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  movie_name from screen_movies where screen_id = :ID"; 
            cmd.CommandType = CommandType.Text; 
            cmd.Parameters.Add("ID" , Convert.ToInt32(cmb_screens.SelectedItem.ToString())) ; 
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_Movies.Items.Add(rd[0].ToString()); 
            rd.Close() ; 
            con.Dispose(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
             movie_Name = cmb_Movies.SelectedItem.ToString();
             screen_ID = Convert.ToInt32(cmb_screens.SelectedItem.ToString());
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            // Normal Delete Operation ; 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con; 
            cmd.CommandText = @"delete from screen_movies 
                            where MOVIE_NAME = :Movie and SCREEN_ID = :ID"; 

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Movie_Name", movie_Name);
            cmd.Parameters.Add("ID", screen_ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            cmb_Movies.Items.Remove(cmb_Movies.SelectedItem);
            cmb_Movies.Text = ""; 
            if (check_number_of_shows())
                MessageBox.Show("Note That There is No More Shows For this Movie", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            con.Dispose(); 
         }
    }
}
