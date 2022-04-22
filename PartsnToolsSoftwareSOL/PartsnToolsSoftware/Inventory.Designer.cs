namespace PartsnToolsSoftware
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.InvtoEmpLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InventoryLblS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvtoLoginScreenLbl = new System.Windows.Forms.Label();
            this.InvtoManufactLabel = new System.Windows.Forms.Label();
            this.InvtoCustLabel = new System.Windows.Forms.Label();
            this.InvtoHomeScreenMenuLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EnterItemNameTb = new System.Windows.Forms.TextBox();
            this.EnterItemQuantityTb = new System.Windows.Forms.TextBox();
            this.EnterItemPriceTb = new System.Windows.Forms.TextBox();
            this.DisplayManufacturerNameTb = new System.Windows.Forms.TextBox();
            this.EnterItemTypeCb = new System.Windows.Forms.ComboBox();
            this.ItemManufacturerNumberCb = new System.Windows.Forms.ComboBox();
            this.InventorySaveButton = new System.Windows.Forms.Button();
            this.InventoryEditButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.InventoryGridData = new System.Windows.Forms.DataGridView();
            this.InventoryDeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // InvtoEmpLabel
            // 
            this.InvtoEmpLabel.AutoSize = true;
            this.InvtoEmpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvtoEmpLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvtoEmpLabel.Location = new System.Drawing.Point(54, 312);
            this.InvtoEmpLabel.Name = "InvtoEmpLabel";
            this.InvtoEmpLabel.Size = new System.Drawing.Size(82, 19);
            this.InvtoEmpLabel.TabIndex = 10;
            this.InvtoEmpLabel.Text = "Employees";
            this.InvtoEmpLabel.Click += new System.EventHandler(this.InvtoEmpLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.InventoryLblS);
            this.panel5.Location = new System.Drawing.Point(36, 193);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 30);
            this.panel5.TabIndex = 20;
            // 
            // InventoryLblS
            // 
            this.InventoryLblS.AutoSize = true;
            this.InventoryLblS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InventoryLblS.Location = new System.Drawing.Point(26, 5);
            this.InventoryLblS.Name = "InventoryLblS";
            this.InventoryLblS.Size = new System.Drawing.Size(74, 19);
            this.InventoryLblS.TabIndex = 21;
            this.InventoryLblS.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.InvtoLoginScreenLbl);
            this.panel1.Controls.Add(this.InvtoEmpLabel);
            this.panel1.Controls.Add(this.InvtoManufactLabel);
            this.panel1.Controls.Add(this.InvtoCustLabel);
            this.panel1.Controls.Add(this.InvtoHomeScreenMenuLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 444);
            this.panel1.TabIndex = 21;
            // 
            // InvtoLoginScreenLbl
            // 
            this.InvtoLoginScreenLbl.AutoSize = true;
            this.InvtoLoginScreenLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvtoLoginScreenLbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.InvtoLoginScreenLbl.Location = new System.Drawing.Point(61, 380);
            this.InvtoLoginScreenLbl.Name = "InvtoLoginScreenLbl";
            this.InvtoLoginScreenLbl.Size = new System.Drawing.Size(64, 19);
            this.InvtoLoginScreenLbl.TabIndex = 11;
            this.InvtoLoginScreenLbl.Text = "Log Out";
            this.InvtoLoginScreenLbl.Click += new System.EventHandler(this.InvtoLoginScreenLbl_Click);
            // 
            // InvtoManufactLabel
            // 
            this.InvtoManufactLabel.AutoSize = true;
            this.InvtoManufactLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvtoManufactLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvtoManufactLabel.Location = new System.Drawing.Point(44, 273);
            this.InvtoManufactLabel.Name = "InvtoManufactLabel";
            this.InvtoManufactLabel.Size = new System.Drawing.Size(109, 19);
            this.InvtoManufactLabel.TabIndex = 9;
            this.InvtoManufactLabel.Text = "Manufacturers";
            this.InvtoManufactLabel.Click += new System.EventHandler(this.InvtoManufactLabel_Click);
            // 
            // InvtoCustLabel
            // 
            this.InvtoCustLabel.AutoSize = true;
            this.InvtoCustLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvtoCustLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvtoCustLabel.Location = new System.Drawing.Point(56, 238);
            this.InvtoCustLabel.Name = "InvtoCustLabel";
            this.InvtoCustLabel.Size = new System.Drawing.Size(81, 19);
            this.InvtoCustLabel.TabIndex = 8;
            this.InvtoCustLabel.Text = "Customers";
            this.InvtoCustLabel.Click += new System.EventHandler(this.InvtoCustLabel_Click);
            // 
            // InvtoHomeScreenMenuLbl
            // 
            this.InvtoHomeScreenMenuLbl.AutoSize = true;
            this.InvtoHomeScreenMenuLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvtoHomeScreenMenuLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvtoHomeScreenMenuLbl.Location = new System.Drawing.Point(28, 163);
            this.InvtoHomeScreenMenuLbl.Name = "InvtoHomeScreenMenuLbl";
            this.InvtoHomeScreenMenuLbl.Size = new System.Drawing.Size(143, 19);
            this.InvtoHomeScreenMenuLbl.TabIndex = 7;
            this.InvtoHomeScreenMenuLbl.Text = "Home Screen Menu";
            this.InvtoHomeScreenMenuLbl.Click += new System.EventHandler(this.InvtoHomeScreenMenuLbl_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(14, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Invetory Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(153, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(241, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(352, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(430, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Manufacture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(563, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Manufacture Name";
            // 
            // EnterItemNameTb
            // 
            this.EnterItemNameTb.Location = new System.Drawing.Point(10, 56);
            this.EnterItemNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterItemNameTb.Name = "EnterItemNameTb";
            this.EnterItemNameTb.Size = new System.Drawing.Size(132, 23);
            this.EnterItemNameTb.TabIndex = 14;
            this.EnterItemNameTb.TextChanged += new System.EventHandler(this.PartNameTB_TextChanged);
            // 
            // EnterItemQuantityTb
            // 
            this.EnterItemQuantityTb.Location = new System.Drawing.Point(239, 56);
            this.EnterItemQuantityTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterItemQuantityTb.Name = "EnterItemQuantityTb";
            this.EnterItemQuantityTb.Size = new System.Drawing.Size(81, 23);
            this.EnterItemQuantityTb.TabIndex = 15;
            // 
            // EnterItemPriceTb
            // 
            this.EnterItemPriceTb.Location = new System.Drawing.Point(336, 55);
            this.EnterItemPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterItemPriceTb.Name = "EnterItemPriceTb";
            this.EnterItemPriceTb.Size = new System.Drawing.Size(81, 23);
            this.EnterItemPriceTb.TabIndex = 16;
            // 
            // DisplayManufacturerNameTb
            // 
            this.DisplayManufacturerNameTb.Enabled = false;
            this.DisplayManufacturerNameTb.Location = new System.Drawing.Point(563, 56);
            this.DisplayManufacturerNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayManufacturerNameTb.Name = "DisplayManufacturerNameTb";
            this.DisplayManufacturerNameTb.Size = new System.Drawing.Size(152, 23);
            this.DisplayManufacturerNameTb.TabIndex = 17;
            this.DisplayManufacturerNameTb.TextChanged += new System.EventHandler(this.DisplayManufacturerNameTb_TextChanged);
            // 
            // EnterItemTypeCb
            // 
            this.EnterItemTypeCb.FormattingEnabled = true;
            this.EnterItemTypeCb.Items.AddRange(new object[] {
            "Parts",
            "Tools",
            "Other"});
            this.EnterItemTypeCb.Location = new System.Drawing.Point(153, 56);
            this.EnterItemTypeCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterItemTypeCb.Name = "EnterItemTypeCb";
            this.EnterItemTypeCb.Size = new System.Drawing.Size(73, 23);
            this.EnterItemTypeCb.TabIndex = 18;
            // 
            // ItemManufacturerNumberCb
            // 
            this.ItemManufacturerNumberCb.FormattingEnabled = true;
            this.ItemManufacturerNumberCb.Location = new System.Drawing.Point(430, 55);
            this.ItemManufacturerNumberCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemManufacturerNumberCb.Name = "ItemManufacturerNumberCb";
            this.ItemManufacturerNumberCb.Size = new System.Drawing.Size(119, 23);
            this.ItemManufacturerNumberCb.TabIndex = 19;
            this.ItemManufacturerNumberCb.SelectedIndexChanged += new System.EventHandler(this.ItemManufacturerNumberCb_SelectedIndexChanged);
            this.ItemManufacturerNumberCb.SelectionChangeCommitted += new System.EventHandler(this.ItemManufacturerNumberCb_SelectionChangeCommitted);
            // 
            // InventorySaveButton
            // 
            this.InventorySaveButton.Location = new System.Drawing.Point(204, 81);
            this.InventorySaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventorySaveButton.Name = "InventorySaveButton";
            this.InventorySaveButton.Size = new System.Drawing.Size(80, 25);
            this.InventorySaveButton.TabIndex = 20;
            this.InventorySaveButton.Text = "Save";
            this.InventorySaveButton.UseVisualStyleBackColor = true;
            this.InventorySaveButton.Click += new System.EventHandler(this.InventorySaveButton_Click);
            // 
            // InventoryEditButton
            // 
            this.InventoryEditButton.Location = new System.Drawing.Point(304, 81);
            this.InventoryEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryEditButton.Name = "InventoryEditButton";
            this.InventoryEditButton.Size = new System.Drawing.Size(80, 25);
            this.InventoryEditButton.TabIndex = 21;
            this.InventoryEditButton.Text = "Edit";
            this.InventoryEditButton.UseVisualStyleBackColor = true;
            this.InventoryEditButton.Click += new System.EventHandler(this.InventoryEditButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.InventoryGridData);
            this.panel3.Controls.Add(this.InventoryDeleteButton);
            this.panel3.Controls.Add(this.InventoryEditButton);
            this.panel3.Controls.Add(this.InventorySaveButton);
            this.panel3.Controls.Add(this.ItemManufacturerNumberCb);
            this.panel3.Controls.Add(this.EnterItemTypeCb);
            this.panel3.Controls.Add(this.DisplayManufacturerNameTb);
            this.panel3.Controls.Add(this.EnterItemPriceTb);
            this.panel3.Controls.Add(this.EnterItemQuantityTb);
            this.panel3.Controls.Add(this.EnterItemNameTb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(204, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 353);
            this.panel3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(305, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Inventory Stock";
            // 
            // InventoryGridData
            // 
            this.InventoryGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridData.Location = new System.Drawing.Point(11, 138);
            this.InventoryGridData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryGridData.Name = "InventoryGridData";
            this.InventoryGridData.RowHeadersWidth = 51;
            this.InventoryGridData.RowTemplate.Height = 29;
            this.InventoryGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGridData.Size = new System.Drawing.Size(742, 206);
            this.InventoryGridData.TabIndex = 23;
            this.InventoryGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryGridData_CellContentClick);
            // 
            // InventoryDeleteButton
            // 
            this.InventoryDeleteButton.Location = new System.Drawing.Point(414, 80);
            this.InventoryDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryDeleteButton.Name = "InventoryDeleteButton";
            this.InventoryDeleteButton.Size = new System.Drawing.Size(80, 25);
            this.InventoryDeleteButton.TabIndex = 22;
            this.InventoryDeleteButton.Text = "Delete";
            this.InventoryDeleteButton.UseVisualStyleBackColor = true;
            this.InventoryDeleteButton.Click += new System.EventHandler(this.InventoryDeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Inventory";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1001, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InvtoEmpLabel;
        private Panel panel5;
        private Label InventoryLblS;
        private Panel panel1;
        private Label InvtoLoginScreenLbl;
        private Label InvtoManufactLabel;
        private Label InvtoCustLabel;
        private Label InvtoHomeScreenMenuLbl;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox EnterItemNameTb;
        private TextBox EnterItemQuantityTb;
        private TextBox EnterItemPriceTb;
        private TextBox DisplayManufacturerNameTb;
        private ComboBox EnterItemTypeCb;
        private ComboBox ItemManufacturerNumberCb;
        private Button InventorySaveButton;
        private Button InventoryEditButton;
        private Panel panel3;
        private Label label10;
        private DataGridView InventoryGridData;
        private Button InventoryDeleteButton;
        private Label label2;
    }
}