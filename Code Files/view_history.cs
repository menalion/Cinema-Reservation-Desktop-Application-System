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
    public partial class view_history : Form
    {
        total_cost tc;
        int SSN_Customer; 
        public view_history()
        {
            InitializeComponent();
        }

        public view_history(int n )
        {
            SSN_Customer = n; 
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide(); 
        }

        private void view_history_Load(object sender, EventArgs e)
        {
            tc = new total_cost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tc.SetParameterValue(0, SSN_Customer);
            crystalReportViewer1.ReportSource = tc;
        }
    }
}
