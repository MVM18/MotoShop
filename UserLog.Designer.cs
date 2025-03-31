namespace MotoShop
{
    partial class UserLog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLog));
			label1 = new Label();
			btnNewUser = new Button();
			tbxUname = new TextBox();
			tbxPass = new TextBox();
			panel1 = new Panel();
			button1 = new Button();
			panel2 = new Panel();
			btnVpass = new Button();
			btnLogin = new Button();
			panel3 = new Panel();
			label2 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(255, 184, 122);
			label1.Location = new Point(166, 47);
			label1.Name = "label1";
			label1.Size = new Size(242, 48);
			label1.TabIndex = 2;
			label1.Text = "WELCOME!";
			// 
			// btnNewUser
			// 
			btnNewUser.FlatAppearance.BorderColor = Color.DarkSlateGray;
			btnNewUser.FlatAppearance.BorderSize = 0;
			btnNewUser.FlatStyle = FlatStyle.Flat;
			btnNewUser.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNewUser.ForeColor = Color.FromArgb(220, 95, 0);
			btnNewUser.Location = new Point(325, 417);
			btnNewUser.Margin = new Padding(3, 2, 3, 2);
			btnNewUser.Name = "btnNewUser";
			btnNewUser.Size = new Size(79, 32);
			btnNewUser.TabIndex = 4;
			btnNewUser.Text = "Sign Up";
			btnNewUser.UseVisualStyleBackColor = true;
			btnNewUser.Click += btnNewUser_Click;
			// 
			// tbxUname
			// 
			tbxUname.BorderStyle = BorderStyle.None;
			tbxUname.Font = new Font("Tahoma", 16F);
			tbxUname.Location = new Point(60, 9);
			tbxUname.Margin = new Padding(3, 2, 3, 2);
			tbxUname.Name = "tbxUname";
			tbxUname.Size = new Size(208, 26);
			tbxUname.TabIndex = 5;
			tbxUname.Text = "Username";
			tbxUname.Enter += tbxUname_Enter;
			tbxUname.KeyDown += tbxUname_KeyDown;
			tbxUname.Leave += tbxUname_Leave;
			// 
			// tbxPass
			// 
			tbxPass.BorderStyle = BorderStyle.None;
			tbxPass.Font = new Font("Tahoma", 16F);
			tbxPass.Location = new Point(63, 8);
			tbxPass.Margin = new Padding(3, 2, 3, 2);
			tbxPass.Name = "tbxPass";
			tbxPass.Size = new Size(208, 26);
			tbxPass.TabIndex = 6;
			tbxPass.Text = "Password";
			tbxPass.Enter += tbxPass_Enter;
			tbxPass.KeyDown += tbxPass_KeyDown;
			tbxPass.Leave += tbxPass_Leave;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(button1);
			panel1.Controls.Add(tbxUname);
			panel1.Font = new Font("Tahoma", 15F, FontStyle.Bold);
			panel1.Location = new Point(166, 204);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(271, 44);
			panel1.TabIndex = 7;
			// 
			// button1
			// 
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Zoom;
			button1.Dock = DockStyle.Left;
			button1.Location = new Point(0, 0);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(52, 44);
			button1.TabIndex = 10;
			button1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(btnVpass);
			panel2.Controls.Add(tbxPass);
			panel2.Font = new Font("Tahoma", 15F, FontStyle.Bold);
			panel2.Location = new Point(166, 262);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(271, 42);
			panel2.TabIndex = 8;
			// 
			// btnVpass
			// 
			btnVpass.BackgroundImage = (Image)resources.GetObject("btnVpass.BackgroundImage");
			btnVpass.BackgroundImageLayout = ImageLayout.Stretch;
			btnVpass.Dock = DockStyle.Left;
			btnVpass.Location = new Point(0, 0);
			btnVpass.Margin = new Padding(3, 2, 3, 2);
			btnVpass.Name = "btnVpass";
			btnVpass.Size = new Size(52, 42);
			btnVpass.TabIndex = 7;
			btnVpass.UseVisualStyleBackColor = true;
			btnVpass.Click += btnVpass_Click;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(220, 95, 0);
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Tahoma", 15F, FontStyle.Bold);
			btnLogin.ForeColor = Color.White;
			btnLogin.Location = new Point(166, 332);
			btnLogin.Margin = new Padding(3, 2, 3, 2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(271, 42);
			btnLogin.TabIndex = 9;
			btnLogin.Text = "LOG IN";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(37, 39, 43);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(btnLogin);
			panel3.Controls.Add(btnNewUser);
			panel3.Controls.Add(panel2);
			panel3.Controls.Add(panel1);
			panel3.Controls.Add(label1);
			panel3.Dock = DockStyle.Fill;
			panel3.ForeColor = Color.FromArgb(26, 28, 31);
			panel3.Location = new Point(0, 0);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(597, 490);
			panel3.TabIndex = 10;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Verdana", 11F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(194, 424);
			label2.Name = "label2";
			label2.Size = new Size(113, 18);
			label2.TabIndex = 10;
			label2.Text = "New to Shop?";
			// 
			// UserLog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel3);
			Margin = new Padding(3, 2, 3, 2);
			Name = "UserLog";
			Size = new Size(597, 490);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Label label1;
        private Button btnNewUser;
        private TextBox tbxUname;
        private TextBox tbxPass;
        private Panel panel1;
        private Panel panel2;
        private Button btnVpass;
        private Button btnLogin;
        private Button button1;
        private Panel panel3;
        private Label label2;
	}
}
