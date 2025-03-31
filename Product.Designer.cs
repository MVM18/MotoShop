namespace MotoShop
{
    partial class Product
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			pbProductPic = new PictureBox();
			lblPname = new Label();
			lblPrice = new Label();
			lblBrand = new Label();
			cmProduct = new ContextMenuStrip(components);
			cmsCart = new ToolStripMenuItem();
			cmsBuy = new ToolStripMenuItem();
			cmsRemove = new ToolStripMenuItem();
			lblModel = new Label();
			nudQuantity = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)pbProductPic).BeginInit();
			cmProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
			SuspendLayout();
			// 
			// pbProductPic
			// 
			pbProductPic.Dock = DockStyle.Top;
			pbProductPic.Location = new Point(0, 0);
			pbProductPic.Name = "pbProductPic";
			pbProductPic.Size = new Size(324, 179);
			pbProductPic.SizeMode = PictureBoxSizeMode.Zoom;
			pbProductPic.TabIndex = 0;
			pbProductPic.TabStop = false;
			// 
			// lblPname
			// 
			lblPname.AutoSize = true;
			lblPname.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			lblPname.ForeColor = Color.White;
			lblPname.Location = new Point(13, 258);
			lblPname.Name = "lblPname";
			lblPname.Size = new Size(153, 24);
			lblPname.TabIndex = 6;
			lblPname.Text = "Product Name";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			lblPrice.ForeColor = Color.White;
			lblPrice.Location = new Point(13, 191);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(61, 24);
			lblPrice.TabIndex = 7;
			lblPrice.Text = "Price";
			// 
			// lblBrand
			// 
			lblBrand.AutoSize = true;
			lblBrand.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			lblBrand.ForeColor = Color.White;
			lblBrand.Location = new Point(13, 225);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new Size(71, 24);
			lblBrand.TabIndex = 8;
			lblBrand.Text = "Brand";
			// 
			// cmProduct
			// 
			cmProduct.ImageScalingSize = new Size(20, 20);
			cmProduct.Items.AddRange(new ToolStripItem[] { cmsCart, cmsBuy, cmsRemove });
			cmProduct.Name = "cmProduct";
			cmProduct.Size = new Size(156, 76);
			// 
			// cmsCart
			// 
			cmsCart.Name = "cmsCart";
			cmsCart.Size = new Size(155, 24);
			cmsCart.Text = "Add to Cart";
			cmsCart.Click += cmsCart_Click;
			// 
			// cmsBuy
			// 
			cmsBuy.Name = "cmsBuy";
			cmsBuy.Size = new Size(155, 24);
			cmsBuy.Text = "Buy";
			cmsBuy.Click += cmsBuy_Click;
			// 
			// cmsRemove
			// 
			cmsRemove.Name = "cmsRemove";
			cmsRemove.Size = new Size(155, 24);
			cmsRemove.Text = "Remove";
			cmsRemove.Click += cmsRemove_Click;
			// 
			// lblModel
			// 
			lblModel.AutoSize = true;
			lblModel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
			lblModel.ForeColor = Color.White;
			lblModel.Location = new Point(161, 191);
			lblModel.Name = "lblModel";
			lblModel.Size = new Size(71, 24);
			lblModel.TabIndex = 10;
			lblModel.Text = "Model";
			// 
			// nudQuantity
			// 
			nudQuantity.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			nudQuantity.Location = new Point(161, 225);
			nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudQuantity.Name = "nudQuantity";
			nudQuantity.Size = new Size(71, 32);
			nudQuantity.TabIndex = 11;
			nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// Product
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(37, 39, 43);
			Controls.Add(nudQuantity);
			Controls.Add(lblModel);
			Controls.Add(lblBrand);
			Controls.Add(lblPrice);
			Controls.Add(lblPname);
			Controls.Add(pbProductPic);
			Name = "Product";
			Size = new Size(324, 301);
			DoubleClick += Product_DoubleClick;
			((System.ComponentModel.ISupportInitialize)pbProductPic).EndInit();
			cmProduct.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public Label lblPname;
        public Label lblPrice;
        public Label lblBrand;
        private ContextMenuStrip cmProduct;
        private ToolStripMenuItem cmsCart;
        private ToolStripMenuItem cmsBuy;
        public PictureBox pbProductPic;
        public Label lblModel;
        private ToolStripMenuItem cmsRemove;
		public NumericUpDown nudQuantity;
	}
}
