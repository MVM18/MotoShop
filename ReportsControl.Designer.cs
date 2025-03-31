namespace MotoShop
{
	partial class ReportsControl
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
			panel1 = new Panel();
			btnYearly = new FontAwesome.Sharp.IconButton();
			btnMonthly = new FontAwesome.Sharp.IconButton();
			btnWeekly = new FontAwesome.Sharp.IconButton();
			panel2 = new Panel();
			dgvReports = new DataGridView();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(btnYearly);
			panel1.Controls.Add(btnMonthly);
			panel1.Controls.Add(btnWeekly);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(804, 56);
			panel1.TabIndex = 0;
			// 
			// btnYearly
			// 
			btnYearly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnYearly.BackColor = Color.FromArgb(182, 73, 0);
			btnYearly.FlatAppearance.BorderSize = 0;
			btnYearly.FlatStyle = FlatStyle.Flat;
			btnYearly.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnYearly.ForeColor = Color.White;
			btnYearly.IconChar = FontAwesome.Sharp.IconChar.None;
			btnYearly.IconColor = Color.FromArgb(220, 95, 0);
			btnYearly.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnYearly.Location = new Point(335, 2);
			btnYearly.Margin = new Padding(3, 2, 3, 2);
			btnYearly.Name = "btnYearly";
			btnYearly.Size = new Size(160, 44);
			btnYearly.TabIndex = 6;
			btnYearly.Text = "Yearly ";
			btnYearly.UseVisualStyleBackColor = false;
			btnYearly.Click += btnYearly_Click;
			// 
			// btnMonthly
			// 
			btnMonthly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMonthly.BackColor = Color.FromArgb(182, 73, 0);
			btnMonthly.FlatAppearance.BorderSize = 0;
			btnMonthly.FlatStyle = FlatStyle.Flat;
			btnMonthly.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnMonthly.ForeColor = Color.White;
			btnMonthly.IconChar = FontAwesome.Sharp.IconChar.None;
			btnMonthly.IconColor = Color.FromArgb(220, 95, 0);
			btnMonthly.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMonthly.Location = new Point(169, 2);
			btnMonthly.Margin = new Padding(3, 2, 3, 2);
			btnMonthly.Name = "btnMonthly";
			btnMonthly.Size = new Size(160, 44);
			btnMonthly.TabIndex = 5;
			btnMonthly.Text = "Monthly";
			btnMonthly.UseVisualStyleBackColor = false;
			btnMonthly.Click += btnMonthly_Click;
			// 
			// btnWeekly
			// 
			btnWeekly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWeekly.BackColor = Color.FromArgb(182, 73, 0);
			btnWeekly.FlatAppearance.BorderSize = 0;
			btnWeekly.FlatStyle = FlatStyle.Flat;
			btnWeekly.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnWeekly.ForeColor = Color.White;
			btnWeekly.IconChar = FontAwesome.Sharp.IconChar.None;
			btnWeekly.IconColor = Color.FromArgb(220, 95, 0);
			btnWeekly.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnWeekly.Location = new Point(3, 2);
			btnWeekly.Margin = new Padding(3, 2, 3, 2);
			btnWeekly.Name = "btnWeekly";
			btnWeekly.Size = new Size(160, 44);
			btnWeekly.TabIndex = 4;
			btnWeekly.Text = "Weekly";
			btnWeekly.UseVisualStyleBackColor = false;
			btnWeekly.Click += btnWeekly_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgvReports);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 56);
			panel2.Name = "panel2";
			panel2.Size = new Size(804, 574);
			panel2.TabIndex = 1;
			// 
			// dgvReports
			// 
			dgvReports.BackgroundColor = Color.FromArgb(37, 39, 43);
			dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvReports.Dock = DockStyle.Fill;
			dgvReports.Location = new Point(0, 0);
			dgvReports.Name = "dgvReports";
			dgvReports.Size = new Size(804, 574);
			dgvReports.TabIndex = 0;
			// 
			// ReportsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(37, 39, 43);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "ReportsControl";
			Size = new Size(804, 630);
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private FontAwesome.Sharp.IconButton btnYearly;
		private FontAwesome.Sharp.IconButton btnMonthly;
		private FontAwesome.Sharp.IconButton btnWeekly;
		private Panel panel2;
		private DataGridView dgvReports;
	}
}
