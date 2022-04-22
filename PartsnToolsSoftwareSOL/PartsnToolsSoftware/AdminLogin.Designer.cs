namespace PartsnToolsSoftware
{
    partial class AdminLogin
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
            this.BackButton = new System.Windows.Forms.Label();
            this.AdminLogInButton = new System.Windows.Forms.Button();
            this.AdminPasswordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(193, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 19);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminLogInButton
            // 
            this.AdminLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLogInButton.Location = new System.Drawing.Point(173, 174);
            this.AdminLogInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminLogInButton.Name = "AdminLogInButton";
            this.AdminLogInButton.Size = new System.Drawing.Size(80, 25);
            this.AdminLogInButton.TabIndex = 30;
            this.AdminLogInButton.Text = "Login";
            this.AdminLogInButton.UseVisualStyleBackColor = true;
            this.AdminLogInButton.Click += new System.EventHandler(this.AdminLogInButton_Click);
            // 
            // AdminPasswordTb
            // 
            this.AdminPasswordTb.Location = new System.Drawing.Point(123, 142);
            this.AdminPasswordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminPasswordTb.Name = "AdminPasswordTb";
            this.AdminPasswordTb.Size = new System.Drawing.Size(174, 23);
            this.AdminPasswordTb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Admin Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(174, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Version 1.2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 4);
            this.panel1.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(22, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(387, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "Parts n\' Tools Inventory System";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 416);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AdminLogInButton);
            this.Controls.Add(this.AdminPasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BackButton;
        private Button AdminLogInButton;
        private TextBox AdminPasswordTb;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label14;
    }
}