﻿namespace MotoShop
{
	partial class Load
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
			axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
			SuspendLayout();
			// 
			// axWindowsMediaPlayer1
			// 
			axWindowsMediaPlayer1.Dock = DockStyle.Fill;
			axWindowsMediaPlayer1.Enabled = true;
			axWindowsMediaPlayer1.Location = new Point(0, 0);
			axWindowsMediaPlayer1.Margin = new Padding(3, 2, 3, 2);
			axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
			axWindowsMediaPlayer1.Size = new Size(612, 525);
			axWindowsMediaPlayer1.TabIndex = 1;
			axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
			// 
			// Load
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(612, 525);
			Controls.Add(axWindowsMediaPlayer1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Load";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Load";
			((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}