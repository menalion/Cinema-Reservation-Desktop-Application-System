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
using CrystalDecisions.Shared; 
namespace Cinema_Reservation_System
{
    public partial class Income_Report : Form
    {
        icome_per_day icp; 
        int SSN_Manager;
        string cinema_name;
        string str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        public Income_Report()
        {
            InitializeComponent();
        }

        public Income_Report(int n )
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
            Manager_Functions cf = new Manager_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void Income_Report_Load(object sender, EventArgs e)
        {
            get_cinema_Name(); 
            icp = new icome_per_day();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            icp.SetParameterValue(0, cinema_name);
            icp.SetParameterValue(1, Convert.ToInt32(textBox1.Text));
            icp.SetParameterValue(2, Convert.ToInt32(textBox2.Text));
            crystalReportViewer1.ReportSource = icp; 
        }
    }
}
