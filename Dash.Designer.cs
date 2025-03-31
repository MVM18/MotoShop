namespace MotoShop
{
    partial class Dash
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
            panelMenu = new Panel();
            flowpanelMenu = new FlowLayoutPanel();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnInventory = new FontAwesome.Sharp.IconButton();
            btnCart = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            panelSaerch = new Panel();
            panelContainer = new Panel();
            panelMenu.SuspendLayout();
            flowpanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(104, 109, 118);
            panelMenu.Controls.Add(flowpanelMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(iconButton8);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 953);
            panelMenu.TabIndex = 0;
            // 
            // flowpanelMenu
            // 
            flowpanelMenu.Controls.Add(btnProduct);
            flowpanelMenu.Controls.Add(btnInventory);
            flowpanelMenu.Controls.Add(btnCart);
            flowpanelMenu.Controls.Add(iconButton4);
            flowpanelMenu.Controls.Add(iconButton5);
            flowpanelMenu.Controls.Add(iconButton6);
            flowpanelMenu.Controls.Add(iconButton7);
            flowpanelMenu.Dock = DockStyle.Fill;
            flowpanelMenu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowpanelMenu.ForeColor = Color.White;
            flowpanelMenu.Location = new Point(0, 67);
            flowpanelMenu.Name = "flowpanelMenu";
            flowpanelMenu.Size = new Size(230, 824);
            flowpanelMenu.TabIndex = 1;
            flowpanelMenu.Paint += flowpanelMenu_Paint;
            // 
            // btnProduct
            // 
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.White;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProduct.IconColor = Color.Orange;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 3);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(224, 62);
            btnProduct.TabIndex = 1;
            btnProduct.Tag = "Product";
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.ForeColor = Color.White;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnInventory.IconColor = Color.Orange;
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(3, 71);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(221, 62);
            btnInventory.TabIndex = 2;
            btnInventory.Tag = "Inventory";
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ForeColor = Color.White;
            btnCart.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnCart.IconColor = Color.Orange;
            btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(3, 139);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(227, 62);
            btnCart.TabIndex = 3;
            btnCart.Tag = "Cart";
            btnCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCart.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            iconButton4.IconColor = Color.Orange;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(3, 207);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(227, 62);
            iconButton4.TabIndex = 4;
            iconButton4.Tag = "Purchase";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            iconButton5.IconColor = Color.Orange;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(3, 275);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(227, 62);
            iconButton5.TabIndex = 5;
            iconButton5.Tag = "Service";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton6.IconColor = Color.Orange;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(3, 343);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(227, 62);
            iconButton6.TabIndex = 6;
            iconButton6.Tag = "Users";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            iconButton7.IconColor = Color.Orange;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(3, 411);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(227, 62);
            iconButton7.TabIndex = 7;
            iconButton7.Tag = "Reports";
            iconButton7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 67);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.Orange;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(55, 67);
            btnMenu.TabIndex = 0;
            btnMenu.Tag = "";
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // iconButton8
            // 
            iconButton8.Dock = DockStyle.Bottom;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton8.IconColor = Color.Orange;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(0, 891);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(230, 62);
            iconButton8.TabIndex = 8;
            iconButton8.Tag = "Logout";
            iconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // panelSaerch
            // 
            panelSaerch.BackColor = Color.FromArgb(104, 109, 118);
            panelSaerch.Dock = DockStyle.Top;
            panelSaerch.Location = new Point(230, 0);
            panelSaerch.Name = "panelSaerch";
            panelSaerch.Size = new Size(1252, 73);
            panelSaerch.TabIndex = 1;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(230, 73);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1252, 880);
            panelContainer.TabIndex = 2;
            // 
            // Dash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 109, 118);
            ClientSize = new Size(1482, 953);
            Controls.Add(panelContainer);
            Controls.Add(panelSaerch);
            Controls.Add(panelMenu);
            Name = "Dash";
            Text = "Dash";
            MouseDown += Dash_MouseDown;
            panelMenu.ResumeLayout(false);
            flowpanelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelSaerch;
        private Panel panelContainer;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FlowLayoutPanel flowpanelMenu;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnCart;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
    }
}