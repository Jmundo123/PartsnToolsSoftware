using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PartsnToolsSoftware
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            ShowInventory();
            ShowEmployeeName();
            EmployeeNameLabel.Text = UserLogin.UserName;
            SelectCustomerNumber();
        }
        SqlConnection Transactions_Connetion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");

        private void SelectCustomerNumber()
        {
            Transactions_Connetion.Open();
            SqlCommand command = new SqlCommand("Select CustNumber from CustomerTableData", Transactions_Connetion);
            SqlDataReader Customer_DataReader;

            Customer_DataReader = command.ExecuteReader();

            DataTable Customer_DataTable = new DataTable();
            Customer_DataTable.Columns.Add("CustNumber", typeof(int));
            Customer_DataTable.Load(Customer_DataReader);
            CustomerNumberCb.ValueMember = "CustNumber";
            CustomerNumberCb.DataSource = Customer_DataTable;
            Transactions_Connetion.Close();
        }
        private void GetCustomerName()
        {
            Transactions_Connetion.Open();
            string Customer_Query = "Select * from CustomerTableData where CustNumber = '" + CustomerNumberCb.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(Customer_Query, Transactions_Connetion);
            DataTable Customer_DataTable = new DataTable();
            SqlDataAdapter Customer_DataAdapter = new SqlDataAdapter(command);
            Customer_DataAdapter.Fill(Customer_DataTable);

            foreach (DataRow Cust_DataRow in Customer_DataTable.Rows)
            {
                CustomerNameTb.Text = Cust_DataRow["CustName"].ToString();
            }
            Transactions_Connetion.Close();
        }

        private void UpdateQuantity()
        {
            try
            {
                int NewQuantity = ItemStock - Convert.ToInt32(ItemQuantityTb.Text);
                Transactions_Connetion.Open();
                SqlCommand command = new SqlCommand("Update InventoryTableData set ItemQuantity=@InvQty where ItemNumber=@ItemKey", Transactions_Connetion);

                command.Parameters.AddWithValue("@InvQty", NewQuantity);
                command.Parameters.AddWithValue("@ItemKey", Item_Key);

                command.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                Transactions_Connetion.Close();
                ShowInventory();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }     
        }

        private void AddTransactionBill()
        {
            if (CustomerNameTb.Text == "")
            { 
            
            }
            else
            {
                try
                {
                    Transactions_Connetion.Open();
                    SqlCommand command = new SqlCommand("insert into TransactionTableData(EmployeeName,CustNumber, CustName, TransactionDate, TransactionAmount)values(@EmpName,@CustNum,@Cust_Name,@TransDate,@TransAmount)", Transactions_Connetion);

                    command.Parameters.AddWithValue("@EmpName", EmployeeNameLabel.Text);
                    command.Parameters.AddWithValue("@CustNum", CustomerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@Cust_Name", CustomerNameTb.Text);
                    command.Parameters.AddWithValue("@TransDate", DateTime.Today.Date);
                    command.Parameters.AddWithValue("@TransAmount", GrandTotal);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction Saved");
                    Transactions_Connetion.Close();
                    ShowEmployeeName();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }


        private void ShowEmployeeName()
        {
            Transactions_Connetion.Open();
            string Bill_Query = "Select * from TransactionTableData where EmployeeName='" + EmployeeNameLabel.Text + "'";
            SqlDataAdapter Bill_DataAdapter = new SqlDataAdapter(Bill_Query, Transactions_Connetion);
            SqlCommandBuilder Bill_Builder = new SqlCommandBuilder(Bill_DataAdapter);
            var Bill_DataSet = new DataSet();
            Bill_DataAdapter.Fill(Bill_DataSet);
            TransactionGridData.DataSource = Bill_DataSet.Tables[0];
            Transactions_Connetion.Close();
        }


        private void ShowInventory()
        {
            Transactions_Connetion.Open();
            string Inventory_Query = "Select * from InventoryTableData";
            SqlDataAdapter Inventory_DataAdapter = new SqlDataAdapter(Inventory_Query, Transactions_Connetion);
            SqlCommandBuilder Inventory_Builder = new SqlCommandBuilder(Inventory_DataAdapter);
            var Inventory_DataSet = new DataSet();
            Inventory_DataAdapter.Fill(Inventory_DataSet);
            InventoryGridData.DataSource = Inventory_DataSet.Tables[0];
            Transactions_Connetion.Close();
        }

        
        decimal GrandTotal = 0, n = 0;


        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void PrintBillButton_Click(object sender, EventArgs e)
        {
            AddTransactionBill();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
        private void AddBillButton_Click(object sender, EventArgs e)
        {
            if (ItemQuantityTb.Text == "" || Convert.ToDecimal(ItemQuantityTb.Text) > ItemStock)
            {
                MessageBox.Show("Enter Correct Quantity");
            }
            else
            {
                decimal total = Convert.ToDecimal(ItemQuantityTb.Text) * Convert.ToDecimal(ItemPriceTb.Text); //decimal
                DataGridViewRow NewRow = new DataGridViewRow();
                NewRow.CreateCells(BillGridData);
                NewRow.Cells[0].Value = n + 1;
                NewRow.Cells[1].Value = ItemNameTb.Text;
                NewRow.Cells[2].Value = ItemQuantityTb.Text;
                NewRow.Cells[3].Value = ItemPriceTb.Text;
                NewRow.Cells[4].Value = total;
                BillGridData.Rows.Add(NewRow);
                GrandTotal = GrandTotal + total;
                GrandTotalLabel.Text = "$" + GrandTotal;
                n++;
                UpdateQuantity();
            }
        }
        int Item_Key = 0, ItemStock;
        int ItemNum;
        decimal ItemQty, InvTotal, ItemPrice;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Parts n' Tools", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID         Item             Price       QTY       TOTAL", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillGridData.Rows)
            {
                ItemNum = Convert.ToInt32(row.Cells["Column1"].Value);
                PartName = "" + row.Cells["Column2"].Value;
                ItemPrice = Convert.ToDecimal(row.Cells["Column3"].Value);
                ItemQty = Convert.ToDecimal(row.Cells["Column4"].Value); 
                InvTotal = Convert.ToDecimal(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + ItemNum, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, position));
                e.Graphics.DrawString("" + PartName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, position));
                e.Graphics.DrawString("   $" + "" + ItemQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, position));
                e.Graphics.DrawString("  " + ItemPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, position));
                e.Graphics.DrawString("" + InvTotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, position));
                position = position + 20;

            }
            e.Graphics.DrawString("Grand Total: $" + GrandTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(50, position + 50));
            e.Graphics.DrawString("      **********Parts n' Tools**********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, position + 85));
            BillGridData.Rows.Clear();
            BillGridData.Refresh();
            position = 100;
            GrandTotal = 0;
            n = 0;
        }

        private void TLogOutLbl_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }

        private void CustomerNumberCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustomerName();
        }
        
        int position = 60;
        string PartName;       
        private void Transactions_Load(object sender, EventArgs e)
        {

        }

        
        private void InventoryGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNameTb.Text = InventoryGridData.SelectedRows[0].Cells[1].Value.ToString();
            ItemStock = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[3].Value.ToString());
            ItemPriceTb.Text = InventoryGridData.SelectedRows[0].Cells[4].Value.ToString();

            if (ItemNameTb.Text == "")
            {
                Item_Key = 0;
            }
            else
            {
                Item_Key = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

    }
}
