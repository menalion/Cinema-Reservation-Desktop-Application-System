namespace Cinema_Reservation_System
{
    partial class Search_date
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.dgv_Date_Movies = new System.Windows.Forms.DataGridView();
            this.btn_serach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Date_Movies)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(23, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 34);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter The Month";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(885, 145);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(245, 24);
            this.txt_month.TabIndex = 3;
            // 
            // dgv_Date_Movies
            // 
            this.dgv_Date_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Date_Movies.Location = new System.Drawing.Point(12, 279);
            this.dgv_Date_Movies.Name = "dgv_Date_Movies";
            this.dgv_Date_Movies.RowTemplate.Height = 26;
            this.dgv_Date_Movies.Size = new System.Drawing.Size(1245, 210);
            this.dgv_Date_Movies.TabIndex = 4;
            // 
            // btn_serach
            // 
            this.btn_serach.FlatAppearance.BorderSize = 0;
            this.btn_serach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serach.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serach.Location = new System.Drawing.Point(485, 191);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(292, 42);
            this.btn_serach.TabIndex = 5;
            this.btn_serach.Text = "Search";
            this.btn_serach.UseVisualStyleBackColor = true;
            this.btn_serach.Click += new System.EventHandler(this.btn_serach_Click);
            // 
            // Search_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 632);
            this.Controls.Add(this.btn_serach);
            this.Controls.Add(this.dgv_Date_Movies);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Name = "Search_date";
            this.Text = "Search Date";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Date_Movies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.DataGridView dgv_Date_Movies;
        private System.Windows.Forms.Button btn_serach;
    }
}