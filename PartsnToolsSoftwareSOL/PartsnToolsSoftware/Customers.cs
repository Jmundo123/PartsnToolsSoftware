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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent(); //Default method (automatically written) when creating/editing forms
            ShowCustomers(); //Display data
        }//Jesus Nunez
        SqlConnection CustomerData_Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30"); //Finding to database location
        //Jesus Nunez
        private void ShowCustomers() // This function displays customer data on "Customer List" Grid in the interface from the database
        {
            CustomerData_Connect.Open(); //Opening connection to database connection
            string Customer_Query = "Select * from CustomerTableData"; //Collecting string Data from the Database.
            SqlDataAdapter Cust_SDataAdapter = new SqlDataAdapter(Customer_Query, CustomerData_Connect); //Assigning new data from Customer_Query to retrieve new data.
            SqlCommandBuilder Cust_Builder = new SqlCommandBuilder(Cust_SDataAdapter); //Generating SQL commands to Cust_SDataAdapter

            
            var Cust_DataSet = new DataSet(); //Assigning to a new Datset to store data.
            Cust_SDataAdapter.Fill(Cust_DataSet);  //Filling the Cust_Dataset
            CustomerGridData.DataSource = Cust_DataSet.Tables[0]; //Populating Cust_DataSet.Tables[0]
            CustomerData_Connect.Close(); //Closing connection to database
        }
        //Jesus Nunez
        private void Reset_Customer_Input_Info() //This function resets data from the Customer interface after the admin's action.
        {
            EnterCustomerNameTb.Text = "";
            EnterCustomerAddressTb.Text = "";
            SelectCustomerGender.SelectedIndex = 0;
            EnterCustomerPhoneNumberTb.Text = "";
        }
        //Jesus Nunez
        private void Customers_Load(object sender, EventArgs e)
        {

        }
        //Jesus Nunez                                 //**Customer Save Button**
        private void CustSaveButton_Click(object sender, EventArgs e) //This function allows the "Save" button to insert data into the "Customer List" grid
        {
            if (EnterCustomerNameTb.Text == "" || EnterCustomerAddressTb.Text == "" || EnterCustomerPhoneNumberTb.Text == "" || SelectCustomerGender.SelectedIndex == -1) //If admin does not input any data then a message box will notify 
            {                                                                                                                                                             //the admin that there is missing information.
                MessageBox.Show("Missing Information");
            }
            else //If the admin fills every information from the text boxes on the if statement, then data will try be inserted into the "Customer List" grid and will also cactch exceptions if something goes wrong
            {
                try
                {
                    CustomerData_Connect.Open(); //Open connection
                    SqlCommand command = new SqlCommand("insert into CustomerTableData(CustName, CustPhone, CustAddress, Cust_DateJoined, CustGender)values(@Cust_Name, @Cust_Phone, @Cust_Address, @Cust_DateJ,@Cust_Gender)", CustomerData_Connect); //Inserting data to grid from database using the value parameters

                    //Adding parameters to specific textboxes in the customer interface. 
                    command.Parameters.AddWithValue("@Cust_Name", EnterCustomerNameTb.Text); 
                    command.Parameters.AddWithValue("@Cust_Phone", EnterCustomerPhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@Cust_Address", EnterCustomerAddressTb.Text);
                    command.Parameters.AddWithValue("@Cust_DateJ", CustomerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@Cust_Gender", SelectCustomerGender.SelectedItem.ToString());

                    command.ExecuteNonQuery(); //Executes the insert command
                    MessageBox.Show("Customer Added");//Notifies the admin that a Customer was added
                    CustomerData_Connect.Close(); //Closing connection
                    ShowCustomers(); //Displays customer data from the database
                    Reset_Customer_Input_Info(); //Resets the inputted information from the textboxes.
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays message and software crashes.
                }
            }
        }

        int CustKey = 0; //Will be used as one data per whole row in the grid.
        //Jesus Nunez
        private void CustomerGridData_CellContentClick(object sender, DataGridViewCellEventArgs e) //Assigning inserted data to specific cells in the "Customer List" grid.
        {
            EnterCustomerNameTb.Text = CustomerGridData.SelectedRows[0].Cells[1].Value.ToString();  // Customer name
            EnterCustomerPhoneNumberTb.Text = CustomerGridData.SelectedRows[0].Cells[2].Value.ToString(); // Customer phone number
            EnterCustomerAddressTb.Text = CustomerGridData.SelectedRows[0].Cells[3].Value.ToString(); // Customer address
            CustomerDateJoined.Text = CustomerGridData.SelectedRows[0].Cells[4].Value.ToString(); //Customer Date joined
            SelectCustomerGender.SelectedItem = CustomerGridData.SelectedRows[0].Cells[5].Value.ToString(); // Customer gender

            if (EnterCustomerNameTb.Text == "") //If customer name textbox is empty, then customer number will not change.
            {
                CustKey = 0; 
            }
            else //Each row of data will have a customer number in cell 0.
            {
            CustKey = Convert.ToInt32(CustomerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        //Jesus Nunez
        private void CustDeleteButton_Click(object sender, EventArgs e) //**Customer Delete Button**
        {
            if (CustKey == 0) //If there is no customer selected, then message box will display "Select Customer"
            {
                MessageBox.Show("Select Customer");
            }
            else //It will connect to database and try to delete selected data from the "Customer List" grid and catch exceptions
            {
                try
                {
                    CustomerData_Connect.Open(); //Opening database
                    SqlCommand command = new SqlCommand("Delete from CustomerTableData where CustNumber=@CustNumKey", CustomerData_Connect); //Sql command for deleting customer data using CustNumber from Database and assigning it to an sql variable key "@CustNumKey"

                    command.Parameters.AddWithValue("@CustNumKey", CustKey); //Selecting custKey means to select the whole row of data in the grid.
                    command.ExecuteNonQuery(); //Executes the delete command
                    MessageBox.Show("Customer Deleted"); //Notifies admin a message that displays "Customer Deleted"
                    CustomerData_Connect.Close(); //closing connection
                    ShowCustomers();//Displaying new data on the "Customer List" grid.
                    Reset_Customer_Input_Info();//Reset data from the textboxes.
                }
                catch (Exception exception) //Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }
            }
        }
        //Jesus Nunez
        private void CustEditButton_Click(object sender, EventArgs e)//**Customer Edit Button**
        {
            if (EnterCustomerNameTb.Text == "" || EnterCustomerAddressTb.Text == "" || EnterCustomerPhoneNumberTb.Text == "" || SelectCustomerGender.SelectedIndex == -1)//If admin has any empty textboxes, then it will display "Missing Information"
            {
                MessageBox.Show("Missing Information");
            }
            else //This will try to update data when the admin clicks on the "Edit" button in the interface and catch exceptions.
            {
                try
                {
                    CustomerData_Connect.Open(); //Connect to database
                    SqlCommand command = new SqlCommand("Update CustomerTableData set CustName=@Cust_Name, CustPhone=@Cust_Phone, CustAddress=@Cust_Address, Cust_DateJoined=@Cust_DateJ, CustGender=@Cust_Gender where CustNumber=@CustNumKey", CustomerData_Connect);//Command to update data in database

                    //Parameters which are used to update informtation from textboxes.
                    command.Parameters.AddWithValue("@Cust_Name", EnterCustomerNameTb.Text);
                    command.Parameters.AddWithValue("@Cust_Phone", EnterCustomerPhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@Cust_Address", EnterCustomerAddressTb.Text);
                    command.Parameters.AddWithValue("@Cust_DateJ", CustomerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@Cust_Gender", SelectCustomerGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@CustNumKey", CustKey);

                    
                    command.ExecuteNonQuery(); //Executes "Update" command
                    MessageBox.Show("Customer Updated"); //Displays a message box "Customer Updated"
                    CustomerData_Connect.Close(); //Closing connection
                    ShowCustomers();// Displays new update information in the "Customer List" grid.
                    Reset_Customer_Input_Info(); //Resets textbox info

                }
                catch (Exception exception) //Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message); //Displays error message and software crashes.
                }
            
            }
        }
        //Jesus Nunez
        private void CustToHSMLbl_Click(object sender, EventArgs e) //When admin clicks on the "Home Screen Menu" label on the left side of the screen, the window will switch to "Home Screen Menu"
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void CustToInvLbl_Click(object sender, EventArgs e)//When admin clicks on the "Inventory" label on the left side of the screen, the window will switch to "Inventory" window
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void CustToManufactLbl_Click(object sender, EventArgs e)//When admin clicks on the "Manufacturers" label on the left side of the screen, the window will switch to "Manufacturers" window
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void CustToEmpLbl_Click(object sender, EventArgs e) //When admin clicks on the "Employees" label on the left side of the screen, the window will switch to "Employees" window
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void CustToLogInSLbl_Click(object sender, EventArgs e) //When admin clicks on "Logout" label on the botton left side of the screen, the window will switch to "UserLogin" window.
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
