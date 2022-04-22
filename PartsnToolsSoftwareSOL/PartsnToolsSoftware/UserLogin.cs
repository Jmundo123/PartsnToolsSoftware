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

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLogin Admin_LoginScreen = new AdminLogin();
            Admin_LoginScreen.Show();
            this.Hide();
        }
        SqlConnection UserName_Connetion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");
        public static string UserName;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EnterUserNameTb.Text == "" || UserNamePasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter both Username and Password");
            }
            else
            {
                UserName_Connetion.Open();
                SqlDataAdapter User_DataAdapter = new SqlDataAdapter("Select Count(*) from EmployeeTableData where EmployeeName='" + EnterUserNameTb.Text + "' and EmployeePassword='" + UserNamePasswordTb.Text + "'", UserName_Connetion);
                DataTable UserDataTable = new DataTable();
                User_DataAdapter.Fill(UserDataTable);

                if (UserDataTable.Rows[0][0].ToString() == "1")
                {
                    UserName = EnterUserNameTb.Text;
                    Transactions TransactionsInterface = new Transactions();
                    TransactionsInterface.Show();
                    this.Hide();
                    UserName_Connetion.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

                UserName_Connetion.Close();




            }
        }
    }
}
