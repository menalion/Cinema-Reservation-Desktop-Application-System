namespace Cinema_Reservation_System
{
    partial class ALter_Screens
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
            this.btn_Screens = new System.Windows.Forms.Button();
            this.btn_films_screens = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 29);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_Screens
            // 
            this.btn_Screens.FlatAppearance.BorderSize = 0;
            this.btn_Screens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Screens.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Screens.Location = new System.Drawing.Point(198, 67);
            this.btn_Screens.Name = "btn_Screens";
            this.btn_Screens.Size = new System.Drawing.Size(347, 41);
            this.btn_Screens.TabIndex = 11;
            this.btn_Screens.Text = "Modify Films In Screens";
            this.btn_Screens.UseVisualStyleBackColor = true;
            this.btn_Screens.Click += new System.EventHandler(this.btn_Screens_Click);
            // 
            // btn_films_screens
            // 
            this.btn_films_screens.FlatAppearance.BorderSize = 0;
            this.btn_films_screens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_films_screens.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_films_screens.Location = new System.Drawing.Point(132, 153);
            this.btn_films_screens.Name = "btn_films_screens";
            this.btn_films_screens.Size = new System.Drawing.Size(481, 41);
            this.btn_films_screens.TabIndex = 12;
            this.btn_films_screens.Text = "Remove Movies From Screens";
            this.btn_films_screens.UseVisualStyleBackColor = true;
            this.btn_films_screens.Click += new System.EventHandler(this.btn_films_screens_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.FlatAppearance.BorderSize = 0;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(198, 235);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(347, 41);
            this.btn_Modify.TabIndex = 13;
            this.btn_Modify.Text = "Modify Screens";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // ALter_Screens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 488);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_films_screens);
            this.Controls.Add(this.btn_Screens);
            this.Controls.Add(this.linkLabel1);
            this.Name = "ALter_Screens";
            this.Text = "ALter_Screens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Screens;
        private System.Windows.Forms.Button btn_films_screens;
        private System.Windows.Forms.Button btn_Modify;

    }
}