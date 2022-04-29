/*
  
Project name: Parts n' Tools Software

Group members: Jesus Nunez
               Austin Harmon
               Dalila Sanchez
               Andy Arce
               Ebsa Tufa

Special thanks to "MyCodeSpace" video for the guidance of this project.

                                Code/Algorithm Citation
/***************************************************************************************
*    Title: Pharmacy Management System C#.Net and SQL Server
*    Author: MyCodeSpace
*    Date: August, 27, 2021
*    Code version: Version 2.0
*    Availability: https://www.youtube.com/watch?v=ogS0SfW1pm0
*
***************************************************************************************/


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
            ShowInventory();//Displays inventory in InventoryGridData_CellContentClick
            ShowEmployeeName();//Showing employee name in the transaction grid
            EmployeeNameLabel.Text = UserLogin.UserName; //Displays employee name on the top right of the transactions window
            SelectCustomerNumber(); //Selecting customer number
        }
        SqlConnection Transactions_Connetion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");//Finding to database location

        //Jesus Nunez
        private void SelectCustomerNumber() //Function allows user to select customer number
        {
            Transactions_Connetion.Open();//Open connection
            SqlCommand command = new SqlCommand("Select CustNumber from CustomerTableData", Transactions_Connetion);//Command to select "CustNumber" from "CustomerTableData"
            SqlDataReader Customer_DataReader;//Read only info

            Customer_DataReader = command.ExecuteReader();//Getting records from database

            DataTable Customer_DataTable = new DataTable();//"Customer_DataTable" variable assign to new DataTable to add specific data.
            Customer_DataTable.Columns.Add("CustNumber", typeof(int));//Adding "CustNumber" from the columns database table "CustomerTableData"
            Customer_DataTable.Load(Customer_DataReader);//Load data to Customer_DataReader
            CustomerNumberCb.ValueMember = "CustNumber";//Getting "CustNumber" from CustomerTableData and assigning it to "CustomerNumberCb" 
            CustomerNumberCb.DataSource = Customer_DataTable;//Storing data to the "CustomerNumberCb" combo box from Customer_DataTable
            Transactions_Connetion.Close();//Close connection
        }
        //Jesus Nunez
        private void GetCustomerName()
        {
            Transactions_Connetion.Open();//Open connection
            string Customer_Query = "Select * from CustomerTableData where CustNumber = '" + CustomerNumberCb.SelectedValue.ToString() + "'";//Assigning "Customer_Query" to select "CustNumber" from the SQL database in "CustomerTableData".
            SqlCommand command = new SqlCommand(Customer_Query, Transactions_Connetion);//Using the data adapter to retrieve data from Customer_Query
            DataTable Customer_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
            SqlDataAdapter Customer_DataAdapter = new SqlDataAdapter(command);//Filling the Customer_DataTable 
            Customer_DataAdapter.Fill(Customer_DataTable);//Filling the Customer_DataTable 

            foreach (DataRow Cust_DataRow in Customer_DataTable.Rows)//Iterating data rows to display "CustName"  in "CustomerNameTb" textbox 
            {
                CustomerNameTb.Text = Cust_DataRow["CustName"].ToString();
            }
            Transactions_Connetion.Close();//Close connection
        }
        //Jesus Nunez
        private void UpdateQuantity()
        {
            try
            {
                int NewQuantity = ItemStock - Convert.ToInt32(ItemQuantityTb.Text); //Subtracts Item stock from the quantity of items purchased
                Transactions_Connetion.Open();//Open connection
                SqlCommand command = new SqlCommand("Update InventoryTableData set ItemQuantity=@InvQty where ItemNumber=@ItemKey", Transactions_Connetion);
                //Adding parameters to specific cells in the Transactions interface "Inventory" Grid.
                command.Parameters.AddWithValue("@InvQty", NewQuantity);
                command.Parameters.AddWithValue("@ItemKey", Item_Key);

                command.ExecuteNonQuery(); //Executes the Update command
                MessageBox.Show("Item Updated");
                Transactions_Connetion.Close();//Close connection
                ShowInventory();
            }
            catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
            {
                MessageBox.Show(exception.Message);//Displays message and software crashes.
            }     
        }
        //Jesus Nunez
        private void AddTransactionBill() //When user adds transaction to bill
        {
            if (CustomerNameTb.Text == "") //This is to prevent empty customer to be displayed as the best customer
            {
            }
            else
            {
                try //If the admin fills in every information from the text boxes on the if statement, then data will try be inserted into the "Bill" grid and will also cactch and display exceptions if something goes wrong
                {
                    Transactions_Connetion.Open();
                    SqlCommand command = new SqlCommand("insert into TransactionTableData(EmployeeName,CustNumber, CustName, TransactionDate, TransactionAmount)values(@EmpName,@CustNum,@Cust_Name,@TransDate,@TransAmount)", Transactions_Connetion);//Inserting data to grid from database using the value parameters

                    //Adding parameters to specific textboxes in the inventory interface.
                    command.Parameters.AddWithValue("@EmpName", EmployeeNameLabel.Text);
                    command.Parameters.AddWithValue("@CustNum", CustomerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@Cust_Name", CustomerNameTb.Text);
                    command.Parameters.AddWithValue("@TransDate", DateTime.Today.Date);
                    command.Parameters.AddWithValue("@TransAmount", GrandTotal);
                    command.ExecuteNonQuery();//Executes the insert command
                    MessageBox.Show("Transaction Saved");//Notifies the admin that a Transaction was added
                    Transactions_Connetion.Close();//Closing connection
                    ShowEmployeeName(); //Displays employee name in "TransactionTableData"
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
                {
                    MessageBox.Show(exception.Message);//Displays message and software crashes.
                }
            }
        }

        //Jesus Nunez
        private void ShowEmployeeName() //Showing employee name in the transaction grid
        {
            Transactions_Connetion.Open();//Open connection
            string Bill_Query = "Select * from TransactionTableData where EmployeeName='" + EmployeeNameLabel.Text + "'";//Assigning Bill_Query to select data from EmployeeName in TransactionTableData  
            SqlDataAdapter Bill_DataAdapter = new SqlDataAdapter(Bill_Query, Transactions_Connetion); //Using the data adapter to retrieve data from Bill_Query
            SqlCommandBuilder Bill_Builder = new SqlCommandBuilder(Bill_DataAdapter);//Generating SQL commands to Bill_DataAdapter
            var Bill_DataSet = new DataSet(); //Assigning to a new Datset to store data.
            Bill_DataAdapter.Fill(Bill_DataSet);//Filling the Bill_DataSet
            TransactionGridData.DataSource = Bill_DataSet.Tables[0];//Populating Bill_DataSet.Tables[0]
            Transactions_Connetion.Close();//Close connection
        }

        //Jesus Nunez
        private void ShowInventory() //Displays inventory in InventoryGridData_CellContentClick
        {
            Transactions_Connetion.Open();//Open connection
            string Inventory_Query = "Select * from InventoryTableData";//Assigning Inventory_Query to select data from InventoryTableData  
            SqlDataAdapter Inventory_DataAdapter = new SqlDataAdapter(Inventory_Query, Transactions_Connetion);//Assigning new data from Inventory_DataAdapter to retrieve new data.
            SqlCommandBuilder Inventory_Builder = new SqlCommandBuilder(Inventory_DataAdapter);//Generating SQL commands to Inventory_DataAdapter
            var Inventory_DataSet = new DataSet();//Assigning to a new Datset to store data.
            Inventory_DataAdapter.Fill(Inventory_DataSet);//Filling the Inventory_DataSet
            InventoryGridData.DataSource = Inventory_DataSet.Tables[0];//Populating Inventory_DataSet.Tables[0]
            Transactions_Connetion.Close();//Close connection
        }

        
        decimal GrandTotal = 0, n = 0;


        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //Jesus Nunez
        private void PrintBillButton_Click(object sender, EventArgs e) //Prints receipt
        {
            AddTransactionBill(); //Gets the added transaction data
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600); //Printing setting
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) //Prints document
            {
                printDocument1.Print();
            }


        }
        private void AddBillButton_Click(object sender, EventArgs e) 
        {
            if (ItemQuantityTb.Text == "" || Convert.ToDecimal(ItemQuantityTb.Text) > ItemStock) //This is to prevent out of stock items
            {
                MessageBox.Show("Enter Correct Quantity"); //Will display if the quantity amount is greater than the stock
            }
            else //This will add item to the bill grid
            {
                decimal total = Convert.ToDecimal(ItemQuantityTb.Text) * Convert.ToDecimal(ItemPriceTb.Text); //Multiplies stock by the item price
                DataGridViewRow NewRow = new DataGridViewRow(); // Adding new data
                NewRow.CreateCells(BillGridData); //Creating cells in the "BillGridData"
                NewRow.Cells[0].Value = n + 1; //Transaction number in cell 0
                NewRow.Cells[1].Value = ItemNameTb.Text; //Item name is assigned to cell 1
                NewRow.Cells[2].Value = ItemQuantityTb.Text; //Item quantity is assign in cell 2
                NewRow.Cells[3].Value = ItemPriceTb.Text; //Item price is assign in cell 3
                NewRow.Cells[4].Value = total; //Caculates the quantity * price in cell 4
                BillGridData.Rows.Add(NewRow); //Adding new rows
                GrandTotal = GrandTotal + total;//Adds up the total amount of items added from bill grid
                GrandTotalLabel.Text = "$" + GrandTotal; //Displays "$" along with the grand total purchase and displays it in a lavel
                n++; //iterates a new row
                UpdateQuantity(); //Updates stock
            }
        }
        int Item_Key = 0, ItemStock;
        int ItemNum;
        decimal ItemQty, InvTotal, ItemPrice;
        //Jesus Nunez
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //More printing settings Word fonts and positions
        {
            e.Graphics.DrawString("Parts n' Tools", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80)); 
            e.Graphics.DrawString("ID         Item             Price       QTY       TOTAL", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillGridData.Rows) //Collecting data from BillGridData rows
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
        //Jesus Nunez
        private void TLogOutLbl_Click(object sender, EventArgs e)//When admin clicks on "Logout" label on the botton left side of the screen, the window will switch to "UserLogin" window.
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void CustomerNumberCb_SelectionChangeCommitted(object sender, EventArgs e) //Displays customer name when selecting customer number
        {
            GetCustomerName();
        }
        
        int position = 60;
        string PartName;       
        private void Transactions_Load(object sender, EventArgs e)
        {

        }

        //Jesus Nunez
        private void InventoryGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)//Displaying inventory data in the inventroy grid
        {
            ItemNameTb.Text = InventoryGridData.SelectedRows[0].Cells[1].Value.ToString();
            ItemStock = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[3].Value.ToString());
            ItemPriceTb.Text = InventoryGridData.SelectedRows[0].Cells[4].Value.ToString();

            if (ItemNameTb.Text == "") //Item name will remain 0 if it is left empty
            {
                Item_Key = 0;
            }
            else //It will collect data and display it as a row in the inventory grid
            {
                Item_Key = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

    }
}
