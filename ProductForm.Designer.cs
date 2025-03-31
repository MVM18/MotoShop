namespace MotoShop
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblProductName = new Label();
			lblBrand = new Label();
			lblModel = new Label();
			lblTransmission = new Label();
			lblDescription = new Label();
			lblStatus = new Label();
			lblPrice = new Label();
			lblStock = new Label();
			pbPImage = new PictureBox();
			panel1 = new Panel();
			btnRemove = new FontAwesome.Sharp.IconButton();
			panel2 = new Panel();
			btnAddCart = new FontAwesome.Sharp.IconButton();
			btnBuy = new FontAwesome.Sharp.IconButton();
			panel3 = new Panel();
			((System.ComponentModel.ISupportInitialize)pbPImage).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// lblProductName
			// 
			lblProductName.AutoSize = true;
			lblProductName.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblProductName.ForeColor = Color.White;
			lblProductName.Location = new Point(13, 15);
			lblProductName.Name = "lblProductName";
			lblProductName.Size = new Size(216, 34);
			lblProductName.TabIndex = 0;
			lblProductName.Text = "Product Name";
			// 
			// lblBrand
			// 
			lblBrand.AutoSize = true;
			lblBrand.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblBrand.ForeColor = Color.White;
			lblBrand.Location = new Point(14, 64);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new Size(99, 34);
			lblBrand.TabIndex = 1;
			lblBrand.Text = "Brand";
			// 
			// lblModel
			// 
			lblModel.AutoSize = true;
			lblModel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblModel.ForeColor = Color.White;
			lblModel.Location = new Point(14, 116);
			lblModel.Name = "lblModel";
			lblModel.Size = new Size(100, 34);
			lblModel.TabIndex = 2;
			lblModel.Text = "Model";
			// 
			// lblTransmission
			// 
			lblTransmission.AutoSize = true;
			lblTransmission.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblTransmission.ForeColor = Color.White;
			lblTransmission.Location = new Point(449, 15);
			lblTransmission.Name = "lblTransmission";
			lblTransmission.Size = new Size(199, 34);
			lblTransmission.TabIndex = 3;
			lblTransmission.Text = "Transmission";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblDescription.ForeColor = Color.White;
			lblDescription.Location = new Point(14, 212);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(175, 34);
			lblDescription.TabIndex = 4;
			lblDescription.Text = "Description";
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblStatus.ForeColor = Color.White;
			lblStatus.Location = new Point(449, 116);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(106, 34);
			lblStatus.TabIndex = 5;
			lblStatus.Text = "Status";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblPrice.ForeColor = Color.White;
			lblPrice.Location = new Point(13, 162);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(85, 34);
			lblPrice.TabIndex = 6;
			lblPrice.Text = "Price";
			// 
			// lblStock
			// 
			lblStock.AutoSize = true;
			lblStock.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
			lblStock.ForeColor = Color.White;
			lblStock.Location = new Point(449, 64);
			lblStock.Name = "lblStock";
			lblStock.Size = new Size(94, 34);
			lblStock.TabIndex = 7;
			lblStock.Text = "Stock";
			// 
			// pbPImage
			// 
			pbPImage.Dock = DockStyle.Fill;
			pbPImage.Location = new Point(0, 0);
			pbPImage.Name = "pbPImage";
			pbPImage.Size = new Size(682, 348);
			pbPImage.SizeMode = PictureBoxSizeMode.Zoom;
			pbPImage.TabIndex = 8;
			pbPImage.TabStop = false;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnRemove);
			panel1.Controls.Add(pbPImage);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(682, 348);
			panel1.TabIndex = 9;
			// 
			// btnRemove
			// 
			btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnRemove.FlatAppearance.BorderSize = 0;
			btnRemove.FlatStyle = FlatStyle.Flat;
			btnRemove.IconChar = FontAwesome.Sharp.IconChar.Trash;
			btnRemove.IconColor = Color.FromArgb(220, 95, 0);
			btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnRemove.Location = new Point(609, 12);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(61, 58);
			btnRemove.TabIndex = 5;
			btnRemove.UseVisualStyleBackColor = true;
			btnRemove.Click += btnRemove_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnAddCart);
			panel2.Controls.Add(btnBuy);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 620);
			panel2.Name = "panel2";
			panel2.Size = new Size(682, 82);
			panel2.TabIndex = 10;
			// 
			// btnAddCart
			// 
			btnAddCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddCart.FlatAppearance.BorderSize = 0;
			btnAddCart.FlatStyle = FlatStyle.Flat;
			btnAddCart.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAddCart.ForeColor = Color.FromArgb(220, 95, 0);
			btnAddCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
			btnAddCart.IconColor = Color.FromArgb(220, 95, 0);
			btnAddCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAddCart.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddCart.Location = new Point(3, 12);
			btnAddCart.Name = "btnAddCart";
			btnAddCart.Size = new Size(186, 58);
			btnAddCart.TabIndex = 4;
			btnAddCart.Text = "Add To Cart";
			btnAddCart.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnAddCart.UseVisualStyleBackColor = true;
			btnAddCart.Click += btnAddCart_Click;
			// 
			// btnBuy
			// 
			btnBuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBuy.BackColor = Color.FromArgb(182, 73, 0);
			btnBuy.FlatAppearance.BorderSize = 0;
			btnBuy.FlatStyle = FlatStyle.Flat;
			btnBuy.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnBuy.ForeColor = Color.White;
			btnBuy.IconChar = FontAwesome.Sharp.IconChar.None;
			btnBuy.IconColor = Color.FromArgb(220, 95, 0);
			btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnBuy.Location = new Point(487, 12);
			btnBuy.Name = "btnBuy";
			btnBuy.Size = new Size(183, 58);
			btnBuy.TabIndex = 3;
			btnBuy.Text = "Buy Now ";
			btnBuy.UseVisualStyleBackColor = false;
			btnBuy.Click += btnBuy_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(lblStock);
			panel3.Controls.Add(lblPrice);
			panel3.Controls.Add(lblStatus);
			panel3.Controls.Add(lblDescription);
			panel3.Controls.Add(lblTransmission);
			panel3.Controls.Add(lblModel);
			panel3.Controls.Add(lblBrand);
			panel3.Controls.Add(lblProductName);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 348);
			panel3.Name = "panel3";
			panel3.Size = new Size(682, 272);
			panel3.TabIndex = 11;
			// 
			// ProductForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(37, 39, 43);
			ClientSize = new Size(682, 702);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ProductForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)pbPImage).EndInit();
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lblProductName;
        private Label lblBrand;
        private Label lblModel;
        private Label lblTransmission;
        private Label lblDescription;
        private Label lblStatus;
        private Label lblPrice;
        private Label lblStock;
        private PictureBox pbPImage;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private FontAwesome.Sharp.IconButton btnRemove;
		private FontAwesome.Sharp.IconButton btnAddCart;
		private FontAwesome.Sharp.IconButton btnBuy;
	}
}