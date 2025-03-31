using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MotoShop
{
    public partial class Dashboard : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        DataSet ds;

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb";
        private int loggedInUserId;
        private string userRole;
        private ReportsControl reportsControl;


		public Dashboard()
        {
            InitializeComponent();
            userRole = "Admin";
            loggedInUserId = 0;
            panelMenu.Width = 100;
			reportsControl = new ReportsControl(); // ✅ Initialize it
			this.Load += AdminDashboard_Load;
        }

        public Dashboard(int userID, string role) // Pass role from login form
        {
            InitializeComponent();
            loggedInUserId = userID;
            userRole = role;
            panelMenu.Width = 100;
			reportsControl = new ReportsControl(); // ✅ Initialize it
			this.Load += AdminDashboard_Load;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
         
            CollapseMenu();
            btnProduct_Click(null, EventArgs.Empty);
            if (userRole == "User") // If user is NOT Admin
            {
                btnInventory.Visible = false;
                btnReports.Visible = false;
                btnUser.Visible = false;
                
            }
		}
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text.Trim());

        }
        private void SearchProducts(string searchText)
        {
            reportsControl.Visible = false;
			flowLayoutPanel1.Controls.Clear(); // Clear previous items

            string query;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                query = "SELECT ProductID, ProductName, Brand, Price, Model, Transmission, Description, Status, StockQuantity, ProductImage FROM Inventory";
            }
            else
            {
                query = "SELECT ProductID, ProductName, Brand, Price, Model, Transmission, Description, Status, StockQuantity, ProductImage " +
                        "FROM Inventory " +
                        "WHERE ProductName LIKE @Search OR Brand LIKE @Search OR Model LIKE @Search";
            }

            try
            {
                using (myConn = new OleDbConnection(connString))
                {
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchText))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                        }

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product productControl = new Product(loggedInUserId)
                                {
                                   
									nudQuantity = { Visible = false },
									lblPname = { Text = reader["ProductName"].ToString() },
                                    lblBrand = { Text = reader["Brand"].ToString() },
                                    lblModel = { Text = reader["Model"].ToString() },
                                    lblPrice = { Text = "₱" + Convert.ToDecimal(reader["Price"]).ToString("N2") },
                                   
								};
                                // Load and display the product image if available
                                if (!(reader["ProductImage"] is DBNull))
                                {
                                    byte[] imageData = (byte[])reader["ProductImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        productControl.pbProductPic.Image = Image.FromStream(ms); // Set image to pbImage
                                        productControl.pbProductPic.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size
                                    }
                                }
                                else
                                {
                                    productControl.pbProductPic.Image = null; // No image available
                                }

                                productControl.Tag = new ProductInfo
                                {
                                    ProductID = Convert.ToInt32(reader["ProductID"]),
                                    ProductName = reader["ProductName"].ToString(),
                                    Brand = reader["Brand"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    Transmission = reader["Transmission"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Status = reader["Status"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                                    ProductImage = reader["ProductImage"] is DBNull ? null : (byte[])reader["ProductImage"]
                                };

                                flowLayoutPanel1.Controls.Add(productControl);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
            {
                tbxSearch.Text = "Search";

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {

                panelMenu.Width = 100;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Width = 100;
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Width = 230;
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            reportsControl.Visible = false;
			btnEdit.Visible = false;
            dgvProduct.Controls.Clear();
            // Clear previous controls
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Show();
            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                string query = "SELECT ProductID, ProductName, Brand, Price, Model, Transmission, Description, Status, StockQuantity, ProductImage FROM Inventory";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                myConn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Create new ProductControl instance
                    Product productControl = new Product(loggedInUserId);
                   
                    // Populate the product user control
               
                    productControl.nudQuantity.Visible = false;
					productControl.lblPname.Text = reader["ProductName"].ToString();
                    productControl.lblBrand.Text = reader["Brand"].ToString();
                    productControl.lblModel.Text = reader["Model"].ToString();
                   // productControl.lblStock.Text = reader["StockQuantity"].ToString();
                    productControl.lblPrice.Text = "₱" + Convert.ToDecimal(reader["Price"]).ToString("N2");

                    // Store product details in Tag for later use
                    productControl.Tag = new ProductInfo
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                        ProductImage = reader["ProductImage"] is DBNull ? null : (byte[])reader["ProductImage"]
					};

                    // Load and display the product image if available
                    if (!(reader["ProductImage"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["ProductImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            productControl.pbProductPic.Image = Image.FromStream(ms); // Set image to pbImage
                            productControl.pbProductPic.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size
                        }
                    }
                    else
                    {
                        productControl.pbProductPic.Image = null; // No image available
                    }



                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(productControl);
                }

                reader.Close();
            }
        }
     

        private void btnCart_Click(object sender, EventArgs e)
        {
            reportsControl.Visible = false;
			btnEdit.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Show();

            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                string query = "SELECT Inventory.ProductID, Inventory.ProductName, Inventory.Brand, Inventory.Model, Inventory.Price, Inventory.Transmission, Inventory.Description, Inventory.Status,Inventory.StockQuantity, Cart.Quantity, Inventory.ProductImage " +
                               "FROM Inventory INNER JOIN Cart ON Inventory.[ProductID] = Cart.ProductID " +
                               "WHERE Cart.UserID = @UserID;";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                myConn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product productControl = new Product(loggedInUserId);

                    productControl.lblPname.Text = reader["ProductName"].ToString();
                    productControl.lblBrand.Text = reader["Brand"].ToString();
                    productControl.lblModel.Text = reader["Model"].ToString();
                    productControl.lblPrice.Text = "₱" + Convert.ToDecimal(reader["Price"]).ToString("N2");

					int storedQuantity = Convert.ToInt32(reader["Quantity"]); // Get saved quantity
					productControl.nudQuantity.Value = storedQuantity;
					productControl.nudQuantity.ValueChanged += (s, ev) =>
					{
						int newQuantity = (int)productControl.nudQuantity.Value;
						int productID = ((ProductInfo)productControl.Tag).ProductID;

						// Update quantity in the database
						UpdateCartQuantity(loggedInUserId, productID, newQuantity);
					};
					productControl.nudQuantity.Maximum = Convert.ToInt32(reader["StockQuantity"]);
					if (!(reader["ProductImage"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["ProductImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            productControl.pbProductPic.Image = Image.FromStream(ms);
                            productControl.pbProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        productControl.pbProductPic.Image = null; // No image available
                    }

                    productControl.Tag = new ProductInfo
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        StockQuantity = Convert.ToInt32(reader["Quantity"]),
                        ProductImage = reader["ProductImage"] is DBNull ? null : (byte[])reader["ProductImage"]
                    };


                    flowLayoutPanel1.Controls.Add(productControl);
                }

                reader.Close();
            }
        }
		private void UpdateCartQuantity(int userId, int productId, int newQuantity)
		{
			using (OleDbConnection myConn = new OleDbConnection(connString))
			{
				string query = "UPDATE Cart SET Quantity = @Quantity WHERE UserID = @UserID AND ProductID = @ProductID";
				using (OleDbCommand cmd = new OleDbCommand(query, myConn))
				{
					cmd.Parameters.AddWithValue("@Quantity", newQuantity);
					cmd.Parameters.AddWithValue("@UserID", userId);
					cmd.Parameters.AddWithValue("@ProductID", productId);

					myConn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		private void btnPurchase_Click(object sender, EventArgs e)
        {
            reportsControl.Visible = false;
			btnEdit.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Show();

            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
				/*string query = "SELECT Inventory.ProductID, Inventory.ProductName, Inventory.Brand, Inventory.Transmission, Inventory.Price, Inventory.Model, Inventory.Description, Inventory.Status, " +
                               "Sold.Quantity, Sold.TotalPrice, Users.Name, Users.Address, Users.Number, Sold.PurchaseDate, Inventory.ProductImage " +
                               "FROM Users INNER JOIN (Inventory INNER JOIN Sold ON Inventory.ProductID = Sold.ProductID) ON Users.UserID = Sold.UserID " +
                               "WHERE Sold.UserId = @UserID;";*/
				string query;

				// Admin sees all purchases, User sees only their own
				if (userRole == "Admin")
				{
					query = "SELECT Inventory.ProductID, Inventory.ProductName, Inventory.Brand, Inventory.Transmission, Inventory.Price, Inventory.Model, " +
							"Inventory.Description, Inventory.Status, Sold.Quantity, Sold.TotalPrice, Users.Name, Users.Address, Users.Number, Sold.PurchaseDate, Inventory.ProductImage " +
							"FROM Users INNER JOIN (Inventory INNER JOIN Sold ON Inventory.ProductID = Sold.ProductID) ON Users.UserID = Sold.UserID;";
				}
				else // Regular user
				{
					query = "SELECT Inventory.ProductID, Inventory.ProductName, Inventory.Brand, Inventory.Transmission, Inventory.Price, Inventory.Model, " +
							"Inventory.Description, Inventory.Status, Sold.Quantity, Sold.TotalPrice, Users.Name, Users.Address, Users.Number, Sold.PurchaseDate, Inventory.ProductImage " +
							"FROM Users INNER JOIN (Inventory INNER JOIN Sold ON Inventory.ProductID = Sold.ProductID) ON Users.UserID = Sold.UserID " +
							"WHERE Sold.UserId = @UserID;";
				}

				OleDbCommand cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                myConn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product productControl = new Product(loggedInUserId);

                    // Set product details
                    productControl.lblPname.Text = reader["ProductName"].ToString();
                    productControl.lblBrand.Text = reader["Brand"].ToString();
                    productControl.lblModel.Text = reader["Model"].ToString();
                    productControl.lblPrice.Text = "₱" + Convert.ToDecimal(reader["Price"]).ToString("N2");
					productControl.nudQuantity.Value = Convert.ToInt32(reader["Quantity"]);
                    productControl.nudQuantity.Enabled = false; // Disable quantity control

					// Load product image
					if (!(reader["ProductImage"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["ProductImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            productControl.pbProductPic.Image = Image.FromStream(ms);
                            productControl.pbProductPic.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        productControl.pbProductPic.Image = null; // No image available
                    }

                    // Store purchase info in the tag (can be used later if needed)
                    productControl.Tag = new ProductInfo
                    {
                       
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        StockQuantity = Convert.ToInt32(reader["Quantity"]),
                        ProductImage = reader["ProductImage"] is DBNull ? null : (byte[])reader["ProductImage"]

                    };

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(productControl);
                }

                reader.Close();
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
			/*btnEdit.Visible = false;
			flowLayoutPanel1.Visible = false;
			flowLayoutPanel1.Controls.Clear();
			myConn = new OleDbConnection(connString);
			da = new OleDbDataAdapter("SELECT [ServiceRequest].UserID, [ServiceRequest].ProductId, [ServiceRequest].ServiceType, [ServiceRequest].RequestDate, [ServiceRequest].Status\r\nFROM ServiceRequest;\r\n", myConn);
			ds = new DataSet();
			myConn.Open();
			da.Fill(ds, "ServiceRequest");
			dgvProduct.DataSource = ds.Tables["ServiceRequest"];
			myConn.Close();*/
            reportsControl.Visible = false;
			btnEdit.Visible = false;
			flowLayoutPanel1.Controls.Clear();
			flowLayoutPanel1.Show();

			using (OleDbConnection myConn = new OleDbConnection(connString))
			{
				string query;

				if (userRole == "Admin")
				{
					query = "SELECT * FROM ServiceRequest"; // Admin sees all requests
				}
				else
				{
					query = "SELECT * FROM ServiceRequest WHERE UserID = @UserID"; // User sees only their requests
				}

				OleDbCommand cmd = new OleDbCommand(query, myConn);
				if (userRole != "Admin")
				{
					cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
				}

				myConn.Open();
				OleDbDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					// Display service request information
					ServiceControl serviceControl = new ServiceControl();
					serviceControl.lblServiceType.Text = reader["ServiceType"].ToString();
					//serviceControl.lblProduct.Text = reader["Product"].ToString();
					//serviceControl.lblIssue.Text = reader["IssueDescription"].ToString();
					serviceControl.lblServiceDate.Text = Convert.ToDateTime(reader["RequestDate"]).ToString("yyyy-MM-dd");
                    serviceControl.lblStatus.Text= reader["Status"].ToString();

					flowLayoutPanel1.Controls.Add(serviceControl);
				}

				reader.Close();
			}

		}

        private void btnInventory_Click(object sender, EventArgs e)
        {
            reportsControl.Visible = false;
			flowLayoutPanel1.Controls.Clear();
            btnEdit.Visible = true;
            flowLayoutPanel1.Show();
           

            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                string query = "SELECT ProductID, ProductName, Brand, Price, Model, Transmission, Description, Status, StockQuantity, ProductImage FROM Inventory";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                myConn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product productControl = new Product(loggedInUserId);

                    productControl.lblPname.Text = reader["ProductName"].ToString();
                    productControl.lblBrand.Text = reader["Brand"].ToString();
                    productControl.lblModel.Text = reader["Model"].ToString();
                    productControl.lblPrice.Text = "₱" + Convert.ToDecimal(reader["Price"]).ToString("N2");
                    productControl.nudQuantity.Value = Convert.ToInt32(reader["StockQuantity"]);
                    productControl.nudQuantity.Enabled = false; // Enable quantity control
															   // Load and display the product image if available
					if (!(reader["ProductImage"] is DBNull))
                    {
                        byte[] imageData = (byte[])reader["ProductImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            productControl.pbProductPic.Image = Image.FromStream(ms); // Set image to pbImage
                            productControl.pbProductPic.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size
                        }
                    }
                    else
                    {
                        productControl.pbProductPic.Image = null; // No image available
                    }
                    productControl.Tag = new ProductInfo
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Model = reader["Model"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                        ProductImage = reader["ProductImage"] is DBNull ? null : (byte[])reader["ProductImage"]
                    };

                    flowLayoutPanel1.Controls.Add(productControl);
                }

                reader.Close();
            }

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           
			reportsControl.Visible = false;
			btnEdit.Visible = false;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel1.Controls.Clear();
			myConn = new OleDbConnection(connString);
            da = new OleDbDataAdapter("SELECT [Users].UserID, [Users].Name, [Users].Address, [Users].Number, [Users].Email, [Users].Username\r\nFROM Users;\r\n", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Users");
            dgvProduct.DataSource = ds.Tables["Users"];
            myConn.Close();
			dgvProduct.Visible = true;
		}

        private void btnReports_Click(object sender, EventArgs e)
        {
			reportsControl.Visible = true;
			reportsControl.Dock = DockStyle.Fill;

			panelContainer.Controls.Add(reportsControl);

			// Hide other controls
			dgvProduct.Visible = false;
			dgvProduct.Controls.Clear();
			flowLayoutPanel1.Visible = false;
			flowLayoutPanel1.Controls.Clear();
			

		}

        private void btnLogout_Click(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();

            loginForm.Show();

            this.Hide();
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text.Trim());

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Modify modifyForm = new Modify();
            modifyForm.ShowDialog();
        }
    }
}

