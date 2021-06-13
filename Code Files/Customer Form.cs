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
    public partial class Customer_Form : Form
    {
        bool accept = false;
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form f = new Main_Form();
            f.Show();
            this.Hide(); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("We Hope That We serve You Well", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit(); 
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            DialogResult r  = MessageBox.Show("Enter You First Name , Last Name and You SSN", "Designers", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.Cancel)
                return; 
            Sign_In_btn.Visible = true;
            l_first.Visible = true;
            l_last.Visible = true;
            l_ssn.Visible = true;
            txt_first.Visible = true;
            txt_last.Visible = true;
            txt_ssn.Visible = true; 
        }

        private void Sign_In_btn_Click(object sender, EventArgs e)
        {
            if (txt_first.Text == "" || txt_last.Text == "" || txt_ssn.Text == "")
            { MessageBox.Show("Please Enter Your Data ", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  }
            double num;
            bool OK = double.TryParse(txt_ssn.Text.Trim(), out num);
            if (!OK)
            { MessageBox.Show("The SSN Must  be Number", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  }
            string str_con = "data source = orcl ; user id  = scott ; password = scott";  
            OracleConnection con = new OracleConnection(str_con);
            con.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "LogIn_Customer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader rd = cmd.ExecuteReader(); 
            while(rd.Read())
            {
                if (txt_first.Text == rd[0].ToString() && txt_last.Text == rd[1].ToString() && txt_ssn.Text == rd[2].ToString())
                {
                    accept = true; 
                    break; 
                }
            }
            rd.Close();
            con.Dispose(); 
            if (!accept)
                MessageBox.Show("You Entered Wrong data or you are Not registered", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else
            {
                MessageBox.Show("Welcome To the system Our Dear Customer", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customer_Functions cf = new Customer_Functions(Convert.ToInt32(txt_ssn.Text));
                cf.Show(); 
                this.Hide(); 
            }
        }

        private void Registre_btn_Click(object sender, EventArgs e)
        {
            Customer_Registre r = new Customer_Registre();
            r.Show();
            this.Hide(); 
        }
    }
}
