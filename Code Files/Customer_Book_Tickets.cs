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
    public partial class Customer_Book_Tickets : Form
    {
        int SSN_Customer; 
        string str_con = "data source = orcl ; user id = scott ;   password = scott ; ";
        int screen_ID;
        string movie_Name, Cinema_Name;
        int venue, total_number_of_seats , number_of_tickets; 
        public Customer_Book_Tickets()
        {
            InitializeComponent();
        }

        public Customer_Book_Tickets(int n)
        {
            SSN_Customer = n; 
            InitializeComponent();
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private int get_venue(OracleConnection con  , string cinema_name , string movie_name)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT_ONE_VENUE";
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.Add("ci_Name", cinema_name);
            cmd.Parameters.Add("mo_name", movie_name);
            cmd.Parameters.Add("venue", OracleDbType.Int32, ParameterDirection.Output); 
            cmd.ExecuteNonQuery(); 
            return  Convert.ToInt32(cmd.Parameters["venue"].Value.ToString()); 
        }
        private int get_screen_ID ()
        {
            string item = cmb_Screens.SelectedItem.ToString() , num = "";
            for (int i = 14; item[i] != '/'; ++i)
                num += item[i];

                screen_ID = Convert.ToInt32(num); 
                return  screen_ID; 
        }
        private string get_month(string num_of_month)
        {
            int num = Convert.ToInt32(num_of_month);  
            string res = "Error";
            string[] arr = {"Januray" , "February" , "March" , "April" , "May" , "June" , "Julay" , "August"
                               , "September" , "October" , "Novmber" , "December"};
            for (int i = 0; i < 12; i++)
            {
                if (i+1 == num)
                {
                    res = arr[i]; 
                    break; 
                }
            }
                return res; 
        }
        private void Customer_Book_Tickets_Load(object sender, EventArgs e)
        {
            OracleConnection con  = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = " select movie_name from movie";
            cmd.CommandType = CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_Movies.Items.Add(rd[0].ToString());
            rd.Close(); 
            con.Dispose(); 
        }

        private void cmb_Cinemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cinema_Name = cmb_Cinemas.SelectedItem.ToString(); 
            l_seats.Visible = false; 
            l_venue.Visible = true; 
            cmb_Screens.Items.Clear();
            cmb_Screens.Text = ""; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select sm.hour_time , sm.minute_time , sm.day_date , sm.month_date , s.screen_id 
                                from screen_movies sm , screen s 
                                where s.cinema_name = :Cinema_Name and sm.screen_id = s.screen_id  and sm.movie_name = :Movie_Name";
            cmd.Parameters.Add("Cinema_Name", cmb_Cinemas.SelectedItem.ToString());
            cmd.Parameters.Add("Movie_Name", cmb_Movies.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string date_time = "Hall Number : " + rd[4].ToString() + "//" +  rd[2].ToString() + "  " + get_month(rd[3].ToString()) + "   " + rd[0].ToString() + " : ";
                if (rd[1].ToString() == "0")
                    date_time += "00";
                else
                    date_time += rd[1].ToString();
                cmb_Screens.Items.Add(date_time);
            }
            venue =  get_venue(con , cmb_Cinemas.SelectedItem.ToString() , cmb_Movies.SelectedItem.ToString());
            l_venue.Text = "Venue Of Single Ticket is : " + venue.ToString(); 
            rd.Close();
            con.Dispose();
            //catch { MessageBox.Show("Fill The Previous Data", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
        }

        private void cmb_Movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            movie_Name = cmb_Movies.SelectedItem.ToString(); 
            l_venue.Visible = false; 
            cmb_Cinemas.Items.Clear();
            cmb_Cinemas.Text = "";

            cmb_Screens.Items.Clear();
            cmb_Screens.Text = ""; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select cm.cinema_name from cinema_contains_movies cm 
                                where cm.movie_name = :Name ";
            cmd.Parameters.Add("Name", cmb_Movies.SelectedItem.ToString()); 
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_Cinemas.Items.Add(rd[0].ToString());
             con.Dispose(); 
        }

        private void cmb_Screens_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_seats.Visible = true; 
            screen_ID  = get_screen_ID();
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "get_singel_number_of_seats";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("screen_num" ,screen_ID);
            cmd.Parameters.Add("mo_Name", cmb_Movies.SelectedItem.ToString());
            cmd.Parameters.Add("Nuofseats", OracleDbType.Int32, ParameterDirection.Output );
            cmd.ExecuteNonQuery();
            total_number_of_seats = Convert.ToInt32(cmd.Parameters["Nuofseats"].Value.ToString()); 
            l_seats.Text = "Number Of Availble Seats : " + cmd.Parameters["Nuofseats"].Value.ToString();

            con.Dispose(); 
         }

        private void btn_Book_Click(object sender, EventArgs e)
        {
             // sMessageBox.Show("Screen ID " + screen_ID.ToString() + "\n" + "Seats " + total_number_of_seats.ToString() + "\n" + 
                            //"venue " + venue.ToString() + "\n" + "Cinema Name : " + Cinema_Name  +  "  Movie Name  " + movie_Name ) ;  
            if (cmb_Movies.Text == "" || cmb_Screens.Text == "" || cmb_Cinemas.Text == "" || txt_tickets.Text == "")
            { MessageBox.Show("complete You Data ,Sir", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;  }
             number_of_tickets = Convert.ToInt32(txt_tickets.Text);
             if (number_of_tickets > total_number_of_seats)
            { MessageBox.Show("This Number of Tickets Is Not Avaialble , Sir", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return;  }
            DialogResult r = MessageBox.Show("The Total Cost is : " + ( number_of_tickets* venue).ToString() +
                                                " EP\n Are You Sure You Want To Book The Tickets ?",
                                                    "Designers", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
            if (DialogResult.OK == r)
            {
                OracleConnection con = new OracleConnection(str_con);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update  screen_movies set NUMBER_OF_SEATS = :n 
                                where   SCREEN_ID = :s and  MOVIE_NAME = :m";
                cmd.Parameters.Add("n", total_number_of_seats - number_of_tickets);
                cmd.Parameters.Add("s", screen_ID);
                cmd.Parameters.Add("m", movie_Name);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery(); 
                  

                // insert booking History ; 
                try
                {
                    OracleCommand cmd_2 = new OracleCommand();
                    cmd_2.Connection = con;
                    cmd_2.CommandText = @"insert into customer_select_movies 
                                            values (:Name_movie , :SSn_customer , :Number_of_tickets , :day_film , :Month_Film , :Hour_film , :Minute_Film , :Cinema_Name , :Ticket_venue , 'n')";
                    cmd_2.CommandType = CommandType.Text;

                    cmd_2.Parameters.Add("Name_movie", movie_Name);
                    cmd_2.Parameters.Add("SSn_customer", SSN_Customer);
                    cmd_2.Parameters.Add("Number_of_tickets", number_of_tickets);
                    cmd_2.Parameters.Add("day_film", DateTime.Now.Day);
                    cmd_2.Parameters.Add("Month_Film", DateTime.Now.Month);
                    cmd_2.Parameters.Add("Minute_Film", DateTime.Now.Minute);
                    cmd_2.Parameters.Add("Hour_film", DateTime.Now.Hour);
                    cmd_2.Parameters.Add("Cinema_Name", Cinema_Name);
                    cmd_2.Parameters.Add("Ticket_venue", venue);

                    cmd_2.ExecuteNonQuery();
                }
                catch
                {
                    OracleCommand cmd_2 = new OracleCommand();
                    cmd_2.Connection = con;
                    cmd_2.CommandText = @"update customer_select_movies set NUMBER_OF_TICKETS = :Number_of_tickets
                                        , day_film = :day , month_film = :month , minute_film = :Minutes , hour_film = :Hours , cinema_name = :Cinema_Name 
                                         ,  TICKET_VENUE = :Venue , CANCLED = 'n'  where ssn_customer = :SSN and movie_name = :Movie";
                    cmd_2.CommandType = CommandType.Text;


                    cmd_2.Parameters.Add("Number_of_tickets", number_of_tickets);
                    cmd_2.Parameters.Add("day_film", DateTime.Now.Day);
                    cmd_2.Parameters.Add("Month_Film", DateTime.Now.Month);
                    cmd_2.Parameters.Add("Minute_Film", DateTime.Now.Minute);
                    cmd_2.Parameters.Add("Hour_film", DateTime.Now.Hour);
                    cmd_2.Parameters.Add("Cinema_Name", Cinema_Name);
                    cmd_2.Parameters.Add("Ticket_venue", venue);
                    cmd_2.Parameters.Add("SSn_customer", SSN_Customer);
                    cmd_2.Parameters.Add("Name_movie", movie_Name);


                    cmd_2.ExecuteNonQuery(); 

                }

                con.Dispose(); 

                Select_Seats ss = new Select_Seats(number_of_tickets , screen_ID , SSN_Customer);
                ss.Show();
                this.Hide(); 
            }
        }

    }
}
