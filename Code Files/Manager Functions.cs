    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Reservation_System
{
    public partial class Manager_Functions : Form
    {
       static int SSN_Manager = 0; 
        public Manager_Functions(string str_manger_Name , string SSN)
        {
            InitializeComponent();
            l_Name_Manger.Text = str_manger_Name;
            SSN_Manager = Convert.ToInt32(SSN); 
        }

        public Manager_Functions()
        {
            InitializeComponent();
        }
        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("We Hope That We serve You Well", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
            this.Hide(); 
        }

        private void btn_cinema_Click(object sender, EventArgs e)
        {
            Cinema_Screen_details csd = new Cinema_Screen_details(SSN_Manager);
            csd.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_report  vr= new View_report(SSN_Manager);
            vr.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Income_Report ir = new Income_Report(SSN_Manager);
            ir.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Films mf = new Manager_Films(SSN_Manager);
            mf.Show();
            this.Hide(); 
        }

        private void btn_Screens_Click(object sender, EventArgs e)
        {
            ALter_Screens als = new ALter_Screens(SSN_Manager);
            als.Show();
            this.Hide(); 
        }

        private void Manager_Functions_Load(object sender, EventArgs e)
        {

        }
    }
}
