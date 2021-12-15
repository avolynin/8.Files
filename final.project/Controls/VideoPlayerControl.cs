using final.project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final.project.Controls
{
	public partial class VideoPlayerControl : UserControl
	{
		private VideoPlayerController _videoPlayerController;

		public VideoPlayerControl(VideoPlayerController videoPlayerController)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_videoPlayerController = videoPlayerController;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}
	}
}
