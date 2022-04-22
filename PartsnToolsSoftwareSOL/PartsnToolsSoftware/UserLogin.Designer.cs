namespace PartsnToolsSoftware
{
    partial class UserLogin
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
            this.AdminButton = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNamePasswordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterUserNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.AutoSize = true;
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AdminButton.Location = new System.Drawing.Point(183, 269);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(52, 19);
            this.AdminButton.TabIndex = 31;
            this.AdminButton.Text = "Admin";
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(170, 233);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 25);
            this.LoginButton.TabIndex = 30;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNamePasswordTb
            // 
            this.UserNamePasswordTb.Location = new System.Drawing.Point(119, 194);
            this.UserNamePasswordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNamePasswordTb.Name = "UserNamePasswordTb";
            this.UserNamePasswordTb.Size = new System.Drawing.Size(174, 23);
            this.UserNamePasswordTb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // EnterUserNameTb
            // 
            this.EnterUserNameTb.Location = new System.Drawing.Point(119, 137);
            this.EnterUserNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterUserNameTb.Name = "EnterUserNameTb";
            this.EnterUserNameTb.Size = new System.Drawing.Size(174, 23);
            this.EnterUserNameTb.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Version 1.2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 4);
            this.panel1.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(21, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(387, 31);
            this.label14.TabIndex = 23;
            this.label14.Text = "Parts n\' Tools Inventory System";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(444, 416);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserNamePasswordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterUserNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AdminButton;
        private Button LoginButton;
        private TextBox UserNamePasswordTb;
        private Label label2;
        private TextBox EnterUserNameTb;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label14;
    }
}