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
    public partial class Manufacturers : Form
    {
        public Manufacturers()
        {
            InitializeComponent();
            ShowManufacturer();
        }
        //Jesus Nunez
        SqlConnection ManufacturerData_Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30"); //Finding to database location
        private void ShowManufacturer()// This function displays customer data on "Customer List" Grid in the interface from the database
        {
            ManufacturerData_Connect.Open();//Opening connection to database connection
            string Manufacturer_Query = "Select * from ManufacturerTableData";//Collecting string Data from the Database.
            SqlDataAdapter ManuSdataAdapter = new SqlDataAdapter(Manufacturer_Query, ManufacturerData_Connect);//Assigning new data from Manufacturer_Query to retrieve new data.
            SqlCommandBuilder ManBuilder = new SqlCommandBuilder(ManuSdataAdapter);//Generating SQL commands to ManuSdataAdapter
            var Mdataset = new DataSet();//Assigning to a new Datset to store data
            ManuSdataAdapter.Fill(Mdataset);//Filling the Mdataset
            ManufacturerGridData.DataSource = Mdataset.Tables[0];//Populating Mdataset.Tables[0]
            ManufacturerData_Connect.Close();//Closing connection to database

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //Jesus Nunez
        private void ManufacturerSaveButton_Click(object sender, EventArgs e)//This function allows the "Save" button to insert data into the "Manufacturer List" grid
        {
            if (EnterManufacturerNameTb.Text == "" || EnterManufacturerAddressTb.Text == "" || EnterManufacturerPhoneTb.Text == "") //If admin does not input any data then a message box will notify 
            {                                                                                                                       //the admin that there is missing information.
                MessageBox.Show("Missing Information");
            }
            else //If the admin fills every information from the text boxes on the if statement, then data will try be inserted into the "Manufacturer List" grid and will also cactch exceptions if something goes wrong
            {
                try
                {
                    ManufacturerData_Connect.Open();//Open connection
                    SqlCommand command = new SqlCommand("insert into ManufacturerTableData(ManufacturerName, ManufacturerAddress, ManufacturerPhone, ManufacturerDateJoin)values(@ManName,@ManAdd,@ManPhone,@ManDJoin)", ManufacturerData_Connect);//Inserting data to grid from database using the value parameters

                    //Adding parameters to specific textboxes in the customer interface.
                    command.Parameters.AddWithValue("@ManName", EnterManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ManAdd", EnterManufacturerAddressTb.Text);
                    command.Parameters.AddWithValue("@ManPhone", EnterManufacturerPhoneTb.Text);
                    command.Parameters.AddWithValue("ManDJoin", ManufacturerDateJoined.Value.Date);
                    command.ExecuteNonQuery();//Executes the insert command
                    MessageBox.Show("Manufacturer Added");//Notifies the admin that a Manufacturer was added
                    ManufacturerData_Connect.Close(); //Closing connection
                    ShowManufacturer();//Displays manufacturer data from the database
                    Reset_Manufacturer_Input_Info();//Resets the inputted information from the textboxes.

                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays message and software crashes.
                }

            }
        }
        int Mankey = 0;//Will be used as one data per whole row in the grid.
        private void Manufacturers_Load(object sender, EventArgs e)
        {

        }

        private void EnterManufacturerNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        //Jesus Nunez
        private void ManufacturerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)//Assigning inserted data to specific cells in the "Manufacturer List" grid.
        {
            EnterManufacturerNameTb.Text = ManufacturerGridData.SelectedRows[0].Cells[1].Value.ToString(); //Manufacturer name
            EnterManufacturerAddressTb.Text = ManufacturerGridData.SelectedRows[0].Cells[2].Value.ToString();//Manufacturer address
            EnterManufacturerPhoneTb.Text = ManufacturerGridData.SelectedRows[0].Cells[3].Value.ToString(); //Manufacturer phone number
            ManufacturerDateJoined.Text = ManufacturerGridData.SelectedRows[0].Cells[4].Value.ToString(); //Manufacturer date joined
            if (EnterManufacturerNameTb.Text == " ") //If manufacturer name textbox is empty, then manufacturer number will not change.
            {
                Mankey = 0;
            }
            else //The each row of data will have a manufacturer number in cell 0.
            {
                Mankey = Convert.ToInt32(ManufacturerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }



        }
        //Jesus Nunez
        private void ManufacturerDeleteButton_Click(object sender, EventArgs e)
        {
            if (Mankey == 0)//If there is no manufacturer selected, then message box will display "Select Manufacturer"
            {
                MessageBox.Show("Select the Manufacturer");
            }
            else//It will connect to database and try to delete selected data from the "Manufacturer List" grid and catch exceptions
            {
                try
                {
                    ManufacturerData_Connect.Open();//Opening database
                    SqlCommand command = new SqlCommand("Delete from ManufacturerTableData where ManufacturerNumber=@ManKey", ManufacturerData_Connect);//Sql command for deleting customer data using CustNumber from Database and assigning it to an sql variable key "@ManKey"

                    command.Parameters.AddWithValue("@Mankey", Mankey);//Selecting Mankey means to select the whole row of data in the grid.
                    command.ExecuteNonQuery();//Executes the delete command
                    MessageBox.Show("Manufacturer Deleted");//Notifies admin a message that displays "Manufacturer Deleted"

                    ManufacturerData_Connect.Close();//closing connection
                    ShowManufacturer();//Displaying new data on the "Manufacturer List" grid.
                    Reset_Manufacturer_Input_Info();//Reset data from the textboxes.
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                { 
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }              
            }
        }
        //Jesus Nunez
        private void Reset_Manufacturer_Input_Info()//This function resets data from the Customer interface after the admin's action.
        {
            EnterManufacturerNameTb.Text = "";
            EnterManufacturerAddressTb.Text = "";
            EnterManufacturerPhoneTb.Text = "";
            Mankey = 0;
        }
        //Jesus Nunez
        private void ManufacturerEditButton_Click(object sender, EventArgs e)
        {
            if (EnterManufacturerNameTb.Text == "" || EnterManufacturerAddressTb.Text == "" || EnterManufacturerPhoneTb.Text == "")//If admin has any empty textboxes, then it will display "Missing Information"
            {
                MessageBox.Show("Missing Information");
            }
            else //This will try to update data when the admin clicks on the "Edit" button in the interface and catch exceptions.
            {
                try
                {
                    ManufacturerData_Connect.Open();//Connect to database
                    SqlCommand command = new SqlCommand("Update ManufacturerTableData Set ManufacturerName=@ManName, ManufacturerAddress=@ManAdd, ManufacturerPhone=@ManPhone, ManufacturerDateJoin=@ManDJoin where ManufacturerNumber=@ManKey", ManufacturerData_Connect);//Command to update data in database

                    //Parameters which are used to update informtation from textboxes.
                    command.Parameters.AddWithValue("@ManName", EnterManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ManAdd", EnterManufacturerAddressTb.Text);
                    command.Parameters.AddWithValue("@ManPhone", EnterManufacturerPhoneTb.Text);
                    command.Parameters.AddWithValue("@ManDJoin", ManufacturerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@ManKey", Mankey);
                    command.ExecuteNonQuery();//Executes "Update" command
                    MessageBox.Show("Manufacturer Updated");//Displays a message box "Manufacturer Updated"
                    ManufacturerData_Connect.Close();//Closing connection
                    ShowManufacturer();// Displays new update information in the "Manufacturer List" grid.
                    Reset_Manufacturer_Input_Info();//Resets textbox info
                }
                catch (Exception exception)//Catching exceptions and displaying a message for the exception in the software. 
                {
                    MessageBox.Show(exception.Message);//Displays error message and software crashes.
                }
            }
        }
        //Jesus Nunez
        private void ManufacturerGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)//Assigning inserted data to specific cells in the "Manufacturer List" grid.
        {
            EnterManufacturerNameTb.Text = ManufacturerGridData.SelectedRows[0].Cells[1].Value.ToString(); //Manufacturer name
            EnterManufacturerAddressTb.Text = ManufacturerGridData.SelectedRows[0].Cells[2].Value.ToString(); //Manufacturer address
            EnterManufacturerPhoneTb.Text = ManufacturerGridData.SelectedRows[0].Cells[3].Value.ToString(); // Manufacturer phone number
            ManufacturerDateJoined.Text = ManufacturerGridData.SelectedRows[0].Cells[4].Value.ToString(); //Manufacturer date joined
            if (EnterManufacturerNameTb.Text == " ")//If manufacturer name textbox is empty, then customer number will not change.
            {
                Mankey = 0;
            }
            else//Each row of data will have a manufacturer number in cell 0.
            {
                Mankey = Convert.ToInt32(ManufacturerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
        //Jesus Nunez
        private void ManufactToHSMLbl_Click(object sender, EventArgs e)//When admin clicks on the "Home Screen Menu" label on the left side of the screen, the window will switch to "Home Screen Menu"
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void ManufactToInvLbl_Click(object sender, EventArgs e)//When admin clicks on the "Inventory" label on the left side of the screen, the window will switch to "Inventory" window
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void ManufactToCustLbl_Click(object sender, EventArgs e)//When admin clicks on the "Customers" label on the left side of the screen, the window will switch to "Customers" window
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void ManufactToEmpLbl_Click(object sender, EventArgs e)//When admin clicks on the "Employees" label on the left side of the screen, the window will switch to "Employees" window
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }
        //Jesus Nunez
        private void ListofManufacturers_Click(object sender, EventArgs e)// This is suppose to be the Logout label, which if the admin clicks on it they will go back to the "Login" screen
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
