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

namespace PartsnToolsSoftware
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        
        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        //Jesus Nunez
        private void BackButton_Click(object sender, EventArgs e) //The option for the admin to go back to the User Login.
        {
            UserLogin User_LoginScreen = new UserLogin(); //UserLogin is a windows form and the variable can be named to anything as it is assigned to a new UserLogin instance. 
            User_LoginScreen.Show(); //Allows the varible to display for the Admin.
            this.Hide(); //Hides Admin log in screen and displays the UserLogin windows form.
        }
        //Jesus Nunez
        private void AdminLogInButton_Click(object sender, EventArgs e) //Admin login Screen
        {
            if (AdminPasswordTb.Text == "")  //If Admin password is empty then it will display a message box stating the user to enter the correct password.
            {
                MessageBox.Show("Please enter a password");
                AdminPasswordTb.Text = "";
            }
            else if (AdminPasswordTb.Text == "Admin") // This is the Admin password.
            {
                HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu(); // If admin enters the correct password then they will be assigned to the home screen menu.
                GotoHomeScreenMenu.Show(); //Displays Home screen menu for the admin.
                this.Hide(); // Hides the admin log in screen.
            }
            else 
            {
                MessageBox.Show("Wrong Admin Password"); //If Admin enters wrong password, then it will display that it is the wrong password.
                

            }
        }
    }
}
