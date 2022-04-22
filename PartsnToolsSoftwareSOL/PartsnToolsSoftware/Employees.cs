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
            InitializeComponent();
            ShowEmployees();
        }
        SqlConnection EmployeeData_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowEmployees()
        {
            EmployeeData_Connection.Open();
            string Employee_Query = "Select * from EmployeeTableData";
            SqlDataAdapter Employee_SDataAdapter = new SqlDataAdapter(Employee_Query, EmployeeData_Connection);
            SqlCommandBuilder Emp_Builder = new SqlCommandBuilder(Employee_SDataAdapter);
            var Emp_DataSet = new DataSet();
            Employee_SDataAdapter.Fill(Emp_DataSet);
            EmployeeGridData.DataSource = Emp_DataSet.Tables[0];
            EmployeeData_Connection.Close();
        }
        private void Reset_Employee_Input_Info()
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

        private void EmployeeSaveButton_Click(object sender, EventArgs e)
        {
            if (EnterEmployeeNameTb.Text == "" || EnterEmployeePhoneNumberTb.Text == "" || EnterEmployeeAddressTb.Text == "" || EnterEmployeePasswordTb.Text == "" || SelectEmployeeGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    EmployeeData_Connection.Open();
                    SqlCommand command = new SqlCommand("insert into EmployeeTableData(EmployeeName, EmployeeAddress, EmployeePhone, EmployeeDateJoined, EmployeeGender, EmployeePassword)values(@EmpName,@EmpAddress,@EmpPhone,@EmpDateJ,@EmpGen,@EmpPass)", EmployeeData_Connection);

                    command.Parameters.AddWithValue("@EmpName", EnterEmployeeNameTb.Text);
                    command.Parameters.AddWithValue("@EmpDateJ", EnterEmployeeDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@EmpPhone", EnterEmployeePhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@EmpAddress", EnterEmployeeAddressTb.Text);
                    command.Parameters.AddWithValue("@EmpGen", SelectEmployeeGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@EmpPass", EnterEmployeePasswordTb.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    EmployeeData_Connection.Close();
                    ShowEmployees();
                    Reset_Employee_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        int EmpKey = 0;

        private void EmployeeGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnterEmployeeNameTb.Text = EmployeeGridData.SelectedRows[0].Cells[1].Value.ToString();
            EnterEmployeeDateJoined.Text = EmployeeGridData.SelectedRows[0].Cells[2].Value.ToString();
            EnterEmployeePhoneNumberTb.Text = EmployeeGridData.SelectedRows[0].Cells[3].Value.ToString();
            EnterEmployeeAddressTb.Text = EmployeeGridData.SelectedRows[0].Cells[4].Value.ToString();
            SelectEmployeeGender.SelectedItem = EmployeeGridData.SelectedRows[0].Cells[5].Value.ToString();
            EnterEmployeePasswordTb.Text = EmployeeGridData.SelectedRows[0].Cells[6].Value.ToString();

            if (EnterEmployeeNameTb.Text == "")
            {
                EmpKey = 0;
            }
            else
            {
                EmpKey = Convert.ToInt32(EmployeeGridData.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void EmployeeDeleteButton_Click(object sender, EventArgs e)
        {
            if (EmpKey == 0)
            {
                MessageBox.Show("Select Employee");
            }
            else
            {
                try
                {
                    EmployeeData_Connection.Open();
                    SqlCommand command = new SqlCommand("Delete from EmployeeTableData where EmployeeNumber=@EmployeeKey", EmployeeData_Connection);
                    command.Parameters.AddWithValue("@EmployeeKey", EmpKey);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    EmployeeData_Connection.Close();
                    ShowEmployees();
                    Reset_Employee_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void EmployeeEditButton_Click(object sender, EventArgs e)
        {
            if (EnterEmployeeNameTb.Text == "" || EnterEmployeePhoneNumberTb.Text == "" || EnterEmployeeAddressTb.Text == "" || EnterEmployeePasswordTb.Text == "" || SelectEmployeeGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    EmployeeData_Connection.Open();
                    SqlCommand command = new SqlCommand("Update EmployeeTableData Set EmployeeName=@EmpName, EmployeeAddress=@EmpAddress, EmployeePhone=@EmpPhone, EmployeeDateJoined=@EmpDateJ, EmployeeGender=@EmpGen, EmployeePassword=@EmpPass", EmployeeData_Connection);

                    command.Parameters.AddWithValue("@EmpName", EnterEmployeeNameTb.Text);
                    command.Parameters.AddWithValue("@EmpDateJ", EnterEmployeeDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@EmpPhone", EnterEmployeePhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@EmpAddress", EnterEmployeeAddressTb.Text);
                    command.Parameters.AddWithValue("@EmpGen", SelectEmployeeGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@EmpPass", EnterEmployeePasswordTb.Text);
                    command.Parameters.AddWithValue("@EmployeeKey", EmpKey);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    EmployeeData_Connection.Close();
                    ShowEmployees();
                    Reset_Employee_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void EmpToHSMLbl_Click(object sender, EventArgs e)
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }

        private void EmpToInvLbl_Click(object sender, EventArgs e)
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }

        private void EmpToCustLbl_Click(object sender, EventArgs e)
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }

        private void EmpToManufactLbl_Click(object sender, EventArgs e)
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
