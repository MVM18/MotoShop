using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoShop
{
	public partial class ProductForm : Form
	{
		private Product productControl;
		private ProductInfo productInfo;
		private int LoggedInUserId;

		public ProductForm(ProductInfo product, int loggedInUserId)
		{
			InitializeComponent();
			LoggedInUserId = loggedInUserId;
			productInfo = product;
			productControl = new Product(LoggedInUserId);
			// Display product details in form controls
			lblStock.Text = product.StockQuantity.ToString();
			lblProductName.Text = product.ProductName;
			lblBrand.Text = product.Brand;
			lblModel.Text = product.Model;
			lblTransmission.Text = product.Transmission;
			lblDescription.Text = product.Description;
			lblStatus.Text = product.Status;
			lblPrice.Text = "₱" + product.Price.ToString("N2");

			// Display product image if available
			if (product.ProductImage != null && product.ProductImage.Length > 0)
			{
				using (MemoryStream ms = new MemoryStream(product.ProductImage))
				{
					pbPImage.Image = Image.FromStream(ms); // Load image into PictureBox
					pbPImage.SizeMode = PictureBoxSizeMode.Zoom; // Ensure it fits
				}
			}
			else
			{
				pbPImage.Image = null; // No image available
			}

			LoggedInUserId = loggedInUserId;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			productControl.RemoveFromCart(productInfo);
		}

		private void btnAddCart_Click(object sender, EventArgs e)
		{

			productControl.AddToCart(productInfo);

		}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			productControl.CheckoutProduct(productInfo);
		}
	}
}
