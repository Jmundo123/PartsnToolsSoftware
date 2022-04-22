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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            ShowInventory();
            GetManufacturer();
        }
        SqlConnection InventoryData_Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jesus\Documents\PartsnToolsDatabaseServer.mdf;Integrated Security=True;Connect Timeout=30"); //Connecting to DataBase connection. The variable can be named anything.

        private void ShowInventory() //Connecting database to get information from the InventoryTableData
        {
            InventoryData_Connection.Open(); //Opening connection to "PartsnToolsDatabaseServer.mdf" database.
            string Inventory_Query = "Select * from InventoryTableData"; //Getting data from InventoryTableData.
            SqlDataAdapter InvSDataAdapter = new SqlDataAdapter(Inventory_Query, InventoryData_Connection); // Initializes Data from Database "PartsnToolsDatabaseServer.mdf" in InventoryTableData.
            SqlCommandBuilder Inv_Builder = new SqlCommandBuilder(InvSDataAdapter);
            var Inv_DataSet = new DataSet();
            InvSDataAdapter.Fill(Inv_DataSet);
            InventoryGridData.DataSource = Inv_DataSet.Tables[0];
            InventoryData_Connection.Close();  

        }
        private void Reset_Inventory_Input_Info()
        {
            EnterItemNameTb.Text = "";
            EnterItemQuantityTb.Text = "";
            EnterItemPriceTb.Text = "";
            DisplayManufacturerNameTb.Text = "";
            EnterItemTypeCb.SelectedIndex = 0;
            InvKey = 0;



        }
        private void GetManufacturer()
        {
            InventoryData_Connection.Open();
            SqlCommand command = new SqlCommand("Select ManufacturerNumber from ManufacturerTableData", InventoryData_Connection);
            SqlDataReader sDataReader;
            sDataReader = command.ExecuteReader();
            DataTable InvTableData = new DataTable();
            InvTableData.Columns.Add("ManufacturerNumber", typeof(int));
            InvTableData.Load(sDataReader);
            ItemManufacturerNumberCb.ValueMember = "ManufacturerNumber";
            ItemManufacturerNumberCb.DataSource = InvTableData;
            InventoryData_Connection.Close();
        }
        private void GetManufacturerName()
        {
            InventoryData_Connection.Open();
            string Inventory_Query = "Select * from ManufacturerTableData where ManufacturerNumber= '" + ItemManufacturerNumberCb.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(Inventory_Query, InventoryData_Connection);
            DataTable InvTableData = new DataTable();
            SqlDataAdapter InvSDataAdapter = new SqlDataAdapter(command);
            InvSDataAdapter.Fill(InvTableData);
            foreach (DataRow InvDataRow in InvTableData.Rows)
            {
                DisplayManufacturerNameTb.Text = InvDataRow["ManufacturerName"].ToString();
            }
            InventoryData_Connection.Close();
        }

        private void PartNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayManufacturerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void ItemManufacturerNumberCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InventorySaveButton_Click(object sender, EventArgs e)
        {
            if (EnterItemNameTb.Text == "" || EnterItemQuantityTb.Text == "" || EnterItemPriceTb.Text == "" || EnterItemTypeCb.SelectedIndex == -1 || ItemManufacturerNumberCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    InventoryData_Connection.Open();
                    SqlCommand command = new SqlCommand("insert into InventoryTableData(ItemName, ItemType, ItemQuantity, ItemPrice, ItemManufacturerNumber, ItemManufacturerName)values(@Item_Name, @Item_Type, @ItemQty, @Item_Price, @ItemManNum, @ItemManName)", InventoryData_Connection);
                    command.Parameters.AddWithValue("@Item_Name", EnterItemNameTb.Text);
                    command.Parameters.AddWithValue("@Item_Type", EnterItemTypeCb.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ItemQty", EnterItemQuantityTb.Text);
                    command.Parameters.AddWithValue("@Item_Price", EnterItemPriceTb.Text);
                    command.Parameters.AddWithValue("@ItemManNum", ItemManufacturerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ItemManName", DisplayManufacturerNameTb.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Added");
                    InventoryData_Connection.Close();
                    ShowInventory();
                    Reset_Inventory_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }

        private void ItemManufacturerNumberCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetManufacturerName();
        }
        int InvKey = 0;

        private void InventoryGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)//Stopped here
        {
            EnterItemNameTb.Text = InventoryGridData.SelectedRows[0].Cells[1].Value.ToString();
            EnterItemTypeCb.SelectedItem = InventoryGridData.SelectedRows[0].Cells[2].Value.ToString();
            EnterItemQuantityTb.Text = InventoryGridData.SelectedRows[0].Cells[3].Value.ToString();
            EnterItemPriceTb.Text = InventoryGridData.SelectedRows[0].Cells[4].Value.ToString();
            ItemManufacturerNumberCb.SelectedValue = InventoryGridData.SelectedRows[0].Cells[5].Value.ToString();
            DisplayManufacturerNameTb.Text = InventoryGridData.SelectedRows[0].Cells[6].Value.ToString();

            if (EnterItemNameTb.Text == "")
            {
                InvKey = 0;
            }
            else 
            {
            InvKey = Convert.ToInt32(InventoryGridData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void InventoryDeleteButton_Click(object sender, EventArgs e)
        {
            if (InvKey == 0)
            {
                MessageBox.Show("Select Item");
            }
            else
            {
                try
                {
                    InventoryData_Connection.Open();
                    SqlCommand command = new SqlCommand("Delete from InventoryTableData where ItemNumber=@ItemNumKey", InventoryData_Connection);
                    command.Parameters.AddWithValue("@ItemNumKey", InvKey);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted");
                    InventoryData_Connection.Close();
                    ShowInventory();
                    Reset_Inventory_Input_Info();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void InventoryEditButton_Click(object sender, EventArgs e)
        {
            if (EnterItemNameTb.Text == "" || EnterItemQuantityTb.Text == "" || EnterItemPriceTb.Text == "" || EnterItemTypeCb.SelectedIndex == -1 || ItemManufacturerNumberCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    InventoryData_Connection.Open();
                    SqlCommand command = new SqlCommand("Update InventoryTableData set ItemName=@Item_Name, ItemType=@Item_Type, ItemQuantity=@ItemQty, ItemPrice=@Item_Price,ItemManufacturerNumber=@ItemManNum, ItemManufacturerName=@ItemManName where ItemNumber=@ItemNumKey", InventoryData_Connection);
                    command.Parameters.AddWithValue("@Item_Name", EnterItemNameTb.Text);
                    command.Parameters.AddWithValue("@Item_Type", EnterItemTypeCb.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ItemQty", EnterItemQuantityTb.Text);
                    command.Parameters.AddWithValue("@Item_Price", EnterItemPriceTb.Text);
                    command.Parameters.AddWithValue("@ItemManNum", ItemManufacturerNumberCb.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@ItemManName", DisplayManufacturerNameTb.Text);
                    command.Parameters.AddWithValue("@ItemNumKey", InvKey);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Inventory Updated");
                    InventoryData_Connection.Close();
                    ShowInventory();
                    Reset_Inventory_Input_Info();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void InvtoHomeScreenMenuLbl_Click(object sender, EventArgs e)
        {
            HomeScreenMenu GotoHomeScreenMenu = new HomeScreenMenu();
            GotoHomeScreenMenu.Show();
            this.Hide();
        }

        private void InvtoCustLabel_Click(object sender, EventArgs e)
        {
            Customers GotoCustomers = new Customers();
            GotoCustomers.Show();
            this.Hide();
        }

        private void InvtoManufactLabel_Click(object sender, EventArgs e)
        {
            Manufacturers GotoManufacturers = new Manufacturers();
            GotoManufacturers.Show();
            this.Hide();
        }

        private void InvtoEmpLabel_Click(object sender, EventArgs e)
        {
            Employees GotoEmployees = new Employees();
            GotoEmployees.Show();
            this.Hide();
        }

        private void InvtoLoginScreenLbl_Click(object sender, EventArgs e)
        {
            UserLogin LogoutToUser = new UserLogin();
            LogoutToUser.Show();
            this.Hide();
        }
    }
}
