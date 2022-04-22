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
            CountInventory();
            CountEmployees();
            CountCustomers();
            SalesTotalAmount();
            SelectEmployeeSalesInfo();
            //SalesTotalAmountByEmployee();
            BestEmployee();
            BestCustomer();
        }
        SqlConnection HomeScreen_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");

        private void CountInventory() /*correct*/
        {
            HomeScreen_Connection.Open();
            SqlDataAdapter Inventory_DataAdpater = new SqlDataAdapter("Select Count(*) from InventoryTableData", HomeScreen_Connection);
            DataTable Inventory_DataTable = new DataTable();
            Inventory_DataAdpater.Fill(Inventory_DataTable);
            InventoryCountLabel.Text = Inventory_DataTable.Rows[0][0].ToString();
            HomeScreen_Connection.Close();
        }
        private void CountEmployees()/*correct*/
        {
            HomeScreen_Connection.Open();
            SqlDataAdapter Employee_DataAdpater = new SqlDataAdapter("Select Count(*) from EmployeeTableData", HomeScreen_Connection);
            DataTable Employee_DataTable = new DataTable();
            Employee_DataAdpater.Fill(Employee_DataTable);
            EmployeeCountLabel.Text = Employee_DataTable.Rows[0][0].ToString();
            HomeScreen_Connection.Close();
        }
        private void CountCustomers() /*correct*/
        {
            HomeScreen_Connection.Open();
            SqlDataAdapter Customers_DataAdpater = new SqlDataAdapter("Select Count(*) from CustomerTableData", HomeScreen_Connection);
            DataTable Customers_DataTable = new DataTable();
            Customers_DataAdpater.Fill(Customers_DataTable);
            CustomerCountLabel.Text = Customers_DataTable.Rows[0][0].ToString();
            HomeScreen_Connection.Close();
        }

        private void SalesTotalAmount() /*edited to Sum*/
        {
            HomeScreen_Connection.Open();
            SqlDataAdapter SalesTotalAmount_DataAdpater = new SqlDataAdapter("Select Sum(TransactionAmount) from TransactionTableData", HomeScreen_Connection);
            DataTable SalesTotalAmount_DataTable = new DataTable();
            SalesTotalAmount_DataAdpater.Fill(SalesTotalAmount_DataTable);
            SalesTotalAmountLabel.Text = "         $" + SalesTotalAmount_DataTable.Rows[0][0].ToString();
            HomeScreen_Connection.Close();

        }

        private void SalesTotalAmountByEmployee() /*Correct*/
        {
            HomeScreen_Connection.Open();
            SqlDataAdapter STAE_DataAdapter = new SqlDataAdapter("Select Sum(TransactionAmount) from TransactionTableData where EmployeeName='"+ SelectEmployeeSalesInfoCb.SelectedValue.ToString() + "'", HomeScreen_Connection);
            DataTable STAE_DataTable = new DataTable();
            STAE_DataAdapter.Fill(STAE_DataTable);
            SalesByEmployeeLabel.Text = "         $" + STAE_DataTable.Rows[0][0].ToString();
            HomeScreen_Connection.Close();
        }
        private void BestEmployee()
        {
            try
            {
                HomeScreen_Connection.Open();
                String BestEmployee_Query = "Select Max(TransactionAmount) from TransactionTableData";
                DataTable BestEmployee_DataTable = new DataTable();
                SqlDataAdapter BestEmployee_DataAdapter = new SqlDataAdapter(BestEmployee_Query, HomeScreen_Connection);
                BestEmployee_DataAdapter.Fill(BestEmployee_DataTable);

                string BEmployee_Query = "Select EmployeeName from TransactionTableData where TransactionAmount = '" + BestEmployee_DataTable.Rows[0][0].ToString() + "'";
                SqlDataAdapter BEmployee_DataAdapter = new SqlDataAdapter(BEmployee_Query, HomeScreen_Connection);
                DataTable BEmployee_DataTable = new DataTable();
                BEmployee_DataAdapter.Fill(BEmployee_DataTable);
                BestEmployeeLabel.Text = BEmployee_DataTable.Rows[0][0].ToString();
                HomeScreen_Connection.Close();
            }
            catch (Exception exception)
            {
                HomeScreen_Connection.Close();
            }    
        }

        private void BestCustomer()
        {
            try
            {
                HomeScreen_Connection.Open();
                String BestCustomer_Query = "Select Max(TransactionAmount) from TransactionTableData";
                DataTable BestCustomer_DataTable = new DataTable();
                SqlDataAdapter BestCustomer_DataAdapter = new SqlDataAdapter(BestCustomer_Query, HomeScreen_Connection);
                BestCustomer_DataAdapter.Fill(BestCustomer_DataTable);

                string BCustomer_Query = "Select CustName from TransactionTableData where TransactionAmount = '" + BestCustomer_DataTable.Rows[0][0].ToString() + "'";
                SqlDataAdapter BCustomer_DataAdapter = new SqlDataAdapter(BCustomer_Query, HomeScreen_Connection);
                DataTable BCustomer_DataTable = new DataTable();
                BCustomer_DataAdapter.Fill(BCustomer_DataTable);
                BestCustomerLabel.Text = BCustomer_DataTable.Rows[0][0].ToString();
                HomeScreen_Connection.Close();
            }
            catch (Exception exception)
            {
                HomeScreen_Connection.Close();
            }
        
        }
        private void SelectEmployeeSalesInfo()
        {
            HomeScreen_Connection.Open();
            SqlCommand command = new SqlCommand("Select EmployeeName from EmployeeTableData", HomeScreen_Connection);
            SqlDataReader Employee_DataReader;
            Employee_DataReader = command.ExecuteReader();
            DataTable Employee_DataTable = new DataTable();
            Employee_DataTable.Columns.Add("EmployeeName", typeof(string));
            Employee_DataTable.Load(Employee_DataReader);
            SelectEmployeeSalesInfoCb.ValueMember = "EmployeeName";
            SelectEmployeeSalesInfoCb.DataSource = Employee_DataTable;
            HomeScreen_Connection.Close();
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

        private void SelectEmployeeSalesInfoCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SalesTotalAmountByEmployee();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }

        private void InventoryMenuLabel_Click(object sender, EventArgs e)
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }

        private void CustomerMenuLabel_Click(object sender, EventArgs e)
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }

        private void ManufacturersMenuLabel_Click(object sender, EventArgs e)
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }

        private void EmployeesMenuLabel_Click(object sender, EventArgs e)
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }
    }
}
