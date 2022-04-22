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
        SqlConnection ManufacturerData_Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowManufacturer()
        {
            ManufacturerData_Connect.Open();
            string Manufacturer_Query = "Select * from ManufacturerTableData";
            SqlDataAdapter ManuSdataAdapter = new SqlDataAdapter(Manufacturer_Query, ManufacturerData_Connect);
            SqlCommandBuilder ManBuilder = new SqlCommandBuilder(ManuSdataAdapter);
            var Mdataset = new DataSet();
            ManuSdataAdapter.Fill(Mdataset);
            ManufacturerGridData.DataSource = Mdataset.Tables[0];
            ManufacturerData_Connect.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ManufacturerSaveButton_Click(object sender, EventArgs e)
        {
            if (EnterManufacturerNameTb.Text == "" || EnterManufacturerAddressTb.Text == "" || EnterManufacturerPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                try
                {
                    ManufacturerData_Connect.Open();
                    SqlCommand command = new SqlCommand("insert into ManufacturerTableData(ManufacturerName, ManufacturerAddress, ManufacturerPhone, ManufacturerDateJoin)values(@ManName,@ManAdd,@ManPhone,@ManDJoin)", ManufacturerData_Connect);

                    command.Parameters.AddWithValue("@ManName", EnterManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ManAdd", EnterManufacturerAddressTb.Text);
                    command.Parameters.AddWithValue("@ManPhone", EnterManufacturerPhoneTb.Text);
                    command.Parameters.AddWithValue("ManDJoin", ManufacturerDateJoined.Value.Date);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Added");
                    ManufacturerData_Connect.Close();
                    ShowManufacturer();
                    Reset_Manufacturer_Input_Info();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
        int Mankey = 0;
        private void Manufacturers_Load(object sender, EventArgs e)
        {

        }

        private void EnterManufacturerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManufacturerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnterManufacturerNameTb.Text = ManufacturerGridData.SelectedRows[0].Cells[1].Value.ToString();
            EnterManufacturerAddressTb.Text = ManufacturerGridData.SelectedRows[0].Cells[2].Value.ToString();
            EnterManufacturerPhoneTb.Text = ManufacturerGridData.SelectedRows[0].Cells[3].Value.ToString();
            ManufacturerDateJoined.Text = ManufacturerGridData.SelectedRows[0].Cells[4].Value.ToString();
            if (EnterManufacturerNameTb.Text == " ")
            {
                Mankey = 0;
            }
            else 
            {
                Mankey = Convert.ToInt32(ManufacturerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }



        }

        private void ManufacturerDeleteButton_Click(object sender, EventArgs e)
        {
            if (Mankey == 0)
            {
                MessageBox.Show("Select the Manufacturer");
            }
            else
            {
                try
                {
                    ManufacturerData_Connect.Open();
                    SqlCommand command = new SqlCommand("Delete from ManufacturerTableData where ManufacturerNumber=@ManKey", ManufacturerData_Connect);

                    command.Parameters.AddWithValue("@Mankey", Mankey);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Deleted");

                    ManufacturerData_Connect.Close();
                    ShowManufacturer();
                    Reset_Manufacturer_Input_Info();
                }
                catch (Exception exception)
                { 
                    MessageBox.Show(exception.Message);
                }              
            }
        }

        private void Reset_Manufacturer_Input_Info()
        {
            EnterManufacturerNameTb.Text = "";
            EnterManufacturerAddressTb.Text = "";
            EnterManufacturerPhoneTb.Text = "";
            Mankey = 0;
        }

        private void ManufacturerEditButton_Click(object sender, EventArgs e)
        {
            if (EnterManufacturerNameTb.Text == "" || EnterManufacturerAddressTb.Text == "" || EnterManufacturerPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    ManufacturerData_Connect.Open();
                    SqlCommand command = new SqlCommand("Update ManufacturerTableData Set ManufacturerName=@ManName, ManufacturerAddress=@ManAdd, ManufacturerPhone=@ManPhone, ManufacturerDateJoin=@ManDJoin where ManufacturerNumber=@ManKey", ManufacturerData_Connect);
                    command.Parameters.AddWithValue("@ManName", EnterManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ManAdd", EnterManufacturerAddressTb.Text);
                    command.Parameters.AddWithValue("@ManPhone", EnterManufacturerPhoneTb.Text);
                    command.Parameters.AddWithValue("@ManDJoin", ManufacturerDateJoined.Value.Date);
                    command.Parameters.AddWithValue("@ManKey", Mankey);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Updated");
                    ManufacturerData_Connect.Close();
                    ShowManufacturer();
                    Reset_Manufacturer_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void ManufacturerGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnterManufacturerNameTb.Text = ManufacturerGridData.SelectedRows[0].Cells[1].Value.ToString();
            EnterManufacturerAddressTb.Text = ManufacturerGridData.SelectedRows[0].Cells[2].Value.ToString();
            EnterManufacturerPhoneTb.Text = ManufacturerGridData.SelectedRows[0].Cells[3].Value.ToString();
            ManufacturerDateJoined.Text = ManufacturerGridData.SelectedRows[0].Cells[4].Value.ToString();
            if (EnterManufacturerNameTb.Text == " ")
            {
                Mankey = 0;
            }
            else
            {
                Mankey = Convert.ToInt32(ManufacturerGridData.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void ManufactToHSMLbl_Click(object sender, EventArgs e)
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }

        private void ManufactToInvLbl_Click(object sender, EventArgs e)
        {
            Inventory GotoInventory = new Inventory();
            GotoInventory.Show();
            this.Hide();
        }

        private void ManufactToCustLbl_Click(object sender, EventArgs e)
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }

        private void ManufactToEmpLbl_Click(object sender, EventArgs e)
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }

        private void ListofManufacturers_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
