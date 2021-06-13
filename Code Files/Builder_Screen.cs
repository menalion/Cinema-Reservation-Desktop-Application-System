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
    public partial class Builder_Screen : Form
    {
        OracleCommandBuilder build; 
        string cinema_name; 
        OracleDataAdapter ad;
        DataSet d;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        int SSN_Manager; 
        public Builder_Screen()
        {
            InitializeComponent();
        }
        public Builder_Screen(int n)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ALter_Screens als = new ALter_Screens();
            als.Show();
            this.Hide(); 
        }

        private void Builder_Screen_Load(object sender, EventArgs e)
        {
            get_cinema_Name();
            d = new DataSet();

            ad = new OracleDataAdapter("select  * from screen where cinema_name = :Cinema_Name", str_con);
            ad.SelectCommand.Parameters.Add("Cinema_Name", cinema_name);
            ad.Fill(d, "Master_Screens");

            dgv_Screens_cinema.DataSource = d.Tables[0]; // data source is the resource of data fro the grid view

            dgv_Screens_cinema.Columns[0].Width = 250; 
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                build = new OracleCommandBuilder(ad);
                ad.Update(d.Tables[0]);
            }
            catch { MessageBox.Show("Please Choose Another ID in the Insert it's Already used", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Stop);  }
        }
    }
}
