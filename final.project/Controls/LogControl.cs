using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final.project
{
	public partial class LogControl : UserControl
	{
		#region Data

		private LogController _logController;

		#endregion

		#region .ctor
		public LogControl(LogController controller)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = controller;
			_logController.AddMessageLog += AddMessageLog;
		}

		private void AddMessageLog(object sender, string text)
		{
			_txtLog.AppendText(text);
		}
		#endregion

		#region Methods

		private void LogControl_Load(object sender, EventArgs e)
		{
			
		}

		#endregion
	}
}
