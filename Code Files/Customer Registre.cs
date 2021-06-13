using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types ; 
using Oracle.DataAccess.Client ; 
namespace Cinema_Reservation_System
{
    public partial class Customer_Registre : Form
    {
        double num;
        bool isage, isSSN , issecond  ;
        string con_str = "data source = orcl ; password = scott ; user id = scott;";
        OracleConnection con; 
        public Customer_Registre()
        {
            InitializeComponent();
        }

        private void Registre_btn_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(con_str); 
            con.Open(); 
            if (txt_Age.Text == "" || txt_First.Text == "" || txt_Last.Text == "" || txt_second_time.Text == "" || txt_SSN.Text == "")
            {
                MessageBox.Show("Please Enter Your Data", "Desginer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Dispose(); 
                return;
            }
            isage = double.TryParse(txt_Age.Text.Trim(), out num);
            isSSN = double.TryParse(txt_SSN.Text.Trim(), out num);
            issecond = double.TryParse(txt_second_time.Text.Trim(), out num);
            if ((!isage && !isSSN) || (!isage && !issecond))
            { MessageBox.Show("The SSN  and Age Must Be Numbers", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Error); con.Dispose(); return; }
            else if (!isage)
            { MessageBox.Show("The Age Must Be Number", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Error); con.Dispose(); return; }
            else if (!isSSN || !issecond)
            { MessageBox.Show("The SSN Must Be Number", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Error); con.Dispose(); return; }
            else if (txt_SSN.Text != txt_second_time.Text)
            { MessageBox.Show("The SSN in both  Boxes Are Not The Same", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Error); con.Dispose(); return; }
            OracleCommand cmd = new OracleCommand() ; 
            cmd.Connection = con ; 
            cmd.CommandText = "select SSN from Customer" ; 
            cmd.CommandType = CommandType.Text ;  
            OracleDataReader rd = cmd.ExecuteReader() ; 
            while(rd.Read())
            {
                if (rd[0].ToString() == txt_SSN.Text)
                {
                    rd.Close() ;
                    con.Dispose(); 
                    MessageBox.Show("You Entered Wrong SSN it's Redunt Please Enter it Again", "Desginers", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return; 
                }
            }
            rd.Close(); 
            OracleCommand add_cus = new OracleCommand();
            add_cus.Connection = con;
            add_cus.CommandText = "INSERT_NEW_CUSTOMER"; 
            add_cus.CommandType = CommandType.StoredProcedure;
            add_cus.Parameters.Add("First", txt_First.Text);
            add_cus.Parameters.Add("Second", txt_Last.Text);
            add_cus.Parameters.Add("Age", Convert.ToInt32(txt_Age.Text));
            add_cus.Parameters.Add("SSN", Convert.ToInt32(txt_SSN.Text));
            int n = add_cus.ExecuteNonQuery();
            MessageBox.Show("Let's Go To The Magic World", "Designers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Dispose(); 
            Customer_Form c = new Customer_Form();
            c.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            Customer_Form c = new Customer_Form();
            c.Show(); 
            this.Hide();
        }
    }
}
