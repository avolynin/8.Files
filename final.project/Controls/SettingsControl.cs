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
	public partial class SettingsControl : UserControl
	{
		#region Data

		private LogController _logController;

		#endregion

		#region .ctor
		public SettingsControl(LogController logController)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logController = logController;
		}
		#endregion
	}
}
