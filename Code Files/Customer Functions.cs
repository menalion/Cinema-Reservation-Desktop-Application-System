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
    public partial class Customer_Functions : Form
    {

        static int Customer_SSN; 
        public Customer_Functions(int n)
        {
            Customer_SSN = n; 
            InitializeComponent();
        }
        public Customer_Functions()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Form c = new Customer_Form();
            c.Show(); 
            this.Hide(); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("We Hope That We serve You Well", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serach_categories sc = new Serach_categories(Customer_SSN);
            sc.Show(); 
            this.Hide(); 
        }

        private void btn_Screens_Click(object sender, EventArgs e)
        {
            Search_Cinemas sc = new Search_Cinemas();
            sc.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_venu sv = new Search_venu(Customer_SSN);
            sv.Show();
            this.Hide(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Search_Movies sm = new Search_Movies(Customer_SSN);
            sm.Show();
            this.Hide(); 
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            Search_date sd = new Search_date();
            sd.Show();
            this.Hide(); 
        }

        private void btn_Time_Click(object sender, EventArgs e)
        {
            Search_Time st = new Search_Time();
            st.Show();
            this.Hide(); 
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            Customer_Book_Tickets cbt = new Customer_Book_Tickets(Customer_SSN);
            cbt.Show(); 
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_history vh = new view_history(Customer_SSN);
            vh.Show();
            this.Hide(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cancle_reservation cr = new Cancle_reservation(Customer_SSN);
            cr.Show();
            this.Hide(); 
        }
    }
}
