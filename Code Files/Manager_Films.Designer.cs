namespace Cinema_Reservation_System
{
    partial class Manager_Films
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
            this.cmb_movies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.txt_vnue = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Categories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_venue_update = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cat_update = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 24);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // cmb_movies
            // 
            this.cmb_movies.FormattingEnabled = true;
            this.cmb_movies.Location = new System.Drawing.Point(493, 107);
            this.cmb_movies.Name = "cmb_movies";
            this.cmb_movies.Size = new System.Drawing.Size(197, 24);
            this.cmb_movies.TabIndex = 1;
            this.cmb_movies.SelectedIndexChanged += new System.EventHandler(this.cmb_movies_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cinema Movies";
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.Location = new System.Drawing.Point(16, 332);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(157, 32);
            this.btn_AddMovie.TabIndex = 3;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.UseVisualStyleBackColor = true;
            this.btn_AddMovie.Click += new System.EventHandler(this.btn_AddMovie_Click);
            // 
            // txt_vnue
            // 
            this.txt_vnue.Location = new System.Drawing.Point(222, 222);
            this.txt_vnue.Name = "txt_vnue";
            this.txt_vnue.Size = new System.Drawing.Size(196, 24);
            this.txt_vnue.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(222, 278);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 24);
            this.txt_name.TabIndex = 5;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(223, 404);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(196, 24);
            this.txt_duration.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Venue Of Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hero Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Movie Vategory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duration Of Film";
            // 
            // cmb_Categories
            // 
            this.cmb_Categories.FormattingEnabled = true;
            this.cmb_Categories.Location = new System.Drawing.Point(222, 344);
            this.cmb_Categories.Name = "cmb_Categories";
            this.cmb_Categories.Size = new System.Drawing.Size(197, 24);
            this.cmb_Categories.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(741, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Here The Name Of The New Movie";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(796, 315);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(157, 32);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update Movie Data";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_venue_update
            // 
            this.txt_venue_update.Location = new System.Drawing.Point(975, 242);
            this.txt_venue_update.Name = "txt_venue_update";
            this.txt_venue_update.Size = new System.Drawing.Size(196, 24);
            this.txt_venue_update.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1202, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Venue Of Movie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1203, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Movie Vategory";
            // 
            // cat_update
            // 
            this.cat_update.FormattingEnabled = true;
            this.cat_update.Location = new System.Drawing.Point(975, 360);
            this.cat_update.Name = "cat_update";
            this.cat_update.Size = new System.Drawing.Size(197, 24);
            this.cat_update.TabIndex = 18;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(614, 528);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(157, 24);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete Movie From Cinema";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Manager_Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 634);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cat_update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_venue_update);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Categories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_vnue);
            this.Controls.Add(this.btn_AddMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_movies);
            this.Controls.Add(this.Back);
            this.Name = "Manager_Films";
            this.Text = "Manager_Films";
            this.Load += new System.EventHandler(this.Manager_Films_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.ComboBox cmb_movies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.TextBox txt_vnue;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Categories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_venue_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cat_update;
        private System.Windows.Forms.Button btn_delete;
    }
}