using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client; 
namespace Cinema_Reservation_System
{
    public partial class Search_Time : Form
    {
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        OracleDataAdapter ad;
        DataSet d; 
        public Search_Time()
        {
            InitializeComponent();
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void btn_Serach_Click(object sender, EventArgs e)
        {
            ad = new OracleDataAdapter(@"select s.cinema_name , sm.movie_name , cm.venue_of_film , sm.month_date , sm.day_date  , sm.minute_time , sm.number_of_seats
                                        from screen_movies sm , screen s , cinema ci  ,  cinema_contains_movies cm
                                        where ci.cinema_name = s.cinema_name and sm.screen_id = s.screen_id and sm.hour_time = :Hour 
                                        and cm.movie_name = sm.movie_name and cm.cinema_name = s.cinema_name", str_con);
            ad.SelectCommand.Parameters.Add("Hour", Convert.ToInt32(txt_Hour.Text));
            d = new DataSet();
            ad.Fill(d);
            dgv_Hour.DataSource = d.Tables[0];

            dgv_Hour.Columns[0].Width = 150;
            dgv_Hour.Columns[1].Width = 150;
            dgv_Hour.Columns[2].Width = 150;
            dgv_Hour.Columns[3].Width = 150;
            dgv_Hour.Columns[4].Width = 150;
            dgv_Hour.Columns[5].Width = 150;
            dgv_Hour.Columns[6].Width = 150; 
        }
    }
}
