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
    public partial class Search_date : Form
    {
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        OracleDataAdapter ad;
        DataSet d; 
        public Search_date()
        {
            InitializeComponent();
        }

        private void btn_serach_Click(object sender, EventArgs e)
        {
            ad = new OracleDataAdapter(@"select s.cinema_name , sm.movie_name , cm.venue_of_film , sm.day_date , sm.hour_time , sm.minute_time , sm.number_of_seats  
                                          from screen_movies sm , screen s , cinema ci  , cinema_contains_movies cm
                                          where ci.cinema_name = s.cinema_name and sm.screen_id = s.screen_id and  sm.month_date = :Month
                                          and cm.cinema_name = s.cinema_name and cm.movie_name = sm.movie_name", str_con);
              ad.SelectCommand.Parameters.Add("NAME", Convert.ToInt32(txt_month.Text)); 
            d = new DataSet();
            ad.Fill(d);
            dgv_Date_Movies.DataSource = d.Tables[0];

            dgv_Date_Movies.Columns[0].Width = 150;
            dgv_Date_Movies.Columns[1].Width = 150;
            dgv_Date_Movies.Columns[2].Width = 150;
            dgv_Date_Movies.Columns[3].Width = 150;
            dgv_Date_Movies.Columns[4].Width = 150;
            dgv_Date_Movies.Columns[5].Width = 150;
            dgv_Date_Movies.Columns[6].Width = 150; 
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }
    }
}
