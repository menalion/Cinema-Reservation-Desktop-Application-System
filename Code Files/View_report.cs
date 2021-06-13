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
    public partial class View_report : Form
    {
        screen_Report sr;

        int SSN_Manager;
        string cinema_name, str_con = "data source = orcl ; user id = scott ; password = scott ; ";
        public View_report()
        {
            InitializeComponent();
        }


        public View_report(int n )
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

        private void button1_Click(object sender, EventArgs e)
        {
            sr.SetParameterValue(0, cinema_name);
            crystalReportViewer1.ReportSource = sr;
        }

        private void View_report_Load(object sender, EventArgs e)
        {
            get_cinema_Name();
            sr = new screen_Report();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager_Functions mf = new Manager_Functions();
            mf.Show();
            this.Hide(); 
        }
    }
}
