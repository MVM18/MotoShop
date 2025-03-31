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
    public partial class Product : UserControl
    {
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb";
        public int LoggedInUserId { get; set; }
        public event EventHandler<ProductInfo> ProductClicked;

        public Product(int loggedInUserId)
        {
            InitializeComponent();
            LoggedInUserId = loggedInUserId;
            ContextMenuStrip = cmProduct;
            AttachDoubleClickEvent(this);
        }
        private void AttachDoubleClickEvent(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.DoubleClick += (sender, e) => Product_DoubleClick(parent, e);
                AttachDoubleClickEvent(child); // Recursively apply to all children
            }
        }

		private void cmsCart_Click(object sender, EventArgs e)
        {
            if (this.Tag is ProductInfo productInfo)
            {
                AddToCart(productInfo);
            }

        }

        public void AddToCart(ProductInfo product)
        {
            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                myConn.Open();

                // Check if the product is already in the cart
                string checkQuery = "SELECT Quantity FROM Cart WHERE UserID = @UserID AND ProductID = @ProductID";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                {
                    checkCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
                    checkCmd.Parameters.AddWithValue("@ProductID", product.ProductID);

                    object result = checkCmd.ExecuteScalar();
					int selectedQuantity = (int)nudQuantity.Value;
					if (result != null) // Product exists in cart
                    {
                        int existingQuantity = Convert.ToInt32(result);
                        int newQuantity = existingQuantity + selectedQuantity;
                        decimal newTotalPrice = newQuantity * product.Price;

                        // Update quantity in the cart
                        string updateQuery = "UPDATE Cart SET Quantity = @Quantity, TotalPrice = @TotalPrice WHERE UserID = @UserID AND ProductID = @ProductID";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, myConn))
                        {
                            updateCmd.Parameters.AddWithValue("@Quantity", newQuantity);
                            updateCmd.Parameters.AddWithValue("@TotalPrice", newTotalPrice);
                            updateCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
                            updateCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else // Product is not in cart, insert new record
                    {
                        decimal totalPrice = selectedQuantity * product.Price;
                        string insertQuery = "INSERT INTO Cart (UserID, ProductID, Quantity, TotalPrice) VALUES (@UserID, @ProductID, @Quantity, @TotalPrice)";
                        using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, myConn))
                        {
                            insertCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
                            insertCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                            insertCmd.Parameters.AddWithValue("@Quantity", selectedQuantity);
                            insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            MessageBox.Show("Product added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cmsBuy_Click(object sender, EventArgs e)
        {
            if (this.Tag is ProductInfo productInfo)
            {
                CheckoutProduct(productInfo);
            }
            else
            {
                MessageBox.Show("Error: Product details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CheckoutProduct(ProductInfo product)
        {
            using (OleDbConnection myConn = new OleDbConnection(connString))
            {
                myConn.Open();
                OleDbTransaction transaction = myConn.BeginTransaction(); // Start transaction

                try
                {
                    // Step 1: Check product stock before processing purchase
                    string stockQuery = "SELECT StockQuantity FROM Inventory WHERE ProductID = @ProductID";
                    using (OleDbCommand stockCmd = new OleDbCommand(stockQuery, myConn, transaction))
                    {
                        stockCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                        int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                        if (stock <= 0)
                        {
                            MessageBox.Show("Product is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Step 2: Retrieve quantity and total price from the cart
                    string cartQuery = "SELECT Quantity, TotalPrice FROM Cart WHERE UserID = @UserID AND ProductID = @ProductID";
                    using (OleDbCommand cartCmd = new OleDbCommand(cartQuery, myConn, transaction))
                    {
                        cartCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
                        cartCmd.Parameters.AddWithValue("@ProductID", product.ProductID);

                        using (OleDbDataReader reader = cartCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int quantity = reader.GetInt32(0);
                                decimal totalPrice = quantity * product.Price;

								// Step 3: Insert the purchased product into the "Sold" table
								string purchaseQuery = "INSERT INTO Sold ([UserID], [ProductID], [Quantity], [TotalPrice], [PurchaseDate]) VALUES (@UserID, @ProductID, @Quantity, @TotalPrice, @PurchaseDate)";
                                using (OleDbCommand purchaseCmd = new OleDbCommand(purchaseQuery, myConn, transaction))
                                {

                                    purchaseCmd.Parameters.Add("@UserID", OleDbType.Integer).Value = LoggedInUserId;
                                    purchaseCmd.Parameters.Add("@ProductID", OleDbType.Integer).Value = product.ProductID;
                                    purchaseCmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = quantity;
									purchaseCmd.Parameters.Add("@TotalPrice", OleDbType.Currency).Value = totalPrice;
									purchaseCmd.Parameters.Add("@PurchaseDate", OleDbType.Date).Value = DateTime.Now; // Ensure Date/Time

                                    purchaseCmd.ExecuteNonQuery();
                                }

                                // Step 4: Reduce stock in Inventory
                                string updateStockQuery = "UPDATE Inventory SET StockQuantity = StockQuantity - @Quantity WHERE ProductID = @ProductID";
                                using (OleDbCommand updateStockCmd = new OleDbCommand(updateStockQuery, myConn, transaction))
                                {
                                    updateStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                                    updateStockCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                                    updateStockCmd.ExecuteNonQuery();
                                }

                                // Step 5: Remove the product from the cart after purchase
                                string deleteQuery = "DELETE FROM Cart WHERE UserID = @UserID AND ProductID = @ProductID";
                                using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn, transaction))
                                {
                                    deleteCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
                                    deleteCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                                    deleteCmd.ExecuteNonQuery();
                                }
								// Step 6: Ask if user wants installation
								DialogResult result = MessageBox.Show("Do you want installation for this product?", "Service Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result == DialogResult.Yes)
								{
									AddServiceRequest(product.ProductID);
								}

								// Step 7: Commit the transaction
								transaction.Commit();
                                MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Product not found in cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback in case of error
                    MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Product_DoubleClick(object sender, EventArgs e)
        {
            // Get the product details from the Tag property
            Product productControl = sender as Product;
            if (productControl != null && productControl.Tag is ProductInfo product)
            {
                ProductForm productForm = new ProductForm(product,LoggedInUserId);
                productForm.ShowDialog(); // Open product info form
            }
        }

       /* private void cmsService_Click(object sender, EventArgs e)
        {
            // Check if Form1 is already open
            Form1 parentForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (parentForm == null)
            {
                // If not open, create a new instance
                parentForm = new Form1();
            }

            // Show the form and bring it to the front
            parentForm.Show();
            parentForm.BringToFront();
            parentForm.LoadService(); // Call your custom method to load services
        }*/
		private void AddServiceRequest(int productId)
		{
			using (OleDbConnection myConn = new OleDbConnection(connString))
			{
				try
				{
					myConn.Open();
					string query = "INSERT INTO ServiceRequest ([UserID], [ProductID], [ServiceType], [RequestDate], [Status]) VALUES (@UserID, @ProductID, @ServiceType, @RequestDate, @Status)";
					using (OleDbCommand cmd = new OleDbCommand(query, myConn))
					{
						/*cmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
						cmd.Parameters.AddWithValue("@ProductID", productId);
						cmd.Parameters.AddWithValue("@ServiceType", "Installation");
						cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now);
						cmd.Parameters.AddWithValue("@Status", "Pending");*/
						cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = LoggedInUserId;  // Ensure Integer
						cmd.Parameters.Add("@ProductID", OleDbType.Integer).Value = productId;   // Ensure Integer
						cmd.Parameters.Add("@ServiceType", OleDbType.VarChar).Value = "Installation";  // Ensure String
						cmd.Parameters.Add("@RequestDate", OleDbType.Date).Value = DateTime.Now;  // Ensure Date
						cmd.Parameters.Add("@Status", OleDbType.VarChar).Value = "Pending";  // Ensure String


						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Service request added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Service Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void cmsRemove_Click(object sender, EventArgs e)
        {
			if (this.Tag is ProductInfo productInfo)
			{
				RemoveFromCart(productInfo);
			}
		}
		public void RemoveFromCart(ProductInfo product)
		{
			using (OleDbConnection myConn = new OleDbConnection(connString))
			{
				try
				{
					myConn.Open();
					string deleteQuery = "DELETE FROM Cart WHERE UserID = @UserID AND ProductID = @ProductID";
					using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, myConn))
					{
						deleteCmd.Parameters.AddWithValue("@UserID", LoggedInUserId);
						deleteCmd.Parameters.AddWithValue("@ProductID", product.ProductID);
						int rowsAffected = deleteCmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Product removed from cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Product not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
