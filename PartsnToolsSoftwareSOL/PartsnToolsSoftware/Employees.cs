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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();//Default method (automatically written) when creating/editing forms
            ShowEmployees();//Display data
        }
        SqlConnection EmployeeData_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");//Finding to database location
        //Jesus Nunez
        private void ShowEmployees() // This function displays customer data on "Employees List" Grid in the interface from the database
        {
            EmployeeData_Connection.Open(); //Opening connection to database connection
            string Employee_Query = "Select * from EmployeeTableData";//Collecting string Data from the Database.
            SqlDataAdapter Employee_SDataAdapter = new SqlDataAdapter(Employee_Query, EmployeeData_Connection);//Assigning new data from Employee_Query to retrieve new data.
            SqlCommandBuilder Emp_Builder = new SqlCommandBuilder(Employee_SDataAdapter);//Generating SQL commands to Employee_SDataAdapter


            var Emp_DataSet = new DataSet();//Assigning to a new Datset to store data.
            Employee_SDataAdapter.Fill(Emp_DataSet);//Filling the Emp_DataSet
            EmployeeGridData.DataSource = Emp_DataSet.Tables[0];//Populating Emp_DataSet.Tables[0]
            EmployeeData_Connection.Close();//Closing connection to database
        }
        //Jesus Nunez
        private void Reset_Employee_Input_Info()//This function resets data from the Employee interface after a user's action.
        {
            EnterEmployeeNameTb.Text = "";
            EnterEmployeePhoneNumberTb.Text = "";
            EnterEmployeeAddressTb.Text = "";
            EnterEmployeePasswordTb.Text = "";
            SelectEmployeeGender.SelectedIndex = 0;
            EmpKey = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        //Jesus Nunez           //**Customer Save Button**
        private void EmployeeSaveButton_Click(object sender, EventArgs e)//This function allows the "Save" button to insert data into the "Employee List" grid
        {
            if (EnterEmployeeNameTb.Text == "" || EnterEmployeePhoneNumberTb.Text == "" || EnterEmployeeAddressTb.Text == "" || EnterEmployeePasswordTb.Text == "" || SelectEmployeeGender.SelectedIndex == -1)//If admin does not input any data then a message box will notify
            {                                                                                                                                                                                                   //the admin that there is missing information.
                MessageBox.Show("Missing Information");
            }
            else//If the admin fills in every information from the text boxes on the if statement, then data will try be inserted into the "Employee List" grid and will also cactch exceptions if something goes wrong
            {
                try
                {
                    EmployeeData_Connection.Open();//Open connection
                    SqlCommand command = new SqlCommand("insert into EmployeeTableData(EmployeeName, EmployeeAddress, EmployeePhone, EmployeeDateJoined, EmployeeGender, EmployeePassword)values(@EmpName,@EmpAddress,@EmpPhone,@EmpDateJ,@EmpGen,@EmpPass)", EmployeeData_Connection); //Inserting data to grid from database using the value parameters

                    //Adding parameters to specific textboxes in the employee interface.
                    command.Parameters.AddWithValue("@EmpName", EnterEmployeeNameTb.Text);
                    command.Parameters.AddWithValue("@EmpDateJ", EnterEmployeeDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@EmpPhone", EnterEmployeePhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@EmpAddress", EnterEmployeeAddressTb.Text);
                    command.Parameters.AddWithValue("@EmpGen", SelectEmployeeGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@EmpPass", EnterEmployeePasswordTb.Text);

                    command.ExecuteNonQuery();//Executes the insert command
                    MessageBox.Show("Employee Added");//Notifies the admin that an Employee was added
                    EmployeeData_Connection.Close();//Closing connection
                    ShowEmployees();//Displays employee data from the database
                    Reset_Employee_Input_Info();//Resets the inputted information from the textboxes.
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software.
                {
                    MessageBox.Show(exception.Message);//Displays message and software crashes.
                }
            }
        }

        int EmpKey = 0;//Will be used as one data per whole row in the grid.
        //Jesus Nunez
        private void EmployeeGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)//Assigning inserted data to specific cells in the "Employee List" grid.
        {
            EnterEmployeeNameTb.Text = EmployeeGridData.SelectedRows[0].Cells[1].Value.ToString(); //Employee name
            EnterEmployeeDateJoined.Text = EmployeeGridData.SelectedRows[0].Cells[2].Value.ToString(); //Employee date joined
            EnterEmployeePhoneNumberTb.Text = EmployeeGridData.SelectedRows[0].Cells[3].Value.ToString(); //Employee Phone number
            EnterEmployeeAddressTb.Text = EmployeeGridData.SelectedRows[0].Cells[4].Value.ToString(); //Employee address
            SelectEmployeeGender.SelectedItem = EmployeeGridData.SelectedRows[0].Cells[5].Value.ToString(); //Employee gender
            EnterEmployeePasswordTb.Text = EmployeeGridData.SelectedRows[0].Cells[6].Value.ToString(); //Employee password

            if (EnterEmployeeNameTb.Text == "")//If employee name textbox is empty, then employee number will not change.
            {
                EmpKey = 0;
            }
            else  //The each row of data will have an employee number in cell 0.
            {
                EmpKey = Convert.ToInt32(EmployeeGridData.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        //Jesus Nunez
        private void EmployeeDeleteButton_Click(object sender, EventArgs e)//**Employee Delete Button**
        {
            if (EmpKey == 0)//If there is no employee selected, then message box will display "Select Employee"
            {
                MessageBox.Show("Select Employee");
            }
            else //It will connect to database and try to deleted selected data from the "Employee List" grid and catch exceptions
            {
                try
                {
                    EmployeeData_Connection.Open();//Opening database
                    SqlCommand command = new SqlCommand("Delete from EmployeeTableData where EmployeeNumber=@EmployeeKey", EmployeeData_Connection);//Sql command for deleting employee data using EmployeeNumber from Database and assigning it to an sql variable key "@EmployeeKey"
                    command.Parameters.AddWithValue("@EmployeeKey", EmpKey);//Selecting EmpKey means to select the whole row of data in the grid.

                    command.ExecuteNonQuery(); //Executes the delete command
                    MessageBox.Show("Employee Deleted");//Notifies the user a message that displays "Employee Deleted"
                    EmployeeData_Connection.Close();//closing connection
                    ShowEmployees();//Displaying new data on the "Employee List" grid.
                    Reset_Employee_Input_Info();//Reset data from the textboxes.
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }

            }
        }
        //Jesus Nunez
        private void EmployeeEditButton_Click(object sender, EventArgs e)//**Employee Edit Button**
        {
            if (EnterEmployeeNameTb.Text == "" || EnterEmployeePhoneNumberTb.Text == "" || EnterEmployeeAddressTb.Text == "" || EnterEmployeePasswordTb.Text == "" || SelectEmployeeGender.SelectedIndex == -1)//If admin has any empty textboxes, then it will display "Missing Information"
            {
                MessageBox.Show("Missing Information");
            }
            else //This will try to update data when the admin clicks on the "Edit" button in the interface and catch exceptions.
            {
                try
                {
                    EmployeeData_Connection.Open();//Connect to database
                    SqlCommand command = new SqlCommand("Update EmployeeTableData Set EmployeeName=@EmpName, EmployeeAddress=@EmpAddress, EmployeePhone=@EmpPhone, EmployeeDateJoined=@EmpDateJ, EmployeeGender=@EmpGen, EmployeePassword=@EmpPass where EmployeeNumber=@EmployeeKey", EmployeeData_Connection);//Command to update data in database

                    //Parameters to which are used to update informtation from textboxes
                    command.Parameters.AddWithValue("@EmpName", EnterEmployeeNameTb.Text);
                    command.Parameters.AddWithValue("@EmpDateJ", EnterEmployeeDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@EmpPhone", EnterEmployeePhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@EmpAddress", EnterEmployeeAddressTb.Text);
                    command.Parameters.AddWithValue("@EmpGen", SelectEmployeeGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@EmpPass", EnterEmployeePasswordTb.Text);
                    command.Parameters.AddWithValue("@EmployeeKey", EmpKey);

                    command.ExecuteNonQuery();//Executes "Update" command
                    MessageBox.Show("Employee Updated");//Displays a message box "Employee Updated"
                    EmployeeData_Connection.Close();//Closing connection
                    ShowEmployees();// Displays new update information in the "Employee List" grid.
                    Reset_Employee_Input_Info();//Resets textbox info
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }

            }
        }
        //Jesus Nunez
        private void EmpToHSMLbl_Click(object sender, EventArgs e) //When admin clicks on the "Home Screen Menu" label on the left side of the screen, the window will switch to "Home Screen Menu"
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void EmpToInvLbl_Click(object sender, EventArgs e) //When admin clicks on the "Inventory" label on the left side of the screen, the window will switch to "Inventory" window
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void EmpToCustLbl_Click(object sender, EventArgs e) //When admin clicks on the "Customers" label on the left side of the screen, the window will switch to "Customers" window
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void EmpToManufactLbl_Click(object sender, EventArgs e) //When admin clicks on the "Manufacturers" label on the left side of the screen, the window will switch to "Manufacturers" window
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void label18_Click(object sender, EventArgs e) //When admin clicks on "Logout" label on the botton left side of the screen, the window will switch to "UserLogin" window.
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
