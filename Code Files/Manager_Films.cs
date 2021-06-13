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
    public partial class Manager_Films : Form
    {
        string str_con = "data source = orcl ; password = scott ; user id  = scott ; "; 
        static int SSN_Manager ;
        string cinema_name; 
        public Manager_Films()
        {
            InitializeComponent();
        }
        public Manager_Films(int n)
        {
            SSN_Manager = n; 
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

        private bool right_choise()
        {
            bool r = true; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from cinema_contains_movies cm where 
                                cm.cinema_name = :Cinema_Name and cm.movie_name = :Movie_Name";
            cmd.Parameters.Add("Cinema_Name", cinema_name);
            cmd.Parameters.Add("Movie_Name", cmb_movies.Text); 
            cmd.Connection = con;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                r = false;  
            con.Dispose();
            rd.Close();
            return r;  
        }
        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager_Functions mf = new Manager_Functions();
            mf.Show();
            this.Hide(); 
        }

        private bool not_in_movie()
        {
            bool r = true; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select MOVIE_NAME from Movie where  MOVIE_NAME = :M";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("M", cmb_movies.Text);
            OracleDataReader rd = cmd.ExecuteReader();
           
            if (rd.Read())
                r = false;
            rd.Close(); 
            con.Dispose();
            return r; 
        }
        private void insert_into_movies()
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            if (not_in_movie() == true)
            {
               
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Movie values (:m , :hero , :cat_name , :duration)"; // Normal Insert
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("m", cmb_movies.Text);
                cmd.Parameters.Add("hero", txt_name.Text);
                cmd.Parameters.Add("cat_name", cmb_Categories.SelectedItem.ToString());
                cmd.Parameters.Add("duration", Convert.ToInt32(txt_duration.Text));

                cmd.ExecuteNonQuery(); 


                
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "select duration_of_film from movie where :m = movie_name";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("movie_name", cmb_movies.Text);
                OracleDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    txt_duration.Text = rd[0].ToString();
                rd.Close(); 

            }
            con.Dispose(); 
 
        }
        private void Update_Null_value ()
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"update cinema_contains_movies set NUMBER_OF_SHOWS = 0 
                        where  MOVIE_NAME = :m_Name and CINEMA_NAME = :c_name";
            cmd.CommandType = CommandType.Text; 
            cmd.Parameters.Add("m_Name", cmb_movies.Text);
            cmd.Parameters.Add("C_name", cinema_name);
            cmd.ExecuteNonQuery();
            con.Dispose(); 

        }
        private void Manager_Films_Load(object sender, EventArgs e)
        {
            get_cinema_Name();
            OracleConnection con = new OracleConnection(str_con);
            con.Open();

            OracleCommand cmd_2 = new OracleCommand(); 
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = con;
            cmd_2.Connection = con; 

            cmd.CommandText = @"select cm.movie_name from cinema_contains_movies cm 
                                where cm.cinema_name = :Cinema_Name" ;

            cmd_2.CommandText = @"select * from movie_category"; 

            cmd.Parameters.Add("Cinema_Name",cinema_name); 

            cmd.CommandType = CommandType.Text;
            cmd_2.CommandType = CommandType.Text;
 
            OracleDataReader rd = cmd.ExecuteReader();
            OracleDataReader rd_2 = cmd_2.ExecuteReader();
            while (rd.Read())
                cmb_movies.Items.Add(rd[0].ToString());

            while (rd_2.Read())
            {
                cmb_Categories.Items.Add(rd_2[0].ToString());
                cat_update.Items.Add(rd_2[0].ToString()); 
            }
            rd_2.Close(); 
            rd.Close(); 
            con.Dispose(); 
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            if (cmb_movies.Text == "" || cmb_Categories.Text == "" || txt_duration.Text == "" || txt_name.Text == "" || txt_vnue.Text == "")
            { MessageBox.Show("Please Fill The data", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
         
            bool alright =  right_choise() ;
            if (!alright)
            { MessageBox.Show("You Already Have This Film In Your Cinema", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            insert_into_movies();
            OracleConnection con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert_movie_to_cinema";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("m_Name", cmb_movies.Text);
            cmd.Parameters.Add("C_name", cinema_name);
            cmd.Parameters.Add("Venue", Convert.ToInt32(txt_vnue.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Update_Null_value(); 
            cmb_movies.Items.Add(cmb_movies.Text); 
            con.Dispose(); 
        }

        private void cmb_movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            // to get the venue
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select VENUE_OF_FILM from  CINEMA_CONTAINS_MOVIES 
                                    where MOVIE_NAME = :m and CINEMA_NAME = :c";
            cmd.Parameters.Add("m", cmb_movies.SelectedItem.ToString());
            cmd.Parameters.Add("c", cinema_name);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                txt_vnue.Text = rd[0].ToString();
            rd.Close(); 
            // to get the Name of hero ,The Duration and the category Of Film of the data from table movie ; 

            OracleCommand cmd_2 = new OracleCommand();
            cmd_2.Connection = con;
            cmd_2.CommandType = CommandType.Text;
            cmd_2.CommandText = @"select * from  Movie
                                    where MOVIE_NAME = :m ";
            cmd_2.Parameters.Add("m", cmb_movies.SelectedItem.ToString());
             OracleDataReader rd_2 = cmd_2.ExecuteReader(); 
            if (rd_2.Read())
            {
                txt_duration.Text = rd_2[3].ToString(); 
                txt_name.Text = rd_2[1].ToString() ;
                cmb_Categories.Text = rd_2[2].ToString(); 
            }
            rd_2.Close();
            con.Dispose(); 

 
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_venue_update.Text == "" || cat_update.Text == "")
            { MessageBox.Show("Please Fill The data", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            OracleConnection con = new OracleConnection(str_con);
            con.Open();


            // to update the vunue of the film in the cinema ; 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update_Venue_Of_Film";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("m", cmb_movies.SelectedItem.ToString());
            cmd.Parameters.Add("c", cinema_name);
            cmd.Parameters.Add("Venue", Convert.ToInt32(txt_venue_update.Text)); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 


             // yo update the category of the film in the cinema 
            OracleCommand cmd_2 = new OracleCommand();
            cmd_2.Connection = con;
            cmd_2.CommandText = "Update_film_cate";
            cmd_2.CommandType = CommandType.StoredProcedure;
            cmd_2.Parameters.Add("m" , cmb_movies.SelectedItem.ToString());
            cmd_2.Parameters.Add("cat", cat_update.SelectedItem.ToString());
            cmd_2.ExecuteNonQuery(); 

            con.Dispose(); 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool delete = true; 
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = con;
            cmd.CommandText = "Get_Number_Of_Shows"; 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("c",cinema_name ); 
            cmd.Parameters.Add("m" , cmb_movies.SelectedItem.ToString()) ;
            cmd.Parameters.Add("N_Shows", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();  // because single Row
            if (Convert.ToInt32(cmd.Parameters["N_Shows"].Value.ToString()) != 0 )
            {
                MessageBox.Show("You Can Not Delete This Film Unless The Number Of Shows is Not Zero" + "\n\n" + 
                            "please Go To the screen Options" , "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                delete = false; 
            }
            if (delete)
            {
                OracleCommand cmd_2 = new OracleCommand();
                cmd_2.Connection = con;
                cmd_2.CommandText = "Delete_Movie_From_Cinema";
                cmd_2.CommandType = CommandType.StoredProcedure;
                cmd_2.Parameters.Add("m_name" , cmb_movies.SelectedItem.ToString());
                cmd_2.Parameters.Add("c_name", cinema_name); 
                cmd_2.ExecuteNonQuery();
                MessageBox.Show("Deleted", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_movies.Items.Remove(cmb_movies.SelectedItem); 
            }
            con.Dispose(); 

        }
    }
}
