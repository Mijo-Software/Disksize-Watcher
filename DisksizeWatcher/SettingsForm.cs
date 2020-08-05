using System;
using System.Windows.Forms;

namespace DisksizeWatcher
{
	public partial class SettingsForm : Form
	{
		public bool StayOnTop
		{
			get
			{
				return checkBoxStayOnTop.Checked;
			}
			set
			{
				checkBoxStayOnTop.Checked = value;
			}
		}

		public bool MinimizeToSystemTray
		{
			get
			{
				return checkBoxMinimizeToSystemTray.Checked;
			}
			set
			{
				checkBoxMinimizeToSystemTray.Checked = value;
			}
		}

		public int RefreshRate
		{
			get
			{
				return (int)numericUpDownRefreshRate.Value;
			}
			set
			{
				numericUpDownRefreshRate.Value = value;
			}
		}

		public SettingsForm() => InitializeComponent();

		private void SettingsForm_Load(object sender, EventArgs e)
		{
		}
	}
}
