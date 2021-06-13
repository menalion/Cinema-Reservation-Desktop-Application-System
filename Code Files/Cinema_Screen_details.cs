using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client ; 
using Oracle.DataAccess.Types ; 
namespace Cinema_Reservation_System
{
    public partial class Cinema_Screen_details : Form
    {
        OracleDataAdapter ad_screens , ad_films;
        DataSet d;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        static int SSN_Manager = 0;
        string cinema_name; 
        public Cinema_Screen_details(int SSN)
        {
            SSN_Manager = SSN; 
            InitializeComponent();
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager_Functions mf = new Manager_Functions();
            mf.Show();
            this.Hide(); 
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
            OracleDataReader rd =  cmd.ExecuteReader();
            if (rd.Read())
                cinema_name = rd[0].ToString();
            rd.Close();
            con.Dispose(); 
        }
        private void Cinema_Screen_details_Load(object sender, EventArgs e)
        {
            try
            {
                get_cinema_Name(); 
                d = new DataSet();

                ad_screens = new OracleDataAdapter("select  SCREEN_ID from screen where cinema_name = :Cinema_Name", str_con);
                ad_screens.SelectCommand.Parameters.Add("Cinema_Name", cinema_name);
                ad_screens.Fill(d, "Master_Screens");

                ad_films = new OracleDataAdapter(@"select sm.movie_name , sm.number_of_seats , sm.day_date, sm.month_date  , 
                                                sm.hour_time , sm.minute_time , sm.screen_id 
                                                from screen_movies sm , screen s 
                                                where sm.screen_id = s.screen_id and s.cinema_name = :Cinema_Name", str_con);
                ad_films.SelectCommand.Parameters.Add("Cinema_name", cinema_name); 

                ad_films.Fill(d, "Child_films"); 
                // primary key -> screen 
                // forign Key -> screen_Movies ; 

                DataRelation r = new DataRelation("fk", d.Tables[0].Columns["screen_id"], d.Tables[1].Columns["screen_id"]);
                d.Relations.Add(r);

                BindingSource master = new BindingSource(d, "Master_Screens");
                BindingSource child = new BindingSource(master, "fk");

                dgv_Screens.DataSource = master;
                dgv_Films_on_screen.DataSource = child;

                dgv_Screens.Columns[0].Width = 150; 

                dgv_Films_on_screen.Columns[0].Width = 150;
                dgv_Films_on_screen.Columns[1].Width = 150;
                dgv_Films_on_screen.Columns[2].Width = 150;
                dgv_Films_on_screen.Columns[3].Width = 150;
                dgv_Films_on_screen.Columns[4].Width = 150;
                dgv_Films_on_screen.Columns[5].Width = 150;
                dgv_Films_on_screen.Columns[6].Width = 150; 
            }
            catch
            { MessageBox.Show("You Don't have any films in your screens ", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Information); }
         }
    }
}
