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
    public partial class Search_Cinemas : Form
    {
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";  
        OracleDataAdapter ad;
        DataSet d; 
        public Search_Cinemas()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void Search_Cinemas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Form Show You All Systme Cinemas And Their Locations", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ad = new OracleDataAdapter("select cinema_name , location  FROM cinema", str_con);
            d = new DataSet(); 
            ad.Fill(d, "Cinemas_data"); 
            dgv_cinemas.DataSource = d.Tables[0]; 

            dgv_cinemas.Columns[0].Width = 200 ;
            dgv_cinemas.Columns[1].Width = 200;
        }
    }
}
