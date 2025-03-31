namespace MotoShop
{
    partial class Dashboard
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
			components = new System.ComponentModel.Container();
			tbxSearch = new TextBox();
			panel1 = new Panel();
			btnEdit = new FontAwesome.Sharp.IconButton();
			btnSearch = new FontAwesome.Sharp.IconButton();
			btnMenu = new FontAwesome.Sharp.IconButton();
			panelMenu = new Panel();
			btnProduct = new FontAwesome.Sharp.IconButton();
			btnLogout = new FontAwesome.Sharp.IconButton();
			btnInventory = new FontAwesome.Sharp.IconButton();
			btnCart = new FontAwesome.Sharp.IconButton();
			btnReports = new FontAwesome.Sharp.IconButton();
			btnPurchase = new FontAwesome.Sharp.IconButton();
			btnUser = new FontAwesome.Sharp.IconButton();
			btnService = new FontAwesome.Sharp.IconButton();
			panelContainer = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			dgvProduct = new DataGridView();
			toolTip1 = new ToolTip(components);
			panel1.SuspendLayout();
			panelMenu.SuspendLayout();
			panelContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
			SuspendLayout();
			// 
			// tbxSearch
			// 
			tbxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			tbxSearch.Font = new Font("Segoe UI", 16F);
			tbxSearch.Location = new Point(471, 9);
			tbxSearch.Margin = new Padding(3, 2, 3, 2);
			tbxSearch.Name = "tbxSearch";
			tbxSearch.Size = new Size(695, 36);
			tbxSearch.TabIndex = 1;
			tbxSearch.Text = "Search";
			tbxSearch.TextChanged += tbxSearch_TextChanged;
			tbxSearch.Enter += tbxSearch_Enter;
			tbxSearch.Leave += tbxSearch_Leave;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(37, 39, 43);
			panel1.Controls.Add(btnEdit);
			panel1.Controls.Add(btnSearch);
			panel1.Controls.Add(btnMenu);
			panel1.Controls.Add(tbxSearch);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(1297, 51);
			panel1.TabIndex = 5;
			// 
			// btnEdit
			// 
			btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnEdit.FlatAppearance.BorderSize = 0;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
			btnEdit.IconColor = Color.FromArgb(220, 95, 0);
			btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnEdit.Location = new Point(1241, 3);
			btnEdit.Margin = new Padding(3, 2, 3, 2);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(53, 44);
			btnEdit.TabIndex = 2;
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnSearch
			// 
			btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSearch.FlatAppearance.BorderSize = 0;
			btnSearch.FlatStyle = FlatStyle.Flat;
			btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			btnSearch.IconColor = Color.FromArgb(220, 95, 0);
			btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSearch.Location = new Point(1171, 5);
			btnSearch.Margin = new Padding(3, 2, 3, 2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(53, 44);
			btnSearch.TabIndex = 0;
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click_1;
			// 
			// btnMenu
			// 
			btnMenu.Dock = DockStyle.Left;
			btnMenu.FlatAppearance.BorderSize = 0;
			btnMenu.FlatStyle = FlatStyle.Flat;
			btnMenu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnMenu.ForeColor = Color.White;
			btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
			btnMenu.IconColor = Color.FromArgb(220, 95, 0);
			btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
			btnMenu.Location = new Point(0, 0);
			btnMenu.Margin = new Padding(3, 2, 3, 2);
			btnMenu.Name = "btnMenu";
			btnMenu.Size = new Size(55, 51);
			btnMenu.TabIndex = 1;
			btnMenu.Tag = "";
			btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnMenu.UseVisualStyleBackColor = true;
			btnMenu.Click += btnMenu_Click;
			// 
			// panelMenu
			// 
			panelMenu.BackColor = Color.FromArgb(37, 39, 43);
			panelMenu.Controls.Add(btnProduct);
			panelMenu.Controls.Add(btnLogout);
			panelMenu.Controls.Add(btnInventory);
			panelMenu.Controls.Add(btnCart);
			panelMenu.Controls.Add(btnReports);
			panelMenu.Controls.Add(btnPurchase);
			panelMenu.Controls.Add(btnUser);
			panelMenu.Controls.Add(btnService);
			panelMenu.Dock = DockStyle.Left;
			panelMenu.Location = new Point(0, 51);
			panelMenu.Margin = new Padding(3, 2, 3, 2);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(201, 664);
			panelMenu.TabIndex = 7;
			panelMenu.Paint += panelMenu_Paint;
			// 
			// btnProduct
			// 
			btnProduct.FlatAppearance.BorderSize = 0;
			btnProduct.FlatStyle = FlatStyle.Flat;
			btnProduct.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnProduct.ForeColor = Color.White;
			btnProduct.IconChar = FontAwesome.Sharp.IconChar.Box;
			btnProduct.IconColor = Color.FromArgb(220, 95, 0);
			btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
			btnProduct.Location = new Point(3, 4);
			btnProduct.Margin = new Padding(3, 2, 3, 2);
			btnProduct.Name = "btnProduct";
			btnProduct.Size = new Size(186, 46);
			btnProduct.TabIndex = 1;
			btnProduct.Tag = "Product";
			btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnProduct, "Products Available");
			btnProduct.UseVisualStyleBackColor = true;
			btnProduct.Click += btnProduct_Click;
			// 
			// btnLogout
			// 
			btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogout.ForeColor = Color.White;
			btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
			btnLogout.IconColor = Color.FromArgb(220, 95, 0);
			btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
			btnLogout.Location = new Point(3, 615);
			btnLogout.Margin = new Padding(3, 2, 3, 2);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(186, 46);
			btnLogout.TabIndex = 9;
			btnLogout.Tag = "Logout";
			btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// btnInventory
			// 
			btnInventory.FlatAppearance.BorderSize = 0;
			btnInventory.FlatStyle = FlatStyle.Flat;
			btnInventory.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnInventory.ForeColor = Color.White;
			btnInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
			btnInventory.IconColor = Color.FromArgb(220, 95, 0);
			btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
			btnInventory.Location = new Point(3, 206);
			btnInventory.Margin = new Padding(3, 2, 3, 2);
			btnInventory.Name = "btnInventory";
			btnInventory.Size = new Size(188, 46);
			btnInventory.TabIndex = 2;
			btnInventory.Tag = "Inventory";
			btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnInventory, "Inventory");
			btnInventory.UseVisualStyleBackColor = true;
			btnInventory.Click += btnInventory_Click;
			// 
			// btnCart
			// 
			btnCart.FlatAppearance.BorderSize = 0;
			btnCart.FlatStyle = FlatStyle.Flat;
			btnCart.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnCart.ForeColor = Color.White;
			btnCart.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
			btnCart.IconColor = Color.FromArgb(220, 95, 0);
			btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnCart.ImageAlign = ContentAlignment.MiddleLeft;
			btnCart.Location = new Point(3, 56);
			btnCart.Margin = new Padding(3, 2, 3, 2);
			btnCart.Name = "btnCart";
			btnCart.Size = new Size(186, 46);
			btnCart.TabIndex = 3;
			btnCart.Tag = "Cart";
			btnCart.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnCart, "View Cart");
			btnCart.UseVisualStyleBackColor = true;
			btnCart.Click += btnCart_Click;
			// 
			// btnReports
			// 
			btnReports.FlatAppearance.BorderSize = 0;
			btnReports.FlatStyle = FlatStyle.Flat;
			btnReports.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnReports.ForeColor = Color.White;
			btnReports.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
			btnReports.IconColor = Color.FromArgb(220, 95, 0);
			btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnReports.ImageAlign = ContentAlignment.MiddleLeft;
			btnReports.Location = new Point(3, 308);
			btnReports.Margin = new Padding(3, 2, 3, 2);
			btnReports.Name = "btnReports";
			btnReports.Size = new Size(186, 46);
			btnReports.TabIndex = 7;
			btnReports.Tag = "Reports";
			toolTip1.SetToolTip(btnReports, "Reports");
			btnReports.UseVisualStyleBackColor = true;
			btnReports.Click += btnReports_Click;
			// 
			// btnPurchase
			// 
			btnPurchase.FlatAppearance.BorderSize = 0;
			btnPurchase.FlatStyle = FlatStyle.Flat;
			btnPurchase.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnPurchase.ForeColor = Color.White;
			btnPurchase.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
			btnPurchase.IconColor = Color.FromArgb(220, 95, 0);
			btnPurchase.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnPurchase.ImageAlign = ContentAlignment.MiddleLeft;
			btnPurchase.Location = new Point(3, 106);
			btnPurchase.Margin = new Padding(3, 2, 3, 2);
			btnPurchase.Name = "btnPurchase";
			btnPurchase.Size = new Size(186, 46);
			btnPurchase.TabIndex = 4;
			btnPurchase.Tag = "Purchase";
			btnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnPurchase, "View Purchase");
			btnPurchase.UseVisualStyleBackColor = true;
			btnPurchase.Click += btnPurchase_Click;
			// 
			// btnUser
			// 
			btnUser.FlatAppearance.BorderSize = 0;
			btnUser.FlatStyle = FlatStyle.Flat;
			btnUser.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnUser.ForeColor = Color.White;
			btnUser.IconChar = FontAwesome.Sharp.IconChar.Users;
			btnUser.IconColor = Color.FromArgb(220, 95, 0);
			btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnUser.ImageAlign = ContentAlignment.MiddleLeft;
			btnUser.Location = new Point(3, 256);
			btnUser.Margin = new Padding(3, 2, 3, 2);
			btnUser.Name = "btnUser";
			btnUser.Size = new Size(186, 46);
			btnUser.TabIndex = 6;
			btnUser.Tag = "Users";
			btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnUser, "Users");
			btnUser.UseVisualStyleBackColor = true;
			btnUser.Click += btnUser_Click;
			// 
			// btnService
			// 
			btnService.FlatAppearance.BorderSize = 0;
			btnService.FlatStyle = FlatStyle.Flat;
			btnService.Font = new Font("Verdana", 12F, FontStyle.Bold);
			btnService.ForeColor = Color.White;
			btnService.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
			btnService.IconColor = Color.FromArgb(220, 95, 0);
			btnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnService.ImageAlign = ContentAlignment.MiddleLeft;
			btnService.Location = new Point(3, 154);
			btnService.Margin = new Padding(3, 2, 3, 2);
			btnService.Name = "btnService";
			btnService.Size = new Size(186, 46);
			btnService.TabIndex = 5;
			btnService.Tag = "Service";
			btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(btnService, "Services");
			btnService.UseVisualStyleBackColor = true;
			btnService.Click += btnService_Click;
			// 
			// panelContainer
			// 
			panelContainer.Controls.Add(flowLayoutPanel1);
			panelContainer.Controls.Add(dgvProduct);
			panelContainer.Dock = DockStyle.Fill;
			panelContainer.Location = new Point(201, 51);
			panelContainer.Margin = new Padding(3, 2, 3, 2);
			panelContainer.Name = "panelContainer";
			panelContainer.Size = new Size(1096, 664);
			panelContainer.TabIndex = 8;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.BackColor = Color.FromArgb(55, 58, 64);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			flowLayoutPanel1.ForeColor = Color.White;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1096, 664);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// dgvProduct
			// 
			dgvProduct.BackgroundColor = Color.FromArgb(104, 109, 118);
			dgvProduct.BorderStyle = BorderStyle.None;
			dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProduct.Dock = DockStyle.Fill;
			dgvProduct.GridColor = Color.DarkSlateGray;
			dgvProduct.Location = new Point(0, 0);
			dgvProduct.Margin = new Padding(3, 2, 3, 2);
			dgvProduct.Name = "dgvProduct";
			dgvProduct.RowHeadersWidth = 51;
			dgvProduct.Size = new Size(1096, 664);
			dgvProduct.TabIndex = 0;
			// 
			// toolTip1
			// 
			toolTip1.Tag = "";
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(104, 109, 118);
			ClientSize = new Size(1297, 715);
			Controls.Add(panelContainer);
			Controls.Add(panelMenu);
			Controls.Add(panel1);
			ForeColor = Color.Black;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Dashboard";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Load += AdminDashboard_Load;
			MouseDown += Dashboard_MouseDown;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panelMenu.ResumeLayout(false);
			panelContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private TextBox tbxSearch;
        private Panel panel1;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnCart;
        private FontAwesome.Sharp.IconButton btnPurchase;
        private FontAwesome.Sharp.IconButton btnService;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnReports;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvProduct;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnEdit;
        private ToolTip toolTip1;
    }
}