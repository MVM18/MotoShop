using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoShop
{
	public partial class ReportsControl : UserControl
	{
		private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb";

		public ReportsControl()
		{
			InitializeComponent();
		}
		private void LoadSalesReport(string filterType)
		{
			using (OleDbConnection conn = new OleDbConnection(connString))
			{
				try
				{
					conn.Open();
					string query = "SELECT Inventory.ProductName, Inventory.Brand, Inventory.Transmission, " +
								   "Inventory.Price, Inventory.Model, Sold.Quantity, Sold.TotalPrice, " +
								   "Users.Name, Users.Address, Users.Number, Sold.PurchaseDate " +
								   "FROM Users " +
								   "INNER JOIN (Inventory INNER JOIN Sold ON Inventory.ProductID = Sold.ProductID) " +
								   "ON Users.UserID = Sold.UserID WHERE ";

					// Apply the date filter based on the selected report type
					if (filterType == "Weekly")
						query += "Sold.PurchaseDate >= Date()-7";
					else if (filterType == "Monthly")
						query += "Sold.PurchaseDate >= Date()-30";
					else if (filterType == "Yearly")
						query += "Sold.PurchaseDate >= Date()-365";

					using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dgvReports.DataSource = dt; // Assuming you have a DataGridView named dgvReports
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading sales report: " + ex.Message);
				}
			}
		}

		private void btnWeekly_Click(object sender, EventArgs e)
		{
			LoadSalesReport("Weekly");
		}
	

		private void btnMonthly_Click(object sender, EventArgs e)
		{
			LoadSalesReport("Monthly");
		}

		private void btnYearly_Click(object sender, EventArgs e)
		{
			LoadSalesReport("Yearly");
		}
	}
}
