namespace MotoShop
{
	partial class ServiceControl
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
			lblServiceType = new Label();
			lblProduct = new Label();
			lblStatus = new Label();
			lblServiceDate = new Label();
			SuspendLayout();
			// 
			// lblServiceType
			// 
			lblServiceType.AutoSize = true;
			lblServiceType.Font = new Font("Verdana", 12F, FontStyle.Bold);
			lblServiceType.ForeColor = Color.White;
			lblServiceType.Location = new Point(18, 22);
			lblServiceType.Name = "lblServiceType";
			lblServiceType.Size = new Size(116, 18);
			lblServiceType.TabIndex = 0;
			lblServiceType.Text = "ServiceType";
			// 
			// lblProduct
			// 
			lblProduct.AutoSize = true;
			lblProduct.Font = new Font("Verdana", 12F, FontStyle.Bold);
			lblProduct.ForeColor = Color.White;
			lblProduct.Location = new Point(18, 57);
			lblProduct.Name = "lblProduct";
			lblProduct.Size = new Size(77, 18);
			lblProduct.TabIndex = 1;
			lblProduct.Text = "Product";
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Font = new Font("Verdana", 12F, FontStyle.Bold);
			lblStatus.ForeColor = Color.White;
			lblStatus.Location = new Point(19, 118);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(64, 18);
			lblStatus.TabIndex = 2;
			lblStatus.Text = "Status";
			// 
			// lblServiceDate
			// 
			lblServiceDate.AutoSize = true;
			lblServiceDate.Font = new Font("Verdana", 12F, FontStyle.Bold);
			lblServiceDate.ForeColor = Color.White;
			lblServiceDate.Location = new Point(19, 87);
			lblServiceDate.Name = "lblServiceDate";
			lblServiceDate.Size = new Size(114, 18);
			lblServiceDate.TabIndex = 3;
			lblServiceDate.Text = "ServiceDate";
			// 
			// ServiceControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(55, 58, 64);
			Controls.Add(lblServiceDate);
			Controls.Add(lblStatus);
			Controls.Add(lblProduct);
			Controls.Add(lblServiceType);
			Name = "ServiceControl";
			Size = new Size(215, 236);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public Label lblServiceType;
		public Label lblProduct;
		public Label lblStatus;
		public Label lblServiceDate;
	}
}
