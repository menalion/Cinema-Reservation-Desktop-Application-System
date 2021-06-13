namespace Cinema_Reservation_System
{
    partial class Customer_Book_Tickets
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
            System.Windows.Forms.Label label3;
            this.Back = new System.Windows.Forms.LinkLabel();
            this.cmb_Movies = new System.Windows.Forms.ComboBox();
            this.Movies_Label = new System.Windows.Forms.Label();
            this.cmb_Cinemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Screens = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tickets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_seats = new System.Windows.Forms.Label();
            this.l_venue = new System.Windows.Forms.Label();
            this.btn_Book = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(435, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(347, 34);
            label3.TabIndex = 8;
            label3.Text = "Choose What You Want";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(24, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 34);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // cmb_Movies
            // 
            this.cmb_Movies.FormattingEnabled = true;
            this.cmb_Movies.Location = new System.Drawing.Point(821, 147);
            this.cmb_Movies.Name = "cmb_Movies";
            this.cmb_Movies.Size = new System.Drawing.Size(202, 24);
            this.cmb_Movies.TabIndex = 1;
            this.cmb_Movies.SelectedIndexChanged += new System.EventHandler(this.cmb_Movies_SelectedIndexChanged);
            // 
            // Movies_Label
            // 
            this.Movies_Label.AutoSize = true;
            this.Movies_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies_Label.ForeColor = System.Drawing.Color.Black;
            this.Movies_Label.Location = new System.Drawing.Point(40, 147);
            this.Movies_Label.Name = "Movies_Label";
            this.Movies_Label.Size = new System.Drawing.Size(201, 24);
            this.Movies_Label.TabIndex = 2;
            this.Movies_Label.Text = "Choose Your Movie";
            // 
            // cmb_Cinemas
            // 
            this.cmb_Cinemas.FormattingEnabled = true;
            this.cmb_Cinemas.Location = new System.Drawing.Point(821, 226);
            this.cmb_Cinemas.Name = "cmb_Cinemas";
            this.cmb_Cinemas.Size = new System.Drawing.Size(202, 24);
            this.cmb_Cinemas.TabIndex = 3;
            this.cmb_Cinemas.SelectedIndexChanged += new System.EventHandler(this.cmb_Cinemas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose The Cinema You Want ";
            // 
            // cmb_Screens
            // 
            this.cmb_Screens.FormattingEnabled = true;
            this.cmb_Screens.Location = new System.Drawing.Point(821, 325);
            this.cmb_Screens.Name = "cmb_Screens";
            this.cmb_Screens.Size = new System.Drawing.Size(202, 24);
            this.cmb_Screens.TabIndex = 5;
            this.cmb_Screens.SelectedIndexChanged += new System.EventHandler(this.cmb_Screens_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose The Date and Time You Want";
            // 
            // txt_tickets
            // 
            this.txt_tickets.Location = new System.Drawing.Point(548, 419);
            this.txt_tickets.Name = "txt_tickets";
            this.txt_tickets.Size = new System.Drawing.Size(202, 24);
            this.txt_tickets.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(186, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter The Number Of Ticekts";
            // 
            // l_seats
            // 
            this.l_seats.AutoSize = true;
            this.l_seats.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_seats.ForeColor = System.Drawing.Color.Black;
            this.l_seats.Location = new System.Drawing.Point(785, 419);
            this.l_seats.Name = "l_seats";
            this.l_seats.Size = new System.Drawing.Size(83, 24);
            this.l_seats.TabIndex = 10;
            this.l_seats.Text = "Label 2";
            this.l_seats.Visible = false;
            // 
            // l_venue
            // 
            this.l_venue.AutoSize = true;
            this.l_venue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_venue.ForeColor = System.Drawing.Color.Black;
            this.l_venue.Location = new System.Drawing.Point(507, 226);
            this.l_venue.Name = "l_venue";
            this.l_venue.Size = new System.Drawing.Size(83, 24);
            this.l_venue.TabIndex = 11;
            this.l_venue.Text = "Label 1";
            this.l_venue.Visible = false;
            // 
            // btn_Book
            // 
            this.btn_Book.FlatAppearance.BorderSize = 0;
            this.btn_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Book.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.Black;
            this.btn_Book.Location = new System.Drawing.Point(548, 505);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(202, 29);
            this.btn_Book.TabIndex = 12;
            this.btn_Book.Text = "Book_Order";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // Customer_Book_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 567);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.l_venue);
            this.Controls.Add(this.l_seats);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txt_tickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Screens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Cinemas);
            this.Controls.Add(this.Movies_Label);
            this.Controls.Add(this.cmb_Movies);
            this.Controls.Add(this.Back);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "Customer_Book_Tickets";
            this.Text = "Customer_Book_Tickets";
            this.Load += new System.EventHandler(this.Customer_Book_Tickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.ComboBox cmb_Movies;
        private System.Windows.Forms.Label Movies_Label;
        private System.Windows.Forms.ComboBox cmb_Cinemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Screens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_seats;
        private System.Windows.Forms.Label l_venue;
        private System.Windows.Forms.Button btn_Book;
    }
}