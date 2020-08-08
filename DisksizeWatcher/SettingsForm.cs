using System;
using System.Windows.Forms;

namespace DisksizeWatcher
{
	/// <summary>
	/// Show the setting window of the application
	/// </summary>
	public partial class SettingsForm : Form
	{
		/// <summary>
		/// Get or set to stay on top
		/// </summary>
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

		/// <summary>
		/// Get or set to minimize to system tray
		/// </summary>
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

		/// <summary>
		/// Set or set the refresh rate
		/// </summary>
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
		/// Constructor
		/// </summary>
		public SettingsForm() => InitializeComponent();

		/// <summary>
		/// Load the settings form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SettingsForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
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
	}
}
