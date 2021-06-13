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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Transfer_Button_Click(object sender, EventArgs e)
        {
            if (Customer_radio.Checked)
            {
                Customer_Form c = new Customer_Form();
                c.Show(); 
            }
            else if (Manager_radio.Checked)
            {
                Manager_Form m = new Manager_Form();
                m.Show(); 
            }
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We Hope That We serve You Well", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            Application.Exit(); 
        }

        private void Manager_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
