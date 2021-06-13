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
    public partial class ALter_Screens : Form
    {
        static int SSN_Manager; 
        public ALter_Screens()
        {
            InitializeComponent();
        }
        public ALter_Screens(int n)
        {
            SSN_Manager = n; 
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager_Functions mf = new Manager_Functions();
            mf.Show();
            this.Hide(); 
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Builder_Screen bs = new Builder_Screen(SSN_Manager);
            bs.Show();
            this.Hide(); 
        }

        private void btn_films_screens_Click(object sender, EventArgs e)
        {
            Remove_Movies_Screens rms = new Remove_Movies_Screens(SSN_Manager);
            rms.Show();
            this.Hide(); 
        }

        private void btn_Screens_Click(object sender, EventArgs e)
        {
            Insert_Into_Screens iis = new Insert_Into_Screens(SSN_Manager);
            iis.Show();
            this.Hide(); 
        }
    }
}
