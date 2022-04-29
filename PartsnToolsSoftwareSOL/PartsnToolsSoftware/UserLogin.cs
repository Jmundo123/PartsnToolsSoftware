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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
        //Jesus Nunez
        private void AdminButton_Click(object sender, EventArgs e) //If user clicks admin label, then they will be sent to admin log in screen
        {
            AdminLogin Admin_LoginScreen = new AdminLogin();
            Admin_LoginScreen.Show();
            this.Hide();
        }
        //Jesus Nunez
        SqlConnection UserName_Connetion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");//Finding to database location
        public static string UserName;
        //Jesus Nunez
        private void LoginButton_Click(object sender, EventArgs e) //Login button is it is pressed
        {
            if (EnterUserNameTb.Text == "" || UserNamePasswordTb.Text == "") //If user has not entered username or password, message box will appear notifying user to "Please Enter both Username and Password"
            {
                MessageBox.Show("Please Enter both Username and Password");
            }
            else //connect to sql
            {
                UserName_Connetion.Open(); //Open connection
                SqlDataAdapter User_DataAdapter = new SqlDataAdapter("Select Count(*) from EmployeeTableData where EmployeeName='" + EnterUserNameTb.Text + "' and EmployeePassword='" + UserNamePasswordTb.Text + "'", UserName_Connetion); //Selecting all data if it matches the users login information
                DataTable UserDataTable = new DataTable(); //Assigning to a new DataTable to fill Datatable from the DataAdapter
                User_DataAdapter.Fill(UserDataTable);//Filling the UserDataTable

                if (UserDataTable.Rows[0][0].ToString() == "1") //If user succesfully logsin with correct username and password
                {
                    UserName = EnterUserNameTb.Text; //Username will be displayed in the transactions window
                    Transactions TransactionsInterface = new Transactions(); //User will be prompted to Transactions window
                    TransactionsInterface.Show();
                    this.Hide();
                    UserName_Connetion.Close();//Close connection
                }
                else //If user enters either a wrong username or password, message "Wrong Username or Password" will appear
                {
                    MessageBox.Show("Wrong Username or Password");
                }

                UserName_Connetion.Close();//Close connection




            }
        }
    }
}
