namespace Cinema_Reservation_System
{
    partial class Customer_Registre
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Registre_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_SSN = new System.Windows.Forms.TextBox();
            this.txt_second_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 29);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "By Pressing Registre , You Accept All our Private Condtions";
            // 
            // Registre_btn
            // 
            this.Registre_btn.Location = new System.Drawing.Point(380, 494);
            this.Registre_btn.Name = "Registre_btn";
            this.Registre_btn.Size = new System.Drawing.Size(184, 35);
            this.Registre_btn.TabIndex = 2;
            this.Registre_btn.Text = "Registre";
            this.Registre_btn.UseVisualStyleBackColor = true;
            this.Registre_btn.Click += new System.EventHandler(this.Registre_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(133, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(133, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(133, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(133, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Serial Security Number";
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(629, 83);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(166, 24);
            this.txt_First.TabIndex = 7;
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(629, 149);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(166, 24);
            this.txt_Last.TabIndex = 8;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(629, 212);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(93, 24);
            this.txt_Age.TabIndex = 9;
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(629, 282);
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.PasswordChar = '*';
            this.txt_SSN.Size = new System.Drawing.Size(166, 24);
            this.txt_SSN.TabIndex = 10;
            // 
            // txt_second_time
            // 
            this.txt_second_time.Location = new System.Drawing.Point(629, 356);
            this.txt_second_time.Name = "txt_second_time";
            this.txt_second_time.PasswordChar = '*';
            this.txt_second_time.Size = new System.Drawing.Size(166, 24);
            this.txt_second_time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(133, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter SSN Again";
            // 
            // Customer_Registre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 574);
            this.Controls.Add(this.txt_second_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SSN);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.txt_Last);
            this.Controls.Add(this.txt_First);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registre_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Customer_Registre";
            this.Text = "Customer_Registre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registre_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_First;
        private System.Windows.Forms.TextBox txt_Last;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.TextBox txt_SSN;
        private System.Windows.Forms.TextBox txt_second_time;
        private System.Windows.Forms.Label label6;
    }
}