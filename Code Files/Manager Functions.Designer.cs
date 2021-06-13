namespace Cinema_Reservation_System
{
    partial class Manager_Functions
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
            this.l_Name_Manger = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_cinema = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Screens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Name_Manger
            // 
            this.l_Name_Manger.AutoSize = true;
            this.l_Name_Manger.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name_Manger.Location = new System.Drawing.Point(456, 9);
            this.l_Name_Manger.Name = "l_Name_Manger";
            this.l_Name_Manger.Size = new System.Drawing.Size(85, 29);
            this.l_Name_Manger.TabIndex = 1;
            this.l_Name_Manger.Text = "label1";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.LinkColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(1074, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(60, 29);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = true;
            this.Exit.Text = "Exit";
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 29);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_cinema
            // 
            this.btn_cinema.FlatAppearance.BorderSize = 0;
            this.btn_cinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cinema.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinema.Location = new System.Drawing.Point(366, 66);
            this.btn_cinema.Name = "btn_cinema";
            this.btn_cinema.Size = new System.Drawing.Size(347, 41);
            this.btn_cinema.TabIndex = 6;
            this.btn_cinema.Text = "Show Cinema Screens Details";
            this.btn_cinema.UseVisualStyleBackColor = true;
            this.btn_cinema.Click += new System.EventHandler(this.btn_cinema_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "View ScreenReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "View Income Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(366, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(347, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modify Cinema Movies";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Screens
            // 
            this.btn_Screens.FlatAppearance.BorderSize = 0;
            this.btn_Screens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Screens.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Screens.Location = new System.Drawing.Point(366, 455);
            this.btn_Screens.Name = "btn_Screens";
            this.btn_Screens.Size = new System.Drawing.Size(347, 41);
            this.btn_Screens.TabIndex = 10;
            this.btn_Screens.Text = "Alter Screens";
            this.btn_Screens.UseVisualStyleBackColor = true;
            this.btn_Screens.Click += new System.EventHandler(this.btn_Screens_Click);
            // 
            // Manager_Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 615);
            this.Controls.Add(this.btn_Screens);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cinema);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.l_Name_Manger);
            this.Name = "Manager_Functions";
            this.Text = "Manager_Functions";
            this.Load += new System.EventHandler(this.Manager_Functions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label l_Name_Manger;
        private System.Windows.Forms.LinkLabel Exit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_cinema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Screens;
    }
}