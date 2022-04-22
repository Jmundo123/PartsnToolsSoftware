namespace PartsnToolsSoftware
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.TLogOutLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionsLblS = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TransactionGridData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerNameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BillGridData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.InventoryGridData = new System.Windows.Forms.DataGridView();
            this.PrintBillButton = new System.Windows.Forms.Button();
            this.AddBillButton = new System.Windows.Forms.Button();
            this.CustomerNumberCb = new System.Windows.Forms.ComboBox();
            this.ItemPriceTb = new System.Windows.Forms.TextBox();
            this.ItemQuantityTb = new System.Windows.Forms.TextBox();
            this.ItemNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CustNameLabl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridData)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLogOutLbl
            // 
            this.TLogOutLbl.AutoSize = true;
            this.TLogOutLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TLogOutLbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TLogOutLbl.Location = new System.Drawing.Point(75, 515);
            this.TLogOutLbl.Name = "TLogOutLbl";
            this.TLogOutLbl.Size = new System.Drawing.Size(81, 23);
            this.TLogOutLbl.TabIndex = 11;
            this.TLogOutLbl.Text = "Log Out";
            this.TLogOutLbl.Click += new System.EventHandler(this.TLogOutLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts n\' Tools";
            // 
            // TransactionsLblS
            // 
            this.TransactionsLblS.AutoSize = true;
            this.TransactionsLblS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransactionsLblS.Location = new System.Drawing.Point(18, 11);
            this.TransactionsLblS.Name = "TransactionsLblS";
            this.TransactionsLblS.Size = new System.Drawing.Size(117, 23);
            this.TransactionsLblS.TabIndex = 21;
            this.TransactionsLblS.Text = "Transactions";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrandTotalLabel.Location = new System.Drawing.Point(597, 243);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(56, 23);
            this.GrandTotalLabel.TabIndex = 33;
            this.GrandTotalLabel.Text = "BILL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(570, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Transactions";
            // 
            // TransactionGridData
            // 
            this.TransactionGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransactionGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionGridData.Location = new System.Drawing.Point(427, 292);
            this.TransactionGridData.Name = "TransactionGridData";
            this.TransactionGridData.RowHeadersWidth = 51;
            this.TransactionGridData.RowTemplate.Height = 29;
            this.TransactionGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionGridData.Size = new System.Drawing.Size(382, 163);
            this.TransactionGridData.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(597, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "BILL";
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.Enabled = false;
            this.CustomerNameTb.Location = new System.Drawing.Point(17, 135);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(154, 27);
            this.CustomerNameTb.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item Selected";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.TLogOutLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 592);
            this.panel1.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.TransactionsLblS);
            this.panel5.Location = new System.Drawing.Point(33, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 48);
            this.panel5.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BillGridData
            // 
            this.BillGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BillGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillGridData.Location = new System.Drawing.Point(427, 44);
            this.BillGridData.Name = "BillGridData";
            this.BillGridData.RowHeadersWidth = 51;
            this.BillGridData.RowTemplate.Height = 29;
            this.BillGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGridData.Size = new System.Drawing.Size(382, 163);
            this.BillGridData.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Items";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cost";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(99, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Inventory Stock";
            // 
            // InventoryGridData
            // 
            this.InventoryGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridData.Location = new System.Drawing.Point(17, 292);
            this.InventoryGridData.Name = "InventoryGridData";
            this.InventoryGridData.RowHeadersWidth = 51;
            this.InventoryGridData.RowTemplate.Height = 29;
            this.InventoryGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGridData.Size = new System.Drawing.Size(368, 163);
            this.InventoryGridData.TabIndex = 23;
            this.InventoryGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGridData_CellContentClick);
            // 
            // PrintBillButton
            // 
            this.PrintBillButton.Location = new System.Drawing.Point(688, 224);
            this.PrintBillButton.Name = "PrintBillButton";
            this.PrintBillButton.Size = new System.Drawing.Size(91, 33);
            this.PrintBillButton.TabIndex = 22;
            this.PrintBillButton.Text = "Print";
            this.PrintBillButton.UseVisualStyleBackColor = true;
            this.PrintBillButton.Click += new System.EventHandler(this.PrintBillButton_Click);
            // 
            // AddBillButton
            // 
            this.AddBillButton.Location = new System.Drawing.Point(118, 224);
            this.AddBillButton.Name = "AddBillButton";
            this.AddBillButton.Size = new System.Drawing.Size(91, 33);
            this.AddBillButton.TabIndex = 20;
            this.AddBillButton.Text = "Add to Bill";
            this.AddBillButton.UseVisualStyleBackColor = true;
            this.AddBillButton.Click += new System.EventHandler(this.AddBillButton_Click);
            // 
            // CustomerNumberCb
            // 
            this.CustomerNumberCb.FormattingEnabled = true;
            this.CustomerNumberCb.Items.AddRange(new object[] {
            "Parts",
            "Tools",
            "Other"});
            this.CustomerNumberCb.Location = new System.Drawing.Point(17, 76);
            this.CustomerNumberCb.Name = "CustomerNumberCb";
            this.CustomerNumberCb.Size = new System.Drawing.Size(146, 28);
            this.CustomerNumberCb.TabIndex = 18;
            this.CustomerNumberCb.SelectionChangeCommitted += new System.EventHandler(this.CustomerNumberCb_SelectionChangeCommitted);
            // 
            // ItemPriceTb
            // 
            this.ItemPriceTb.Enabled = false;
            this.ItemPriceTb.Location = new System.Drawing.Point(177, 133);
            this.ItemPriceTb.Name = "ItemPriceTb";
            this.ItemPriceTb.Size = new System.Drawing.Size(92, 27);
            this.ItemPriceTb.TabIndex = 16;
            // 
            // ItemQuantityTb
            // 
            this.ItemQuantityTb.Location = new System.Drawing.Point(177, 77);
            this.ItemQuantityTb.Name = "ItemQuantityTb";
            this.ItemQuantityTb.Size = new System.Drawing.Size(92, 27);
            this.ItemQuantityTb.TabIndex = 15;
            // 
            // ItemNameTb
            // 
            this.ItemNameTb.Enabled = false;
            this.ItemNameTb.Location = new System.Drawing.Point(17, 191);
            this.ItemNameTb.Name = "ItemNameTb";
            this.ItemNameTb.Size = new System.Drawing.Size(155, 27);
            this.ItemNameTb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(195, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(174, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Invetory Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.CustNameLabl);
            this.panel3.Controls.Add(this.GrandTotalLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.TransactionGridData);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CustomerNameTb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.BillGridData);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.InventoryGridData);
            this.panel3.Controls.Add(this.PrintBillButton);
            this.panel3.Controls.Add(this.AddBillButton);
            this.panel3.Controls.Add(this.CustomerNumberCb);
            this.panel3.Controls.Add(this.ItemPriceTb);
            this.panel3.Controls.Add(this.ItemQuantityTb);
            this.panel3.Controls.Add(this.ItemNameTb);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(234, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 471);
            this.panel3.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(569, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Transactions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNameLabel.Location = new System.Drawing.Point(922, 44);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(54, 23);
            this.EmployeeNameLabel.TabIndex = 27;
            this.EmployeeNameLabel.Text = "Sales";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // CustNameLabl
            // 
            this.CustNameLabl.AutoSize = true;
            this.CustNameLabl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustNameLabl.Location = new System.Drawing.Point(17, 107);
            this.CustNameLabl.Name = "CustNameLabl";
            this.CustNameLabl.Size = new System.Drawing.Size(146, 23);
            this.CustNameLabl.TabIndex = 34;
            this.CustNameLabl.Text = "Customer Name";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1133, 589);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TLogOutLbl;
        private Label label1;
        private Label TransactionsLblS;
        private Label GrandTotalLabel;
        private Label label9;
        private DataGridView TransactionGridData;
        private Label label4;
        private TextBox CustomerNameTb;
        private Label label7;
        private Panel panel1;
        private Panel panel5;
        private PictureBox pictureBox1;
        private DataGridView BillGridData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label10;
        private DataGridView InventoryGridData;
        private Button PrintBillButton;
        private Button AddBillButton;
        private ComboBox CustomerNumberCb;
        private TextBox ItemPriceTb;
        private TextBox ItemQuantityTb;
        private TextBox ItemNameTb;
        private Label label6;
        private Label label5;
        private Label label8;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label EmployeeNameLabel;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label CustNameLabl;
    }
}