namespace Cinema_Reservation_System
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Manager_radio = new System.Windows.Forms.RadioButton();
            this.Customer_radio = new System.Windows.Forms.RadioButton();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Cinema Reservation System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Manager_radio);
            this.groupBox1.Controls.Add(this.Customer_radio);
            this.groupBox1.Location = new System.Drawing.Point(366, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Customer Or Manager";
            // 
            // Manager_radio
            // 
            this.Manager_radio.AutoSize = true;
            this.Manager_radio.Location = new System.Drawing.Point(40, 80);
            this.Manager_radio.Name = "Manager_radio";
            this.Manager_radio.Size = new System.Drawing.Size(117, 21);
            this.Manager_radio.TabIndex = 1;
            this.Manager_radio.TabStop = true;
            this.Manager_radio.Text = "Manager Form";
            this.Manager_radio.UseVisualStyleBackColor = true;
            this.Manager_radio.CheckedChanged += new System.EventHandler(this.Manager_radio_CheckedChanged);
            // 
            // Customer_radio
            // 
            this.Customer_radio.AutoSize = true;
            this.Customer_radio.Location = new System.Drawing.Point(40, 43);
            this.Customer_radio.Name = "Customer_radio";
            this.Customer_radio.Size = new System.Drawing.Size(125, 21);
            this.Customer_radio.TabIndex = 0;
            this.Customer_radio.TabStop = true;
            this.Customer_radio.Text = "Customer Form";
            this.Customer_radio.UseVisualStyleBackColor = true;
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.Location = new System.Drawing.Point(406, 316);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(143, 35);
            this.Transfer_btn.TabIndex = 2;
            this.Transfer_btn.Text = "Go To Main Form";
            this.Transfer_btn.UseVisualStyleBackColor = true;
            this.Transfer_btn.Click += new System.EventHandler(this.Transfer_Button_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(406, 379);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(143, 35);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "System Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 464);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Transfer_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Manager_radio;
        private System.Windows.Forms.RadioButton Customer_radio;
        private System.Windows.Forms.Button Transfer_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

