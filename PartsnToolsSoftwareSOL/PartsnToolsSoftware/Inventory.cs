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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            ShowInventory();
            GetManufacturer();
        }//Jesus Nunez
        SqlConnection InventoryData_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30"); //Finding to database location
        //Jesus Nunez
        private void ShowInventory() // This function displays customer data on "Inventory List" Grid in the interface from the database
        {
            InventoryData_Connection.Open(); //Opening connection to database.
            string Inventory_Query = "Select * from InventoryTableData"; //Collecting string Data from the Database..
            SqlDataAdapter InvSDataAdapter = new SqlDataAdapter(Inventory_Query, InventoryData_Connection); //Assigning new data from Inventory_Query to retrieve new data.
            SqlCommandBuilder Inv_Builder = new SqlCommandBuilder(InvSDataAdapter);//Generating SQL commands to InvSDataAdapter
            var Inv_DataSet = new DataSet();//Assigning to a new Datset to store data.
            InvSDataAdapter.Fill(Inv_DataSet);//Filling the Inv_DataSet
            InventoryGridData.DataSource = Inv_DataSet.Tables[0];//Populating Inv_DataSet.Tables[0]
            InventoryData_Connection.Close();  //Closing connection to database

        }
        //Jesus Nunez
        private void Reset_Inventory_Input_Info()//This function resets data from the inventory interface after a user's action.
        {
            EnterItemNameTb.Text = "";
            EnterItemQuantityTb.Text = "";
            EnterItemPriceTb.Text = "";
            DisplayManufacturerNameTb.Text = "";
            EnterItemTypeCb.SelectedIndex = 0;
            InvKey = 0;



        }
        //Jesus Nunez
        private void GetManufacturer() //Function gets data from Manufacturer.cs window
        {
            InventoryData_Connection.Open();//Opening connection to database.
            SqlCommand command = new SqlCommand("Select ManufacturerNumber from ManufacturerTableData", InventoryData_Connection); //Selecting data "ManufacturerNumber" from "ManufacturerTableData" in the database
            SqlDataReader sDataReader; //Read only info
            sDataReader = command.ExecuteReader(); //Getting records from database
            DataTable InvTableData = new DataTable();//"InvTableData" variable assign to new Datatable to add specific data.
            InvTableData.Columns.Add("ManufacturerNumber", typeof(int));//Adding "ManufacturerNumber" from the columns database table "ManufacturerTableData"
            InvTableData.Load(sDataReader);//Load data to Employee_DataReader
            ItemManufacturerNumberCb.ValueMember = "ManufacturerNumber";//Getting "ManufacturerNumber" from ManufacturerTableData and assigning it to "ItemManufacturerNumberCb"
            ItemManufacturerNumberCb.DataSource = InvTableData;//Storing data to the "ItemManufacturerNumberCb" combo box from InvTableData
            InventoryData_Connection.Close(); //Closing connection to database
        }
        //Jesus Nunez
        private void GetManufacturerName()
        {
            InventoryData_Connection.Open();//Opening connection to database
            string Inventory_Query = "Select * from ManufacturerTableData where ManufacturerNumber= '" + ItemManufacturerNumberCb.SelectedValue.ToString() + "'";//Assigning Inventory_Query to select all data with the inclusion of the selected value from "ItemManufacturerNumberCb" combo box
            SqlCommand command = new SqlCommand(Inventory_Query, InventoryData_Connection); //Getting data from Inventory_Query
            DataTable InvTableData = new DataTable();//"InvTableData" variable assign to new DataTable to add specific data.
            SqlDataAdapter InvSDataAdapter = new SqlDataAdapter(command); //Using data adapter to retrieve data from Inventory_Query
            InvSDataAdapter.Fill(InvTableData);// Filling InvTableData
            foreach (DataRow InvDataRow in InvTableData.Rows) //Iterating data rows to display "ManufacturerName"  in "DisplayManufacturerNameTb" textbox
            {
                DisplayManufacturerNameTb.Text = InvDataRow["ManufacturerName"].ToString();
            }
            InventoryData_Connection.Close();//Closing connection to database
        }

        private void PartNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayManufacturerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void ItemManufacturerNumberCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Jesus Nunez
        private void InventorySaveButton_Click(object sender, EventArgs e)
        {
            if (EnterItemNameTb.Text == "" || EnterItemQuantityTb.Text == "" || EnterItemPriceTb.Text == "" || EnterItemTypeCb.SelectedIndex == -1 || ItemManufacturerNumberCb.Text == "")//If admin does not input any data then a message box will notify
            {                                                                                                                                                                             //the admin that there is missing information.                                             
                MessageBox.Show("Missing Information");
            }
            else//If the admin fills in every information from the text boxes on the if statement, then data will try be inserted into the "Inventory List" grid and will also cactch exceptions if something goes wrong
            {
                try
                {
                    InventoryData_Connection.Open();//Open connection
                    SqlCommand command = new SqlCommand("insert into InventoryTableData(ItemName, ItemType, ItemQuantity, ItemPrice, ItemManufacturerNumber, ItemManufacturerName)values(@Item_Name, @Item_Type, @ItemQty, @Item_Price, @ItemManNum, @ItemManName)", InventoryData_Connection);//Inserting data to grid from database using the value parameters

                    //Adding parameters to specific textboxes in the inventory interface.
                    command.Parameters.AddWithValue("@Item_Name", EnterItemNameTb.Text);
                    command.Parameters.AddWithValue("@Item_Type", EnterItemTypeCb.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ItemQty", EnterItemQuantityTb.Text);
                    command.Parameters.AddWithValue("@Item_Price", EnterItemPriceTb.Text);
                    command.Parameters.AddWithValue("@ItemManNum", ItemManufacturerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ItemManName", DisplayManufacturerNameTb.Text);

                    command.ExecuteNonQuery();//Executes the insert command
                    MessageBox.Show("Item Added");//Notifies the admin that an item was added
                    InventoryData_Connection.Close();//Closing connection
                    ShowInventory();//Displays inventory data from the database
                    Reset_Inventory_Input_Info();//Resets the inputted information from the textboxes.
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
                {
                    MessageBox.Show(exception.Message);//Displays message and software crashes.
                }
            }
            
        }
        //Jesus Nunez
        private void ItemManufacturerNumberCb_SelectionChangeCommitted(object sender, EventArgs e) //Displays manufacturer name based on a selected manufacturer number in the combo box
        {
            GetManufacturerName();
        }
        int InvKey = 0; //Will be used as one data per whole row in the grid.
        //Jesus Nunez
        private void InventoryGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)//Assigning inserted data to specific cells in the "Inventory List" grid.
        {
            EnterItemNameTb.Text = InventoryGridData.SelectedRows[0].Cells[1].Value.ToString(); //Item name
            EnterItemTypeCb.SelectedItem = InventoryGridData.SelectedRows[0].Cells[2].Value.ToString();//Item type
            EnterItemQuantityTb.Text = InventoryGridData.SelectedRows[0].Cells[3].Value.ToString();//Item quantity
            EnterItemPriceTb.Text = InventoryGridData.SelectedRows[0].Cells[4].Value.ToString(); //Item price
            ItemManufacturerNumberCb.SelectedValue = InventoryGridData.SelectedRows[0].Cells[5].Value.ToString();//Item manufacturer number
            DisplayManufacturerNameTb.Text = InventoryGridData.SelectedRows[0].Cells[6].Value.ToString(); //Display manufacturer name from the selected number in the "ItemManufacturerNumberCb" combo box

            if (EnterItemNameTb.Text == "") //If inventory name textbox is empty, then inventory number will not change.
            {
                InvKey = 0;
            }
            else //Each row of data will have a inventory number in cell 0.
            {
            InvKey = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }//Jesus Nunez

        private void InventoryDeleteButton_Click(object sender, EventArgs e)
        {
            if (InvKey == 0)//If there is no item selected, then message box will display "Select Item"
            {
                MessageBox.Show("Select Item");
            }
            else
            {
                try //It will connect to database and try to delete selected data from the "Customer List" grid and catch exceptions
                {
                    InventoryData_Connection.Open();//Opening database
                    SqlCommand command = new SqlCommand("Delete from InventoryTableData where ItemNumber=@ItemNumKey", InventoryData_Connection);//Sql command for deleting inventory data using ItemNumber from Database and assigning it to an sql variable key "@ItemNumKey"
                    command.Parameters.AddWithValue("@ItemNumKey", InvKey);//Selecting InvKey means to select the whole row of data in the grid.

                    command.ExecuteNonQuery(); //Executes the delete command
                    MessageBox.Show("Item Deleted");//Notifies admin a message that displays "Customer Deleted"
                    InventoryData_Connection.Close();//closing connection
                    ShowInventory();//Displaying new data on the "Inventory List" grid.
                    Reset_Inventory_Input_Info();//Reset data from the textboxes.
                }
                catch (Exception exception) //Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }
            }
        }
        //Jesus Nunez
        private void InventoryEditButton_Click(object sender, EventArgs e)
        {
            if (EnterItemNameTb.Text == "" || EnterItemQuantityTb.Text == "" || EnterItemPriceTb.Text == "" || EnterItemTypeCb.SelectedIndex == -1 || ItemManufacturerNumberCb.Text == "")//If admin has any empty textboxes, then it will display "Missing Information"
            {
                MessageBox.Show("Missing Information");
            }
            else//This will try to update data when the admin clicks on the "Edit" button in the interface and catch exceptions.
            {
                try
                {
                    InventoryData_Connection.Open();//Connect to database
                    SqlCommand command = new SqlCommand("Update InventoryTableData set ItemName=@Item_Name, ItemType=@Item_Type, ItemQuantity=@ItemQty, ItemPrice=@Item_Price,ItemManufacturerNumber=@ItemManNum, ItemManufacturerName=@ItemManName where ItemNumber=@ItemNumKey", InventoryData_Connection);//Command to update data in database

                    //Parameters to which are used to update informtation from textboxes
                    command.Parameters.AddWithValue("@Item_Name", EnterItemNameTb.Text);
                    command.Parameters.AddWithValue("@Item_Type", EnterItemTypeCb.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ItemQty", EnterItemQuantityTb.Text);
                    command.Parameters.AddWithValue("@Item_Price", EnterItemPriceTb.Text);
                    command.Parameters.AddWithValue("@ItemManNum", ItemManufacturerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ItemManName", DisplayManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ItemNumKey", InvKey);

                    command.ExecuteNonQuery();//Executes "Update" command
                    MessageBox.Show("Inventory Updated");//Displays a message box "Inventory Updated"
                    InventoryData_Connection.Close();//Closing connection
                    ShowInventory();// Displays new update information in the "Inventory List" grid.
                    Reset_Inventory_Input_Info();//Resets textbox info

                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }

            }
        }
        //Jesus Nunez
        private void InvtoHomeScreenMenuLbl_Click(object sender, EventArgs e)//When admin clicks on the "Home Screen Menu" label on the left side of the screen, the window will switch to "Home Screen Menu"
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void InvtoCustLabel_Click(object sender, EventArgs e)//When admin clicks on the "Customers" label on the left side of the screen, the window will switch to "Customers" window
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void InvtoManufactLabel_Click(object sender, EventArgs e)//When admin clicks on the "Manufacturers" label on the left side of the screen, the window will switch to "Manufacturers" window
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void InvtoEmpLabel_Click(object sender, EventArgs e)//When admin clicks on the "Employees" label on the left side of the screen, the window will switch to "Employees" window
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void InvtoLoginScreenLbl_Click(object sender, EventArgs e)//When admin clicks on "Logout" label on the botton left side of the screen, the window will switch to "UserLogin" window.
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
