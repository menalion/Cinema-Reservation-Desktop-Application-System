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
    /// <summary>
    /// ///////////////////////question 1 for dr Nagwa Bdre
    /// </summary>
    public partial class Search_Movies : Form
    {
        OracleDataAdapter ad;
        DataSet d; 
        int SSN; 
        OracleConnection con;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; "; 
        public Search_Movies(int n)
        {
            SSN = n; 
            InitializeComponent();
        }

        private void Search_Movies_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(str_con);
            con.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Movie_Name from Movie" ;
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_movies.Items.Add(rd[0].ToString());
            rd.Close();
            con.Dispose(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show(); 
            this.Hide(); 
        }

        private void cmb_movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ad = new OracleDataAdapter(@"select ci.cinema_name  , cm.venue_of_film , cm.number_of_shows 
                                        from cinema ci , cinema_contains_movies cm , movie m 
                                        where ci.cinema_name = cm.CINEMA_NAME and m.MOVIE_NAME = :NAME 
                                        and  cm.MOVIE_NAME = m.MOVIE_NAME  ", str_con);
            ad.SelectCommand.Parameters.Add("NAME", cmb_movies.SelectedItem.ToString()); 
            d = new DataSet();
            ad.Fill(d, "Veiw_Cinemas_for_movie"); 

            gdv_data.DataSource = d.Tables[0];
            gdv_data.Columns[0].Width = 300;
            gdv_data.Columns[1].Width = 300;
            gdv_data.Columns[2].Width = 300;


            con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select  HERO_NAME , CATEGORY_NAME , DURATION_OF_FILM from movie 
                               where MOVIE_NAME = :Name "; 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Name" , cmb_movies.SelectedItem.ToString()) ; 
            OracleDataReader rd = cmd.ExecuteReader(); 
            if (rd.Read())
            {
                MessageBox.Show("Hero Name : " + rd[0].ToString() + "\n" +
                                "CATEGORY_NAME : " + rd[1].ToString() + "\n" +
                                   "DURATION OF FILM : " + rd[2].ToString() + " Hours\n"); 
            }
            rd.Close(); 
            con.Dispose(); 
        }
    }
}
