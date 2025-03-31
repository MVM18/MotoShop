namespace MotoShop
{
    partial class Services
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
			label4 = new Label();
			tbxTypeModel = new TextBox();
			btnCancel = new FontAwesome.Sharp.IconButton();
			btnConfirm = new FontAwesome.Sharp.IconButton();
			cmbTimeSlots = new ComboBox();
			label3 = new Label();
			tbxIssue = new TextBox();
			label2 = new Label();
			tbxReason = new TextBox();
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			cbxMaintenance = new CheckBox();
			cbxInstallation = new CheckBox();
			label5 = new Label();
			label6 = new Label();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(38, 295);
			label4.Name = "label4";
			label4.Size = new Size(367, 28);
			label4.TabIndex = 25;
			label4.Text = "Vehicle type and/or Model?";
			// 
			// tbxTypeModel
			// 
			tbxTypeModel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			tbxTypeModel.Location = new Point(33, 327);
			tbxTypeModel.Name = "tbxTypeModel";
			tbxTypeModel.Size = new Size(585, 35);
			tbxTypeModel.TabIndex = 24;
			// 
			// btnCancel
			// 
			btnCancel.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			btnCancel.IconColor = Color.Black;
			btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnCancel.Location = new Point(33, 569);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(154, 49);
			btnCancel.TabIndex = 23;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnConfirm
			// 
			btnConfirm.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
			btnConfirm.IconColor = Color.Black;
			btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnConfirm.Location = new Point(500, 569);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(154, 49);
			btnConfirm.TabIndex = 22;
			btnConfirm.Text = "Confirm";
			btnConfirm.UseVisualStyleBackColor = true;
			// 
			// cmbTimeSlots
			// 
			cmbTimeSlots.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			cmbTimeSlots.FormattingEnabled = true;
			cmbTimeSlots.Items.AddRange(new object[] { "9:00 AM - 10:00 AM", "10:00 AM - 11:00 AM", "11:00 AM - 12:00 PM", "1:00 PM - 2:00 PM", "2:00 PM - 3:00 PM", "3:00 PM - 4:00 PM", "4:00 PM - 5:00 PM" });
			cmbTimeSlots.Location = new Point(33, 502);
			cmbTimeSlots.Name = "cmbTimeSlots";
			cmbTimeSlots.Size = new Size(285, 36);
			cmbTimeSlots.TabIndex = 21;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(33, 217);
			label3.Name = "label3";
			label3.Size = new Size(383, 28);
			label3.TabIndex = 20;
			label3.Text = "Motorcyle Issue or Problem?";
			// 
			// tbxIssue
			// 
			tbxIssue.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			tbxIssue.Location = new Point(35, 248);
			tbxIssue.Name = "tbxIssue";
			tbxIssue.Size = new Size(583, 35);
			tbxIssue.TabIndex = 19;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(33, 134);
			label2.Name = "label2";
			label2.Size = new Size(599, 28);
			label2.TabIndex = 18;
			label2.Text = "What maintenance or Product to be installed?";
			// 
			// tbxReason
			// 
			tbxReason.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			tbxReason.Location = new Point(33, 165);
			tbxReason.Multiline = true;
			tbxReason.Name = "tbxReason";
			tbxReason.Size = new Size(585, 34);
			tbxReason.TabIndex = 17;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			dateTimePicker1.Location = new Point(33, 422);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(439, 35);
			dateTimePicker1.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(33, 29);
			label1.Name = "label1";
			label1.Size = new Size(176, 28);
			label1.TabIndex = 15;
			label1.Text = "Service Type";
			// 
			// cbxMaintenance
			// 
			cbxMaintenance.AutoSize = true;
			cbxMaintenance.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			cbxMaintenance.ForeColor = Color.White;
			cbxMaintenance.Location = new Point(239, 74);
			cbxMaintenance.Name = "cbxMaintenance";
			cbxMaintenance.Size = new Size(196, 32);
			cbxMaintenance.TabIndex = 14;
			cbxMaintenance.Text = "Maintenance";
			cbxMaintenance.UseVisualStyleBackColor = true;
			// 
			// cbxInstallation
			// 
			cbxInstallation.AutoSize = true;
			cbxInstallation.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			cbxInstallation.ForeColor = Color.White;
			cbxInstallation.Location = new Point(38, 74);
			cbxInstallation.Name = "cbxInstallation";
			cbxInstallation.Size = new Size(183, 32);
			cbxInstallation.TabIndex = 13;
			cbxInstallation.Text = "Installation";
			cbxInstallation.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(33, 378);
			label5.Name = "label5";
			label5.Size = new Size(157, 28);
			label5.TabIndex = 26;
			label5.Text = "Select Date";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
			label6.ForeColor = Color.White;
			label6.Location = new Point(33, 471);
			label6.Name = "label6";
			label6.Size = new Size(155, 28);
			label6.TabIndex = 27;
			label6.Text = "Select time";
			// 
			// Services
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(37, 39, 43);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(tbxTypeModel);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(cmbTimeSlots);
			Controls.Add(label3);
			Controls.Add(tbxIssue);
			Controls.Add(label2);
			Controls.Add(tbxReason);
			Controls.Add(dateTimePicker1);
			Controls.Add(label1);
			Controls.Add(cbxMaintenance);
			Controls.Add(cbxInstallation);
			Name = "Services";
			Size = new Size(682, 653);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
        private TextBox tbxTypeModel;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private ComboBox cmbTimeSlots;
        private Label label3;
        private TextBox tbxIssue;
        private Label label2;
        private TextBox tbxReason;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private CheckBox cbxMaintenance;
        private CheckBox cbxInstallation;
        private Label label5;
        private Label label6;
    }
}
