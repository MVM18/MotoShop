using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;


namespace MotoShop
{
    public partial class Modify : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        DataSet ds;

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb";

        public Modify()
        {
            InitializeComponent();
            LoadProducts();
            dgvProduct.CellClick += dgvProduct_CellClick;
        }
        private byte[]? ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO Inventory ([ProductName], [Brand], [Transmission], [Price], [Model], [Description],[StockQuantity],[Status],[ProductImage]) VALUES (@PName, @Brand, @Transmission, @Price,@Model, @Description, @SQuantity,@Status,@Image)";
            if (!decimal.TryParse(tbxPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid Price. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbxSquantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Invalid Stock Quantity. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connString))
                {
                    myConn.Open();

                    // Check if the username already exists
                    using (OleDbCommand checkCmd = new OleDbCommand("SELECT COUNT(*) FROM Inventory WHERE ProductName = @PName", myConn))
                    {
                        checkCmd.Parameters.AddWithValue("@PName", tbxPname.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Product already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new user
                    using (OleDbCommand insertCmd = new OleDbCommand(queryInsert, myConn))
                    {
                        insertCmd.Parameters.AddWithValue("@PName", tbxPname.Text);
                        insertCmd.Parameters.AddWithValue("@Brand", tbxBrand.Text);
                        insertCmd.Parameters.AddWithValue("@Transmission", lbTransmission.SelectedItem?.ToString() ?? "");
                        insertCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(tbxPrice.Text));
                        insertCmd.Parameters.AddWithValue("@Model", tbxModel.Text);
                        insertCmd.Parameters.AddWithValue("@Description", tbxDesc.Text);
                        insertCmd.Parameters.AddWithValue("@SQuantity", Convert.ToInt32(tbxSquantity.Text));
                        insertCmd.Parameters.AddWithValue("@Status", lbStatus.SelectedItem?.ToString() ?? "");
                        if (pbProductImage.Image != null)
                        {
                            insertCmd.Parameters.AddWithValue("@Image", ConvertImageToByteArray(pbProductImage.Image));
                        }
                        else
                        {
                            insertCmd.Parameters.AddWithValue("@Image", DBNull.Value);
                        }

                        insertCmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter numbers for Price and Stock Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPname.Text))
            {
                MessageBox.Show("Please enter a valid Product Name to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbxPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid Price. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbxSquantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Invalid Stock Quantity. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryUpdate = "UPDATE Inventory SET Brand = @Brand, Transmission = @Transmission, Price = @Price, Model = @Model, " +
                                 "Description = @Description, StockQuantity = @SQuantity, Status = @Status, ProductImage = @Image WHERE ProductName = @PName";

            try
            {
                using (myConn = new OleDbConnection(connString))
                {
                    myConn.Open();
                    using (OleDbCommand updateCmd = new OleDbCommand(queryUpdate, myConn))
                    {
                        updateCmd.Parameters.AddWithValue("@Brand", tbxBrand.Text);
                        updateCmd.Parameters.AddWithValue("@Transmission", lbTransmission.SelectedItem?.ToString() ?? "");
                        updateCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(tbxPrice.Text));
                        updateCmd.Parameters.AddWithValue("@Model", tbxModel.Text);
                        updateCmd.Parameters.AddWithValue("@Description", tbxDesc.Text);
                        updateCmd.Parameters.AddWithValue("@SQuantity", Convert.ToInt32(tbxSquantity.Text));
                        updateCmd.Parameters.AddWithValue("@Status", lbStatus.SelectedItem?.ToString() ?? "");
                        if (pbProductImage.Image != null)
                        {
                            updateCmd.Parameters.AddWithValue("@Image", ConvertImageToByteArray(pbProductImage.Image));
                        }
                        else
                        {
                            updateCmd.Parameters.AddWithValue("@Image", DBNull.Value);
                        }
                        updateCmd.Parameters.AddWithValue("@PName", tbxPname.Text);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Product Not Found. Please check the Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadProducts();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter numbers for Price and Stock Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPname.Text))
            {
                MessageBox.Show("Please enter a valid Product Name to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryDelete = "DELETE FROM Inventory WHERE ProductName = @PName";

            try
            {
                using (myConn = new OleDbConnection(connString))
                {
                    myConn.Open();
                    using (OleDbCommand deleteCmd = new OleDbCommand(queryDelete, myConn))
                    {
                        deleteCmd.Parameters.AddWithValue("@PName", tbxPname.Text);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // Clear input fields after deletion
                        }
                        else
                        {
                            MessageBox.Show("Product Not Found. Please check the Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFields()
        {
            tbxPname.Clear();
            tbxBrand.Clear();
            lbTransmission.ClearSelected();
            tbxPrice.Clear();
            tbxModel.Clear();
            tbxDesc.Clear();
            tbxSquantity.Clear();
            lbStatus.ClearSelected();
        }
        private void LoadProducts()
        {
            try
            {
                using (myConn = new OleDbConnection(connString))
                {
                    da = new OleDbDataAdapter("SELECT * FROM Inventory", myConn);
                    ds = new DataSet();
                    myConn.Open();
                    da.Fill(ds, "Inventory");
                    dgvProduct.DataSource = ds.Tables["Inventory"];
                }
                if (ds.Tables["Inventory"].Rows.Count > 0)
                {
                    LoadImageFromDatabase(ds.Tables["Inventory"].Rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadImageFromDatabase(DataRow row)
        {
            if (row["ProductImage"] != DBNull.Value)
            {
                byte[] imageData = (byte[])row["ProductImage"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbProductImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbProductImage.Image = null;
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Product Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                // Populate the textboxes and other controls with row data
                tbxPname.Text = row.Cells["ProductName"].Value?.ToString();
                tbxBrand.Text = row.Cells["Brand"].Value?.ToString();
                lbTransmission.SelectedItem = row.Cells["Transmission"].Value?.ToString();
                tbxPrice.Text = row.Cells["Price"].Value?.ToString();
                tbxModel.Text = row.Cells["Model"].Value?.ToString();
                tbxDesc.Text = row.Cells["Description"].Value?.ToString();
                tbxSquantity.Text = row.Cells["StockQuantity"].Value?.ToString();
                lbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();

                // Load the product image if available
                if (row.Cells["ProductImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["ProductImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbProductImage.Image = null;
                }
            }
        }
    }
}
