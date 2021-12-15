using final.project.Controls;
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
using System.Text.RegularExpressions;

namespace final.project
{
	public partial class MainForm : Form
	{
		private LogController _logController;
		private VideoPlayerController _videoPlayerController;

		private SettingsControl _settings;
		private VideoPlayerControl _video;
		private LogControl _log;

		public MainForm(LogController logController, VideoPlayerController videoPlayerController)
		{
			InitializeComponent();

			_logController = logController;
			_videoPlayerController = videoPlayerController;

			_log = new LogControl(_logController);
			_video = new VideoPlayerControl(_videoPlayerController);
			_settings = new SettingsControl(_logController);

			_pnlLog.Controls.Add(_log);
			_pnlVideo.Controls.Add(_video);
			_pnlSettings.Controls.Add(_settings);

			var unixTimestamp = (uint)(DateTime.UtcNow.Subtract(DateTime.UnixEpoch)).TotalSeconds;
			_logController.AddMessage("Session: №" + unixTimestamp.ToString());
			_logController.AddMessage("Some log text");
		}

	}
}
