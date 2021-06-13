namespace Cinema_Reservation_System
{
    partial class Serach_categories
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gid_view_master = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.l_categories = new System.Windows.Forms.Label();
            this.cmb_categoires = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gid_view_master)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gid_view_master);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.l_categories);
            this.groupBox1.Controls.Add(this.cmb_categoires);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 438);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Movies By Categories";
            // 
            // Gid_view_master
            // 
            this.Gid_view_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gid_view_master.Location = new System.Drawing.Point(24, 147);
            this.Gid_view_master.Name = "Gid_view_master";
            this.Gid_view_master.RowTemplate.Height = 26;
            this.Gid_view_master.Size = new System.Drawing.Size(956, 266);
            this.Gid_view_master.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(1009, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // l_categories
            // 
            this.l_categories.AutoSize = true;
            this.l_categories.Location = new System.Drawing.Point(176, 70);
            this.l_categories.Name = "l_categories";
            this.l_categories.Size = new System.Drawing.Size(179, 24);
            this.l_categories.TabIndex = 5;
            this.l_categories.Text = "Choose Category";
            // 
            // cmb_categoires
            // 
            this.cmb_categoires.FormattingEnabled = true;
            this.cmb_categoires.Location = new System.Drawing.Point(751, 62);
            this.cmb_categoires.Name = "cmb_categoires";
            this.cmb_categoires.Size = new System.Drawing.Size(198, 32);
            this.cmb_categoires.TabIndex = 4;
            this.cmb_categoires.SelectedIndexChanged += new System.EventHandler(this.cmb_categoires_SelectedIndexChanged);
            // 
            // Serach_categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 512);
            this.Controls.Add(this.groupBox1);
            this.Name = "Serach_categories";
            this.Text = "Serach_categories";
            this.Load += new System.EventHandler(this.Serach_categories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gid_view_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_categories;
        private System.Windows.Forms.ComboBox cmb_categoires;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView Gid_view_master;
    }
}