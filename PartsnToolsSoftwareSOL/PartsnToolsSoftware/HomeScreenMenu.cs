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
    public partial class HomeScreenMenu : Form
    {
        public HomeScreenMenu()
        {
            InitializeComponent();
            CountInventory();//Displays total number of different items (not total) from database
            CountEmployees();//Displays total number of employees
            CountCustomers();//Displays total number of customers
            SalesTotalAmount();//Displays total amount of sales
            SelectEmployeeSalesInfo();//Select employee info in combox
            BestEmployee();//Displays best employee
            BestCustomer();//Displays best customer
        }
        SqlConnection HomeScreen_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");
        //Jesus Nunez
        private void CountInventory() //Function counts the number of different items of inventory, not the total amount.
        {
            HomeScreen_Connection.Open(); //Open connection
            SqlDataAdapter Inventory_DataAdpater = new SqlDataAdapter("Select Count(*) from InventoryTableData", HomeScreen_Connection); //Assigning Inventory_DataAdpater to count all data from the SQL database in "InvnetoryTableData"
            DataTable Inventory_DataTable = new DataTable(); //Assigning to a new DataTable to fill Datatable from the DataAdapter
            Inventory_DataAdpater.Fill(Inventory_DataTable); //Filling DataTable from DataAdapter
            InventoryCountLabel.Text = Inventory_DataTable.Rows[0][0].ToString(); //Replaces "InventoryCountLabel.Text" to display inventory count
            HomeScreen_Connection.Close(); //closing connection
        }
        //Jesus Nunez
        private void CountEmployees() // Function counts the total number of employee accounts in the software
        {
            HomeScreen_Connection.Open();//Open connection
            SqlDataAdapter Employee_DataAdpater = new SqlDataAdapter("Select Count(*) from EmployeeTableData", HomeScreen_Connection);//Assigning Employee_DataAdpater to count all data from the SQL database "EmployeeTableData"
            DataTable Employee_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
            Employee_DataAdpater.Fill(Employee_DataTable);//Filling DataTable from DataAdapter
            EmployeeCountLabel.Text = Employee_DataTable.Rows[0][0].ToString();//Replaces "InventoryCountLabel.Text" to display inventory count
            HomeScreen_Connection.Close();//closing connection
        }
        //Jesus Nunez
        private void CountCustomers() // Function counts the total number of customers accounts in the software
        {
            HomeScreen_Connection.Open();//Open connection
            SqlDataAdapter Customers_DataAdpater = new SqlDataAdapter("Select Count(*) from CustomerTableData", HomeScreen_Connection);//Assigning Customers_DataAdpater to count all data from the SQL database in "CustomerTableData"
            DataTable Customers_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
            Customers_DataAdpater.Fill(Customers_DataTable);//Filling DataTable from DataAdapter
            CustomerCountLabel.Text = Customers_DataTable.Rows[0][0].ToString();//Replaces "CustomerCountLabel.Text" to display customer count
            HomeScreen_Connection.Close();//Close connection
        }
        //Jesus Nunez
        private void SalesTotalAmount() // Function gets the overall total amount of sales
        {
            HomeScreen_Connection.Open();//Open connection
            SqlDataAdapter SalesTotalAmount_DataAdpater = new SqlDataAdapter("Select Sum(TransactionAmount) from TransactionTableData", HomeScreen_Connection);//Assigning SalesTotalAmount_DataAdpater to add all data from the SQL database from "TransactionAmount" in "TransactionTableData"
            DataTable SalesTotalAmount_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
            SalesTotalAmount_DataAdpater.Fill(SalesTotalAmount_DataTable);//Filling DataTable from DataAdapter
            SalesTotalAmountLabel.Text = "         $" + SalesTotalAmount_DataTable.Rows[0][0].ToString();//Replaces "SalesTotalAmountLabel.Text" to display the "$" and the overall total amount of sales.
            HomeScreen_Connection.Close();//Close connection

        }
        //Jesus Nunez
        private void SalesTotalAmountByEmployee() // Function gets the total amount of sales by employee
        {
            HomeScreen_Connection.Open();//Open connection
            SqlDataAdapter STAE_DataAdapter = new SqlDataAdapter("Select Sum(TransactionAmount) from TransactionTableData where EmployeeName='"+ SelectEmployeeSalesInfoCb.SelectedValue.ToString() + "'", HomeScreen_Connection);//Assigning SalesTotalAmount_DataAdpater to add all data from the SQL database from "TransactionAmount" in "TransactionTableData" by EmployeeName in the combo box
            DataTable STAE_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
            STAE_DataAdapter.Fill(STAE_DataTable);//Filling DataTable from DataAdapter
            SalesByEmployeeLabel.Text = "         $" + STAE_DataTable.Rows[0][0].ToString();//Replaces "SalesByEmployeeLabel.Text" to display the "$" and the total amount of sales from the chosen employee in the combo box.
            HomeScreen_Connection.Close();//closing connection
        }
        //Jesus Nunez
        private void BestEmployee() //Function tries to get the best employee based on employee sales and catches exceptions
        {
            try
            {
                HomeScreen_Connection.Open();//Open connection
                string BestEmployee_Query = "Select Max(TransactionAmount) from TransactionTableData"; //Assigning "BestEmployee_Query" to select the highest sales from the SQL database from "TransactionAmount" in "TransactionTableData".
                DataTable BestEmployee_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
                SqlDataAdapter BestEmployee_DataAdapter = new SqlDataAdapter(BestEmployee_Query, HomeScreen_Connection); //Using the data adapter to retrieve data from BestEmployee_Query
                BestEmployee_DataAdapter.Fill(BestEmployee_DataTable);//Filling BestEmployee_DataTable

                string BEmployee_Query = "Select EmployeeName from TransactionTableData where TransactionAmount = '" + BestEmployee_DataTable.Rows[0][0].ToString() + "'";//Assigning "BEmployee_Query" to select the "EmployeeName" with the highest sales from the SQL database from "TransactionAmount" in "TransactionTableData".
                SqlDataAdapter BEmployee_DataAdapter = new SqlDataAdapter(BEmployee_Query, HomeScreen_Connection); //Using the data adapter to retrieve data from BEmployee_Query
                DataTable BEmployee_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
                BEmployee_DataAdapter.Fill(BEmployee_DataTable);//Filling the BEmployee_DataTable 
                BestEmployeeLabel.Text = BEmployee_DataTable.Rows[0][0].ToString();//Replaces "BestEmployeeLabel.Text" to display the best employee
                HomeScreen_Connection.Close();//Close connection
            }
            catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
            {
                HomeScreen_Connection.Close();//Displays message and software crashes.
            }    
        }
        //Jesus Nunez
        private void BestCustomer()//Function tries to get the best customer based on customer sales and catches exceptions
        {
            try
            {
                HomeScreen_Connection.Open();//Open connection
                string BestCustomer_Query = "Select Max(TransactionAmount) from TransactionTableData";//Assigning "BestCustomer_Query" to select the highest sales from the SQL database from "TransactionAmount" in "TransactionTableData".
                DataTable BestCustomer_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
                SqlDataAdapter BestCustomer_DataAdapter = new SqlDataAdapter(BestCustomer_Query, HomeScreen_Connection);//Using the data adapter to retrieve data from BestCustomer_Query
                BestCustomer_DataAdapter.Fill(BestCustomer_DataTable);//Filling BestCustomer_DataTable

                string BCustomer_Query = "Select CustName from TransactionTableData where TransactionAmount = '" + BestCustomer_DataTable.Rows[0][0].ToString() + "'";//Assigning "BCustomer_Query" to select the "CustName" with the highest sales from the SQL database from "TransactionAmount" in "TransactionTableData".
                SqlDataAdapter BCustomer_DataAdapter = new SqlDataAdapter(BCustomer_Query, HomeScreen_Connection);//Using the data adapter to retrieve data from BCustomer_Query
                DataTable BCustomer_DataTable = new DataTable();//Assigning to a new DataTable to fill Datatable from the DataAdapter
                BCustomer_DataAdapter.Fill(BCustomer_DataTable);//Filling the BCustomer_DataTable 
                BestCustomerLabel.Text = BCustomer_DataTable.Rows[0][0].ToString();//Replaces "BestEmployeeLabel.Text" to display the best customer
                HomeScreen_Connection.Close();//Close connection
            }
            catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
            {
                HomeScreen_Connection.Close();//Displays message and software crashes.
            }
       
        }
        //Jesus Nunez
        private void SelectEmployeeSalesInfo() //Funtion gives the user to select an employee and view the amount of sales they made.
        {
            HomeScreen_Connection.Open();//Open connection
            SqlCommand command = new SqlCommand("Select EmployeeName from EmployeeTableData", HomeScreen_Connection); //Command to select "EmployeeName" from "EmployeeTableData"
            SqlDataReader Employee_DataReader; //Read only info
            Employee_DataReader = command.ExecuteReader(); //Getting records from database
            DataTable Employee_DataTable = new DataTable();//"Employee_DataTable" variable assign to new DataTable to add specific data.
            Employee_DataTable.Columns.Add("EmployeeName", typeof(string)); //Adding "EmployeeName" from the columns database table "EmployeeTableData"
            Employee_DataTable.Load(Employee_DataReader); //Load data to Employee_DataReader
            SelectEmployeeSalesInfoCb.ValueMember = "EmployeeName"; //Getting "EmployeeName" from EmployeeTableData and assigning it to "SelectEmployeeSalesInfoCb" 
            SelectEmployeeSalesInfoCb.DataSource = Employee_DataTable; //Storing data to the "SelectEmployeeSalesInfoCb" combo box from Employee_DataTable
            HomeScreen_Connection.Close();//Close connection
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreenMenu_Load(object sender, EventArgs e)
        {

        }

        private void SelectEmployeeSalesInfoCb_SelectionChangeCommitted(object sender, EventArgs e) //Displays employee sales from the "SalesTotalAmountByEmployee"
        {
            SalesTotalAmountByEmployee();
        }

        private void LogOutLabel_Click(object sender, EventArgs e) //When admin clicks on "Logout" label on the botton left side of the screen, the window will switch to "UserLogin" window.
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }

        private void InventoryMenuLabel_Click(object sender, EventArgs e)//When admin clicks on the "Inventory" label on the left side of the screen, the window will switch to "Inventory" window
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }

        private void CustomerMenuLabel_Click(object sender, EventArgs e)//When admin clicks on the "Customers" label on the left side of the screen, the window will switch to "Customers" window
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }

        private void ManufacturersMenuLabel_Click(object sender, EventArgs e)//When admin clicks on the "Manufacturers" label on the left side of the screen, the window will switch to "Manufacturers" window
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }

        private void EmployeesMenuLabel_Click(object sender, EventArgs e)//When admin clicks on the "Employees" label on the left side of the screen, the window will switch to "Employees" window
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }
    }
}
