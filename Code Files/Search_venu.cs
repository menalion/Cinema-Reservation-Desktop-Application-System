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
    public partial class Search_venu : Form
    {
        int SSN;
        OracleDataAdapter ad;
        DataSet d;
        string str_con = "data source = orcl ; user id = scott ;  password = scott;"; 
        public Search_venu(int n)
        {
            SSN = n; 
            InitializeComponent();
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void txt_seach_Click(object sender, EventArgs e)
        {
            ad = new OracleDataAdapter(@"select m.movie_name  ,  ci.Cinema_Name  , cm.number_of_shows , 
                                                                cm.venue_of_film  from Movie m , Cinema ci  , 
                                                                cinema_contains_movies cm
                                                                where cm.venue_of_film <= :price and ci.CINEMA_NAME = 
                                                                 cm.CINEMA_NAME and cm.Movie_Name = m.Movie_Name", str_con); 

            ad.SelectCommand.Parameters.Add("price" , Convert.ToInt32(txt_vneu.Text)) ; 
            d = new DataSet();
            ad.Fill(d, "show_basedon_vneu");
            Gid_view_master.DataSource = d.Tables[0];
            Gid_view_master.Columns[0].Width = 150;
            Gid_view_master.Columns[1].Width = 150;
            Gid_view_master.Columns[2].Width = 150;
            Gid_view_master.Columns[3].Width = 150;

        }
    }
}
