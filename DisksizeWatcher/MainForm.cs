using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DisksizeWatcher
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	public partial class MainForm : Form
	{
		private readonly DriveInfo driveC = new DriveInfo(driveName: "C");

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Construtor
		/// </summary>
		public MainForm() => InitializeComponent();

		/// <summary>
		/// Load the main form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
			notifyIcon.Visible = false;
			if (driveC.IsReady)
			{
				textBoxSpaceTotal.Text = driveC.TotalSize.ToString(provider: CultureInfo.InvariantCulture);
			}
			timer.Start();
		}

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			string text = string.Empty;
			if (sender is Control control)
			{
				text = control.AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				text = toolStripSplitButton.AccessibleDescription;
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				text = toolStripButton.AccessibleDescription;
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				text = toolStripLabel.AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				text = toolStripMenuItem.AccessibleDescription;
			}
			SetStatusbarText(text: text);
		}

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Perform the timer
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (driveC.IsReady)
			{
				double freeSpacePerc = driveC.TotalFreeSpace / (float)driveC.TotalSize * 100;
				double usedSpacePerc = 100 - freeSpacePerc;
				progressBarPercentage.Value = (int)usedSpacePerc;
				labelSpacePercentageValue.Text = $"{usedSpacePerc:G6} %";
				textBoxSpaceUsed.Text = (driveC.TotalSize - driveC.TotalFreeSpace).ToString(provider: CultureInfo.InvariantCulture);
				textBoxSpaceFree.Text = driveC.TotalFreeSpace.ToString(provider: CultureInfo.InvariantCulture);
			}
		}

		private void ToolStripSplitButtonSettings_ButtonClick(object sender, EventArgs e)
		{
			if (menuitemStayOnTop.Checked)
			{
				TopMost = false;
			}
			using (SettingsForm settingsForm = new SettingsForm())
			{
				settingsForm.StayOnTop = menuitemStayOnTop.Checked;
				settingsForm.MinimizeToSystemTray = menuitemMinimizeToSystemTray.Checked;
				DialogResult dialogResult = settingsForm.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					timer.Interval = settingsForm.RefreshRate;
					menuitemStayOnTop.Checked = settingsForm.StayOnTop;
					menuitemMinimizeToSystemTray.Checked = settingsForm.MinimizeToSystemTray;
				}
			}
			if (menuitemStayOnTop.Checked)
			{
				TopMost = true;
			}
		}

		private void MenuitemStayOnTop_CheckedChanged(object sender, EventArgs e) => TopMost = menuitemStayOnTop.Checked;

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				if (menuitemMinimizeToSystemTray.Checked)
				{
					Hide();
					notifyIcon.Visible = true;
				}
			}
		}

		private void NotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}
	}
}
