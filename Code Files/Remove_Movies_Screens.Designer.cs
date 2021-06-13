namespace Cinema_Reservation_System
{
    partial class Remove_Movies_Screens
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
            this.Back = new System.Windows.Forms.LinkLabel();
            this.cmb_screens = new System.Windows.Forms.ComboBox();
            this.cmb_Movies = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 29);
            this.Back.TabIndex = 7;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // cmb_screens
            // 
            this.cmb_screens.FormattingEnabled = true;
            this.cmb_screens.Location = new System.Drawing.Point(822, 105);
            this.cmb_screens.Name = "cmb_screens";
            this.cmb_screens.Size = new System.Drawing.Size(245, 24);
            this.cmb_screens.TabIndex = 8;
            this.cmb_screens.SelectedIndexChanged += new System.EventHandler(this.cmb_screens_SelectedIndexChanged);
            // 
            // cmb_Movies
            // 
            this.cmb_Movies.FormattingEnabled = true;
            this.cmb_Movies.Location = new System.Drawing.Point(822, 225);
            this.cmb_Movies.Name = "cmb_Movies";
            this.cmb_Movies.Size = new System.Drawing.Size(245, 24);
            this.cmb_Movies.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Screen ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Movies In The Screen";
            // 
            // Remove_Movies_Screens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Movies);
            this.Controls.Add(this.cmb_screens);
            this.Controls.Add(this.Back);
            this.Name = "Remove_Movies_Screens";
            this.Text = "Remove_Movies_Screens";
            this.Load += new System.EventHandler(this.Remove_Movies_Screens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.ComboBox cmb_screens;
        private System.Windows.Forms.ComboBox cmb_Movies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}