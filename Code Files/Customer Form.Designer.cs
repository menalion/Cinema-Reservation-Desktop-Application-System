namespace Cinema_Reservation_System
{
    partial class Customer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.Registre_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sign_In_btn = new System.Windows.Forms.Button();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.l_first = new System.Windows.Forms.Label();
            this.l_last = new System.Windows.Forms.Label();
            this.l_ssn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Our Dear Customer ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 543);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(220, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To The Main Form";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(913, 543);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 24);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Exit system";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(554, 84);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(174, 44);
            this.LogIn_btn.TabIndex = 3;
            this.LogIn_btn.Text = "Log in";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // Registre_btn
            // 
            this.Registre_btn.Location = new System.Drawing.Point(554, 213);
            this.Registre_btn.Name = "Registre_btn";
            this.Registre_btn.Size = new System.Drawing.Size(174, 44);
            this.Registre_btn.TabIndex = 4;
            this.Registre_btn.Text = "Registre";
            this.Registre_btn.UseVisualStyleBackColor = true;
            this.Registre_btn.Click += new System.EventHandler(this.Registre_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "If You Are A New Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "If You Have Registre Before";
            // 
            // Sign_In_btn
            // 
            this.Sign_In_btn.Location = new System.Drawing.Point(397, 475);
            this.Sign_In_btn.Name = "Sign_In_btn";
            this.Sign_In_btn.Size = new System.Drawing.Size(174, 40);
            this.Sign_In_btn.TabIndex = 7;
            this.Sign_In_btn.Text = "Sign In";
            this.Sign_In_btn.UseVisualStyleBackColor = true;
            this.Sign_In_btn.Visible = false;
            this.Sign_In_btn.Click += new System.EventHandler(this.Sign_In_btn_Click);
            // 
            // txt_first
            // 
            this.txt_first.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_first.Location = new System.Drawing.Point(569, 343);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(161, 24);
            this.txt_first.TabIndex = 8;
            this.txt_first.Visible = false;
            // 
            // txt_last
            // 
            this.txt_last.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_last.Location = new System.Drawing.Point(569, 387);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(161, 24);
            this.txt_last.TabIndex = 9;
            this.txt_last.Visible = false;
            // 
            // txt_ssn
            // 
            this.txt_ssn.Location = new System.Drawing.Point(569, 426);
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.PasswordChar = '*';
            this.txt_ssn.Size = new System.Drawing.Size(161, 24);
            this.txt_ssn.TabIndex = 10;
            this.txt_ssn.Visible = false;
            // 
            // l_first
            // 
            this.l_first.AutoSize = true;
            this.l_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_first.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_first.Location = new System.Drawing.Point(236, 343);
            this.l_first.Name = "l_first";
            this.l_first.Size = new System.Drawing.Size(119, 24);
            this.l_first.TabIndex = 11;
            this.l_first.Text = "First Name";
            this.l_first.Visible = false;
            // 
            // l_last
            // 
            this.l_last.AutoSize = true;
            this.l_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_last.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_last.Location = new System.Drawing.Point(236, 387);
            this.l_last.Name = "l_last";
            this.l_last.Size = new System.Drawing.Size(115, 24);
            this.l_last.TabIndex = 12;
            this.l_last.Text = "Last Name";
            this.l_last.Visible = false;
            // 
            // l_ssn
            // 
            this.l_ssn.AutoSize = true;
            this.l_ssn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_ssn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ssn.Location = new System.Drawing.Point(236, 426);
            this.l_ssn.Name = "l_ssn";
            this.l_ssn.Size = new System.Drawing.Size(245, 24);
            this.l_ssn.TabIndex = 13;
            this.l_ssn.Text = "Serial Security Number";
            this.l_ssn.Visible = false;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 586);
            this.Controls.Add(this.l_ssn);
            this.Controls.Add(this.l_last);
            this.Controls.Add(this.l_first);
            this.Controls.Add(this.txt_ssn);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.Sign_In_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registre_btn);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.Button Registre_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sign_In_btn;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.TextBox txt_ssn;
        private System.Windows.Forms.Label l_first;
        private System.Windows.Forms.Label l_last;
        private System.Windows.Forms.Label l_ssn;
    }
}