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
            InitializeComponent();
            ShowCustomers();
        }
        SqlConnection CustomerData_Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowCustomers()
        {
            CustomerData_Connect.Open();
            string Customer_Query = "Select * from CustomerTableData";
            SqlDataAdapter Cust_SDataAdapter = new SqlDataAdapter(Customer_Query, CustomerData_Connect);
            SqlCommandBuilder Cust_Builder = new SqlCommandBuilder(Cust_SDataAdapter);
            var Cust_DataSet = new DataSet();
            Cust_SDataAdapter.Fill(Cust_DataSet);
            CustomerGridData.DataSource = Cust_DataSet.Tables[0];
            CustomerData_Connect.Close();
        }
        private void Reset_Customer_Input_Info()
        {
            EnterCustomerNameTb.Text = "";
            EnterCustomerAddressTb.Text = "";
            SelectCustomerGender.SelectedIndex = 0;
            EnterCustomerPhoneNumberTb.Text = "";
        }
        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void CustSaveButton_Click(object sender, EventArgs e)
        {
            if (EnterCustomerNameTb.Text == "" || EnterCustomerAddressTb.Text == "" || EnterCustomerPhoneNumberTb.Text == "" || SelectCustomerGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    CustomerData_Connect.Open();
                    SqlCommand command = new SqlCommand("insert into CustomerTableData(CustName, CustPhone, CustAddress, Cust_DateJoined, CustGender)values(@Cust_Name, @Cust_Phone, @Cust_Address, @Cust_DateJ,@Cust_Gender)", CustomerData_Connect);

                    command.Parameters.AddWithValue("@Cust_Name", EnterCustomerNameTb.Text);
                    command.Parameters.AddWithValue("@Cust_Phone", EnterCustomerPhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@Cust_Address", EnterCustomerAddressTb.Text);
                    command.Parameters.AddWithValue("@Cust_DateJ", CustomerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@Cust_Gender", SelectCustomerGender.SelectedItem.ToString());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Added");
                    CustomerData_Connect.Close();
                    ShowCustomers();
                    Reset_Customer_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        int CustKey = 0;
        private void CustomerGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnterCustomerNameTb.Text = CustomerGridData.SelectedRows[0].Cells[1].Value.ToString();
            EnterCustomerPhoneNumberTb.Text = CustomerGridData.SelectedRows[0].Cells[2].Value.ToString();
            EnterCustomerAddressTb.Text = CustomerGridData.SelectedRows[0].Cells[3].Value.ToString();
            CustomerDateJoined.Text = CustomerGridData.SelectedRows[0].Cells[4].Value.ToString();
            SelectCustomerGender.SelectedItem = CustomerGridData.SelectedRows[0].Cells[5].Value.ToString();

            if (EnterCustomerNameTb.Text == "")
            {
                CustKey = 0;
            }
            else 
            {
            CustKey = Convert.ToInt32(CustomerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CustDeleteButton_Click(object sender, EventArgs e)
        {
            if (CustKey == 0)
            {
                MessageBox.Show("Select Customer");
            }
            else
            {
                try
                {
                    CustomerData_Connect.Open();
                    SqlCommand command = new SqlCommand("Delete from CustomerTableData where CustNumber=@CustNumKey", CustomerData_Connect);

                    command.Parameters.AddWithValue("@CustNumKey", CustKey);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");
                    CustomerData_Connect.Close();
                    ShowCustomers();
                    Reset_Customer_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void CustEditButton_Click(object sender, EventArgs e)
        {
            if (EnterCustomerNameTb.Text == "" || EnterCustomerAddressTb.Text == "" || EnterCustomerPhoneNumberTb.Text == "" || SelectCustomerGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    CustomerData_Connect.Open();
                    SqlCommand command = new SqlCommand("Update CustomerTableData set CustName=@Cust_Name, CustPhone=@Cust_Phone, CustAddress=@Cust_Address, Cust_DateJoined=@Cust_DateJ, CustGender=@Cust_Gender where CustNumber=@CustNumKey", CustomerData_Connect);

                    command.Parameters.AddWithValue("@Cust_Name", EnterCustomerNameTb.Text);
                    command.Parameters.AddWithValue("@Cust_Phone", EnterCustomerPhoneNumberTb.Text);
                    command.Parameters.AddWithValue("@Cust_Address", EnterCustomerAddressTb.Text);
                    command.Parameters.AddWithValue("@Cust_DateJ", CustomerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@Cust_Gender", SelectCustomerGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@CustNumKey", CustKey);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated");
                    CustomerData_Connect.Close();
                    ShowCustomers();
                    Reset_Customer_Input_Info();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            
            }
        }

        private void CustToHSMLbl_Click(object sender, EventArgs e)
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }

        private void CustToInvLbl_Click(object sender, EventArgs e)
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }

        private void CustToManufactLbl_Click(object sender, EventArgs e)
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }

        private void CustToEmpLbl_Click(object sender, EventArgs e)
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }

        private void CustToLogInSLbl_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
