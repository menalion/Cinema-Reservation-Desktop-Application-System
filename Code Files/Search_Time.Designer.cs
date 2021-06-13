namespace Cinema_Reservation_System
{
    partial class Search_Time
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
            this.btn_Serach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Hour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Hour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(24, 19);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 29);
            this.Back.TabIndex = 0;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // btn_Serach
            // 
            this.btn_Serach.FlatAppearance.BorderSize = 0;
            this.btn_Serach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Serach.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Serach.Location = new System.Drawing.Point(373, 205);
            this.btn_Serach.Name = "btn_Serach";
            this.btn_Serach.Size = new System.Drawing.Size(449, 42);
            this.btn_Serach.TabIndex = 1;
            this.btn_Serach.Text = "Search";
            this.btn_Serach.UseVisualStyleBackColor = true;
            this.btn_Serach.Click += new System.EventHandler(this.btn_Serach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(447, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "System Time is 24";
            // 
            // txt_Hour
            // 
            this.txt_Hour.Location = new System.Drawing.Point(849, 148);
            this.txt_Hour.Name = "txt_Hour";
            this.txt_Hour.Size = new System.Drawing.Size(195, 24);
            this.txt_Hour.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter The Hour";
            // 
            // dgv_Hour
            // 
            this.dgv_Hour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hour.Location = new System.Drawing.Point(12, 275);
            this.dgv_Hour.Name = "dgv_Hour";
            this.dgv_Hour.RowTemplate.Height = 26;
            this.dgv_Hour.Size = new System.Drawing.Size(1255, 167);
            this.dgv_Hour.TabIndex = 5;
            // 
            // Search_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 519);
            this.Controls.Add(this.dgv_Hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Hour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Serach);
            this.Controls.Add(this.Back);
            this.Name = "Search_Time";
            this.Text = "Search_Time";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.Button btn_Serach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Hour;
    }
}