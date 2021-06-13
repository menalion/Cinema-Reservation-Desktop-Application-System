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
    public partial class Serach_categories : Form
    {
        static int SSN; 
        DataSet d;
        OracleConnection con , con_2 ;
        string str_con = "data source = orcl ; password = scott ; user id  = scott"; 
        public Serach_categories(int n)
        {
            SSN = n; 
            InitializeComponent();
        }

        private void Serach_categories_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(str_con);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CATEGORY_NAME from MOVIE_CATEGORY";
            cmd.CommandType = CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                cmb_categoires.Items.Add(rd[0].ToString());
            rd.Close();
            con.Dispose(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void cmb_categoires_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  bool insert = true; 
            OracleDataAdapter ad_master = new OracleDataAdapter(@"select m.movie_name  ,  ci.Cinema_Name  , cm.number_of_shows , 
                                                                cm.venue_of_film  from Movie m , Cinema ci  , 
                                                                cinema_contains_movies cm
                                                                where m.CATEGORY_NAME = :Name and ci.CINEMA_NAME = 
                                                                cm.CINEMA_NAME and cm.Movie_Name = m.Movie_Name", str_con);
            ad_master.SelectCommand.Parameters.Add("Name", cmb_categoires.SelectedItem.ToString());
            d = new DataSet();
            ad_master.Fill(d, "Master");
            Gid_view_master.DataSource = d.Tables[0];
            Gid_view_master.Columns[0].Width = 200;
            Gid_view_master.Columns[1].Width = 200;
            Gid_view_master.Columns[2].Width = 200;
            Gid_view_master.Columns[3].Width = 200; 

        }

    }
}
