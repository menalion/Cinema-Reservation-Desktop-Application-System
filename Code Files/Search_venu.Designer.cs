namespace Cinema_Reservation_System
{
    partial class Search_venu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vneu = new System.Windows.Forms.TextBox();
            this.txt_seach = new System.Windows.Forms.Button();
            this.Gid_view_master = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Gid_view_master)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(12, 28);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 34);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(303, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Max Venue For the Single Ticket You Like To Pay";
            // 
            // txt_vneu
            // 
            this.txt_vneu.Location = new System.Drawing.Point(546, 148);
            this.txt_vneu.Name = "txt_vneu";
            this.txt_vneu.Size = new System.Drawing.Size(330, 24);
            this.txt_vneu.TabIndex = 2;
            // 
            // txt_seach
            // 
            this.txt_seach.FlatAppearance.BorderSize = 0;
            this.txt_seach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_seach.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_seach.Location = new System.Drawing.Point(546, 231);
            this.txt_seach.Name = "txt_seach";
            this.txt_seach.Size = new System.Drawing.Size(330, 34);
            this.txt_seach.TabIndex = 3;
            this.txt_seach.Text = "Search";
            this.txt_seach.UseVisualStyleBackColor = true;
            this.txt_seach.Click += new System.EventHandler(this.txt_seach_Click);
            // 
            // Gid_view_master
            // 
            this.Gid_view_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gid_view_master.Location = new System.Drawing.Point(329, 290);
            this.Gid_view_master.Name = "Gid_view_master";
            this.Gid_view_master.RowTemplate.Height = 26;
            this.Gid_view_master.Size = new System.Drawing.Size(740, 226);
            this.Gid_view_master.TabIndex = 4;
            // 
            // Search_venu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 562);
            this.Controls.Add(this.Gid_view_master);
            this.Controls.Add(this.txt_seach);
            this.Controls.Add(this.txt_vneu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Search_venu";
            this.Text = "Search_venu";
            ((System.ComponentModel.ISupportInitialize)(this.Gid_view_master)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vneu;
        private System.Windows.Forms.Button txt_seach;
        private System.Windows.Forms.DataGridView Gid_view_master;
    }
}