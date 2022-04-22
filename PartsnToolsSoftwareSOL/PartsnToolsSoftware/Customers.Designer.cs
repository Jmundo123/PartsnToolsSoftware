namespace PartsnToolsSoftware
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.label2 = new System.Windows.Forms.Label();
            this.SelectCustomerGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerGridData = new System.Windows.Forms.DataGridView();
            this.CustomerDateJoined = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.CustDeleteButton = new System.Windows.Forms.Button();
            this.CustEditButton = new System.Windows.Forms.Button();
            this.CustSaveButton = new System.Windows.Forms.Button();
            this.EnterCustomerPhoneNumberTb = new System.Windows.Forms.TextBox();
            this.EnterCustomerAddressTb = new System.Windows.Forms.TextBox();
            this.EnterCustomerNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CustLblS = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustToEmpLbl = new System.Windows.Forms.Label();
            this.CustToManufactLbl = new System.Windows.Forms.Label();
            this.CustToInvLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustToHSMLbl = new System.Windows.Forms.Label();
            this.CustToLogInSLbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridData)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(449, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "List of Customers";
            // 
            // SelectCustomerGender
            // 
            this.SelectCustomerGender.FormattingEnabled = true;
            this.SelectCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SelectCustomerGender.Location = new System.Drawing.Point(11, 103);
            this.SelectCustomerGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectCustomerGender.Name = "SelectCustomerGender";
            this.SelectCustomerGender.Size = new System.Drawing.Size(120, 23);
            this.SelectCustomerGender.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.CustomerGridData);
            this.panel3.Controls.Add(this.SelectCustomerGender);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CustomerDateJoined);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CustDeleteButton);
            this.panel3.Controls.Add(this.CustEditButton);
            this.panel3.Controls.Add(this.CustSaveButton);
            this.panel3.Controls.Add(this.EnterCustomerPhoneNumberTb);
            this.panel3.Controls.Add(this.EnterCustomerAddressTb);
            this.panel3.Controls.Add(this.EnterCustomerNameTb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(204, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 376);
            this.panel3.TabIndex = 28;
            // 
            // CustomerGridData
            // 
            this.CustomerGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridData.Location = new System.Drawing.Point(10, 139);
            this.CustomerGridData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGridData.Name = "CustomerGridData";
            this.CustomerGridData.RowHeadersWidth = 51;
            this.CustomerGridData.RowTemplate.Height = 29;
            this.CustomerGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridData.Size = new System.Drawing.Size(752, 220);
            this.CustomerGridData.TabIndex = 29;
            this.CustomerGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridData_CellContentClick);
            // 
            // CustomerDateJoined
            // 
            this.CustomerDateJoined.Location = new System.Drawing.Point(550, 56);
            this.CustomerDateJoined.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerDateJoined.Name = "CustomerDateJoined";
            this.CustomerDateJoined.Size = new System.Drawing.Size(182, 23);
            this.CustomerDateJoined.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(305, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Customer List";
            // 
            // CustDeleteButton
            // 
            this.CustDeleteButton.Location = new System.Drawing.Point(414, 80);
            this.CustDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustDeleteButton.Name = "CustDeleteButton";
            this.CustDeleteButton.Size = new System.Drawing.Size(80, 25);
            this.CustDeleteButton.TabIndex = 22;
            this.CustDeleteButton.Text = "Delete";
            this.CustDeleteButton.UseVisualStyleBackColor = true;
            this.CustDeleteButton.Click += new System.EventHandler(this.CustDeleteButton_Click);
            // 
            // CustEditButton
            // 
            this.CustEditButton.Location = new System.Drawing.Point(304, 81);
            this.CustEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustEditButton.Name = "CustEditButton";
            this.CustEditButton.Size = new System.Drawing.Size(80, 25);
            this.CustEditButton.TabIndex = 21;
            this.CustEditButton.Text = "Edit";
            this.CustEditButton.UseVisualStyleBackColor = true;
            this.CustEditButton.Click += new System.EventHandler(this.CustEditButton_Click);
            // 
            // CustSaveButton
            // 
            this.CustSaveButton.Location = new System.Drawing.Point(204, 81);
            this.CustSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustSaveButton.Name = "CustSaveButton";
            this.CustSaveButton.Size = new System.Drawing.Size(80, 25);
            this.CustSaveButton.TabIndex = 20;
            this.CustSaveButton.Text = "Save";
            this.CustSaveButton.UseVisualStyleBackColor = true;
            this.CustSaveButton.Click += new System.EventHandler(this.CustSaveButton_Click);
            // 
            // EnterCustomerPhoneNumberTb
            // 
            this.EnterCustomerPhoneNumberTb.Location = new System.Drawing.Point(396, 56);
            this.EnterCustomerPhoneNumberTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterCustomerPhoneNumberTb.Name = "EnterCustomerPhoneNumberTb";
            this.EnterCustomerPhoneNumberTb.Size = new System.Drawing.Size(144, 23);
            this.EnterCustomerPhoneNumberTb.TabIndex = 16;
            // 
            // EnterCustomerAddressTb
            // 
            this.EnterCustomerAddressTb.Location = new System.Drawing.Point(189, 56);
            this.EnterCustomerAddressTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterCustomerAddressTb.Name = "EnterCustomerAddressTb";
            this.EnterCustomerAddressTb.Size = new System.Drawing.Size(202, 23);
            this.EnterCustomerAddressTb.TabIndex = 15;
            // 
            // EnterCustomerNameTb
            // 
            this.EnterCustomerNameTb.Location = new System.Drawing.Point(10, 56);
            this.EnterCustomerNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterCustomerNameTb.Name = "EnterCustomerNameTb";
            this.EnterCustomerNameTb.Size = new System.Drawing.Size(174, 23);
            this.EnterCustomerNameTb.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(550, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date Joined";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(396, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(189, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(14, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer Details";
            // 
            // CustLblS
            // 
            this.CustLblS.AutoSize = true;
            this.CustLblS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustLblS.Location = new System.Drawing.Point(25, 7);
            this.CustLblS.Name = "CustLblS";
            this.CustLblS.Size = new System.Drawing.Size(81, 19);
            this.CustLblS.TabIndex = 21;
            this.CustLblS.Text = "Customers";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.CustLblS);
            this.panel5.Location = new System.Drawing.Point(30, 223);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 36);
            this.panel5.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts n\' Tools";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustToEmpLbl
            // 
            this.CustToEmpLbl.AutoSize = true;
            this.CustToEmpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustToEmpLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustToEmpLbl.Location = new System.Drawing.Point(50, 301);
            this.CustToEmpLbl.Name = "CustToEmpLbl";
            this.CustToEmpLbl.Size = new System.Drawing.Size(82, 19);
            this.CustToEmpLbl.TabIndex = 10;
            this.CustToEmpLbl.Text = "Employees";
            this.CustToEmpLbl.Click += new System.EventHandler(this.CustToEmpLbl_Click);
            // 
            // CustToManufactLbl
            // 
            this.CustToManufactLbl.AutoSize = true;
            this.CustToManufactLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustToManufactLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustToManufactLbl.Location = new System.Drawing.Point(38, 267);
            this.CustToManufactLbl.Name = "CustToManufactLbl";
            this.CustToManufactLbl.Size = new System.Drawing.Size(109, 19);
            this.CustToManufactLbl.TabIndex = 9;
            this.CustToManufactLbl.Text = "Manufacturers";
            this.CustToManufactLbl.Click += new System.EventHandler(this.CustToManufactLbl_Click);
            // 
            // CustToInvLbl
            // 
            this.CustToInvLbl.AutoSize = true;
            this.CustToInvLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustToInvLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustToInvLbl.Location = new System.Drawing.Point(58, 196);
            this.CustToInvLbl.Name = "CustToInvLbl";
            this.CustToInvLbl.Size = new System.Drawing.Size(74, 19);
            this.CustToInvLbl.TabIndex = 8;
            this.CustToInvLbl.Text = "Inventory";
            this.CustToInvLbl.Click += new System.EventHandler(this.CustToInvLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.CustToHSMLbl);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.CustToLogInSLbl);
            this.panel1.Controls.Add(this.CustToEmpLbl);
            this.panel1.Controls.Add(this.CustToManufactLbl);
            this.panel1.Controls.Add(this.CustToInvLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 444);
            this.panel1.TabIndex = 27;
            // 
            // CustToHSMLbl
            // 
            this.CustToHSMLbl.AutoSize = true;
            this.CustToHSMLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustToHSMLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustToHSMLbl.Location = new System.Drawing.Point(28, 163);
            this.CustToHSMLbl.Name = "CustToHSMLbl";
            this.CustToHSMLbl.Size = new System.Drawing.Size(143, 19);
            this.CustToHSMLbl.TabIndex = 21;
            this.CustToHSMLbl.Text = "Home Screen Menu";
            this.CustToHSMLbl.Click += new System.EventHandler(this.CustToHSMLbl_Click);
            // 
            // CustToLogInSLbl
            // 
            this.CustToLogInSLbl.AutoSize = true;
            this.CustToLogInSLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustToLogInSLbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CustToLogInSLbl.Location = new System.Drawing.Point(66, 382);
            this.CustToLogInSLbl.Name = "CustToLogInSLbl";
            this.CustToLogInSLbl.Size = new System.Drawing.Size(64, 19);
            this.CustToLogInSLbl.TabIndex = 11;
            this.CustToLogInSLbl.Text = "Log Out";
            this.CustToLogInSLbl.Click += new System.EventHandler(this.CustToLogInSLbl_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(988, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridData)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox SelectCustomerGender;
        private Label label4;
        private Panel panel3;
        private DateTimePicker CustomerDateJoined;
        private Label label10;
        private Button CustDeleteButton;
        private Button CustEditButton;
        private Button CustSaveButton;
        private TextBox EnterCustomerPhoneNumberTb;
        private TextBox EnterCustomerAddressTb;
        private TextBox EnterCustomerNameTb;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label CustLblS;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label CustToEmpLbl;
        private Label CustToManufactLbl;
        private Label CustToInvLbl;
        private Panel panel1;
        private Label CustToLogInSLbl;
        private DataGridView CustomerGridData;
        private Label CustToHSMLbl;
    }
}