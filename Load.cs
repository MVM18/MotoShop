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
	public partial class Load : Form
	{

		public Load()
		{
			InitializeComponent();
			axWindowsMediaPlayer1.URL = "C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\LoadVid\\LoadingScreen.mp4"; // Change this to your video file path
			axWindowsMediaPlayer1.settings.autoStart = true;
			axWindowsMediaPlayer1.settings.setMode("loop", false);
			axWindowsMediaPlayer1.uiMode = "none"; // Hide controls
			axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
		}
		private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		{
			if (e.newState == 8) // 8 = Media ended
			{
				this.Close(); // Notify Form1
			}
		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{

		}
	}
}
