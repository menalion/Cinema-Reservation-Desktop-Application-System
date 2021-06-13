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
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Form m = new Main_Form();
            m.Show(); 
            this.Hide(); 
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter The SSN For You Sir", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            if (txt_SSN.Text == "")
            {MessageBox.Show("Please Enter The SSN", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error); return ; }
            double num;
            bool isright = double.TryParse(txt_SSN.Text.Trim(), out num);
            if (!isright)
            { MessageBox.Show("The SSN Must Be A Number", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string con_str = "data source = orcl ; password = scott ; user id = scott;"; 
            OracleConnection con = new OracleConnection(con_str);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select First_Name , Last_Name from CINEMA_MANAGER where SSN = :num";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":num", Convert.ToInt32(txt_SSN.Text));
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Welcome Master " + rd[0].ToString() + " " + rd[1].ToString(), "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Manager_Functions mf = new Manager_Functions(rd[0].ToString() + " " + rd[1].ToString() , txt_SSN.Text);
                mf.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong SSN Please Try Again", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            rd.Close(); 
            con.Dispose(); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("We Hope That We serve You Well", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit(); 
        }
    }
}
