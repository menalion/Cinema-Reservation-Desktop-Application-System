﻿namespace Cinema_Reservation_System
{
    partial class Cinema_Screen_details
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
            this.dgv_Screens = new System.Windows.Forms.DataGridView();
            this.dgv_Films_on_screen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Screens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Films_on_screen)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(23, 21);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 29);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // dgv_Screens
            // 
            this.dgv_Screens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Screens.Location = new System.Drawing.Point(12, 197);
            this.dgv_Screens.Name = "dgv_Screens";
            this.dgv_Screens.RowTemplate.Height = 26;
            this.dgv_Screens.Size = new System.Drawing.Size(167, 311);
            this.dgv_Screens.TabIndex = 1;
            // 
            // dgv_Films_on_screen
            // 
            this.dgv_Films_on_screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Films_on_screen.Location = new System.Drawing.Point(217, 236);
            this.dgv_Films_on_screen.Name = "dgv_Films_on_screen";
            this.dgv_Films_on_screen.RowTemplate.Height = 26;
            this.dgv_Films_on_screen.Size = new System.Drawing.Size(1154, 237);
            this.dgv_Films_on_screen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(465, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select The Screen To Show Films";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(693, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Films Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Screen Id\'s";
            // 
            // Cinema_Screen_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Films_on_screen);
            this.Controls.Add(this.dgv_Screens);
            this.Controls.Add(this.Back);
            this.Name = "Cinema_Screen_details";
            this.Text = "Cinema_Screen_details";
            this.Load += new System.EventHandler(this.Cinema_Screen_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Screens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Films_on_screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.DataGridView dgv_Screens;
        private System.Windows.Forms.DataGridView dgv_Films_on_screen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}