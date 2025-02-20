using System.Globalization;
using System.IO;
using DisksizeWatcher.Properties;
using NLog;

namespace DisksizeWatcher
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Drive information
		/// </summary>
		private readonly DriveInfo drive = new(driveName: "C");

		/// <summary>
		/// Unit of the space
		/// </summary>
		private short unitSpace;

		/// <summary>
		/// Values of the space
		/// </summary>
		private double usedSpace, freeSpace, totalSpace, diffSpace, usedSpaceOrig, freeSpaceOrig, totalSpaceOrig, diffSpaceOrig, freeSpacePerc, usedSpacePerc;

		/// <summary>
		/// Number format
		/// </summary>
		private string numberFormat = string.Empty;

		/// <summary>
		/// Size units
		/// </summary>
		private enum SizeUnit
		{
			Byte = 0,
			Kilobyte = 1,
			Megabyte = 2,
			Gigabyte = 3,
			Terabyte = 4,
			Pentabyte = 5
		}

		#region Helpers

		/// <summary>
		/// Detects if a float number has a fraction
		/// </summary>
		/// <param name="number">number to check</param>
		/// <returns></returns>
		private static bool HasFraction(double number) => !(number - Math.Truncate(d: number) == 0);

		/// <summary>
		/// Choose the correct unit for the diff space
		/// </summary>
		private void CaseSpaceUnits()
		{
			string unitText = unitSpace switch
			{
				(int)SizeUnit.Kilobyte => Resources.kilobytes,
				(int)SizeUnit.Megabyte => Resources.megabytes,
				(int)SizeUnit.Gigabyte => Resources.gigabytes,
				(int)SizeUnit.Terabyte => Resources.terabytes,
				(int)SizeUnit.Pentabyte => Resources.pentabytes,
				_ => Resources.bytes
			};

			labelSpaceUsedUnit.Text = unitText;
			labelSpaceFreeUnit.Text = unitText;
			labelSpaceTotalUnit.Text = unitText;
			labelSpaceDiffUnit.Text = unitText;

			if (unitSpace is < 0 or > ((int)SizeUnit.Pentabyte))
			{
				unitSpace = 0;
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
		/// Set up the number with a fraction
		/// </summary>
		private void SetUpNumberWithFraction()
		{
			string baseFormat = toolStripButtonThousandSeparator.Checked ? "N" : "F";
			numberFormat = toolStripMenuItemDecimalSeparatorTo0.Checked ? $"{baseFormat}0" :
						   toolStripMenuItemDecimalSeparatorTo1.Checked ? $"{baseFormat}1" :
						   toolStripMenuItemDecimalSeparatorTo2.Checked ? $"{baseFormat}2" :
						   toolStripMenuItemDecimalSeparatorTo3.Checked ? $"{baseFormat}3" :
						   toolStripMenuItemDecimalSeparatorTo4.Checked ? $"{baseFormat}4" :
						   toolStripMenuItemDecimalSeparatorTo5.Checked ? $"{baseFormat}5" :
						   toolStripMenuItemDecimalSeparatorTo6.Checked ? $"{baseFormat}6" :
						   numberFormat;
		}

		/// <summary>
		/// Set up the number without a fraction
		/// </summary>
		private void SetUpNumberWithoutFraction()
		{
			if (toolStripButtonThousandSeparator.Checked)
			{
				numberFormat = Resources.numberformatN0;
			}
		}

		/// <summary>
		/// Show the value of the spaces in the specified unit
		/// </summary>
		/// <param name="unit">The unit to display the values in</param>
		private void ShowValueInUnit(SizeUnit unit)
		{
			unitSpace = (short)unit;
			CaseSpaceUnits();
			toolStripButtonShowValueInByte.Checked = unit == SizeUnit.Byte;
			toolStripButtonShowValueInKilobyte.Checked = unit == SizeUnit.Kilobyte;
			toolStripButtonShowValueInMegabyte.Checked = unit == SizeUnit.Megabyte;
			toolStripButtonShowValueInGigabyte.Checked = unit == SizeUnit.Gigabyte;
			toolStripButtonShowValueInTerabyte.Checked = unit == SizeUnit.Terabyte;
			toolStripButtonShowValueInPentabyte.Checked = unit == SizeUnit.Pentabyte;
		}

		/// <summary>
		/// Update the decimal separator to the specified number of places
		/// </summary>
		/// <param name="places">The number of decimal places</param>
		private void UpdateDecimalSeparator(int places)
		{
			ToolStripMenuItem[] menuItems =
			[
				toolStripMenuItemDecimalSeparatorTo0,
				toolStripMenuItemDecimalSeparatorTo1,
				toolStripMenuItemDecimalSeparatorTo2,
				toolStripMenuItemDecimalSeparatorTo3,
				toolStripMenuItemDecimalSeparatorTo4,
				toolStripMenuItemDecimalSeparatorTo5,
				toolStripMenuItemDecimalSeparatorTo6
			];

			for (int i = 0; i < menuItems.Length; i++)
			{
				menuItems[i].Checked = i == places;
			}
		}

		/// <summary>
		/// Update the information of the disk space
		/// </summary>
		private void UpdateSpaceInfo()
		{
			if (drive.IsReady)
			{
				diffSpaceOrig = usedSpaceOrig;
				usedSpaceOrig = drive.TotalSize - drive.TotalFreeSpace;
				freeSpaceOrig = drive.TotalFreeSpace;
				totalSpaceOrig = drive.TotalSize;
				usedSpace = usedSpaceOrig;
				freeSpace = freeSpaceOrig;
				totalSpace = totalSpaceOrig;
				diffSpace = diffSpaceOrig;
				switch (unitSpace)
				{
					case (int)SizeUnit.Kilobyte:
						usedSpace /= 1024;
						totalSpace /= 1024;
						freeSpace /= 1024;
						diffSpace /= 1024;
						break;
					case (int)SizeUnit.Megabyte:
						usedSpace = usedSpace / 1024 / 1024;
						freeSpace = freeSpace / 1024 / 1024;
						totalSpace = totalSpace / 1024 / 1024;
						diffSpace = diffSpace / 1024 / 1024;
						break;
					case (int)SizeUnit.Gigabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024;
						freeSpace = freeSpace / 1024 / 1024 / 1024;
						totalSpace = totalSpace / 1024 / 1024 / 1024;
						diffSpace = diffSpace / 1024 / 1024 / 1024;
						break;
					case (int)SizeUnit.Terabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024;
						freeSpace = freeSpace / 1024 / 1024 / 1024 / 1024;
						totalSpace = totalSpace / 1024 / 1024 / 1024 / 1024;
						diffSpace = diffSpace / 1024 / 1024 / 1024 / 1024;
						break;
					case (int)SizeUnit.Pentabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024 / 1024;
						freeSpace = freeSpace / 1024 / 1024 / 1024 / 1024 / 1024;
						totalSpace = totalSpace / 1024 / 1024 / 1024 / 1024 / 1024;
						diffSpace = diffSpace / 1024 / 1024 / 1024 / 1024 / 1024;
						break;
					default:
						break;
				}
				freeSpacePerc = freeSpaceOrig / totalSpaceOrig * 100;
				usedSpacePerc = 100 - freeSpacePerc;
				progressBarPercentage.Value = (int)usedSpacePerc;
				numberFormat = Resources.numberformatG6;
				labelSpacePercentageValue.Text = $"{usedSpacePerc.ToString(format: numberFormat, provider: CultureInfo.CurrentCulture)} %";
				numberFormat = string.Empty;
				if (HasFraction(number: usedSpace))
				{
					SetUpNumberWithFraction();
				}
				else
				{
					SetUpNumberWithoutFraction();
				}
				textBoxSpaceUsed.Text = usedSpace.ToString(format: numberFormat, provider: CultureInfo.CurrentCulture);
				numberFormat = string.Empty;
				if (HasFraction(number: freeSpace))
				{
					SetUpNumberWithFraction();
				}
				else
				{
					SetUpNumberWithoutFraction();
				}
				textBoxSpaceFree.Text = freeSpace.ToString(format: numberFormat, provider: CultureInfo.CurrentCulture);
				numberFormat = string.Empty;
				if (HasFraction(number: totalSpace))
				{
					SetUpNumberWithFraction();
				}
				else
				{
					SetUpNumberWithoutFraction();
				}
				textBoxSpaceTotal.Text = totalSpace.ToString(format: numberFormat, provider: CultureInfo.CurrentCulture);
				numberFormat = string.Empty;
				if (HasFraction(number: diffSpace))
				{
					SetUpNumberWithFraction();
				}
				else
				{
					SetUpNumberWithoutFraction();
				}
				usedSpace = usedSpaceOrig;
				switch (unitSpace)
				{
					case (int)SizeUnit.Kilobyte:
						usedSpace /= 1024;
						break;
					case (int)SizeUnit.Megabyte:
						usedSpace = usedSpace / 1024 / 1024;
						break;
					case (int)SizeUnit.Gigabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024;
						break;
					case (int)SizeUnit.Terabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024;
						break;
					case (int)SizeUnit.Pentabyte:
						usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024 / 1024;
						break;
					default:
						break;
				}
				textBoxSpaceDiff.Text = Math.Abs(value: diffSpace - usedSpace).ToString(format: numberFormat, provider: CultureInfo.CurrentCulture);
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			Logger.Info(message: "MainForm initialized.");
		}

		#endregion

		#region Load event handler

		/// <summary>
		/// Load the main form
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
			notifyIcon.Visible = false;
			if (drive.IsReady)
			{
				textBoxSpaceTotal.Text = drive.TotalSize.ToString(provider: CultureInfo.CurrentCulture);
				fileSystemWatcher.Path = drive.Name;
			}
		}

		#endregion

		#region Enter event handler

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control { AccessibleDescription: { } } control)
			{
				SetStatusbarText(text: control.AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
			{
				SetStatusbarText(text: control2.AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
			{
				SetStatusbarText(text: control3.AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

		#region Click event handlers

		/// <summary>
		/// Show the value of the spaces in byte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInByte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Byte);

		/// <summary>
		/// Show the value of the spaces in kilobyte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInKilobyte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Kilobyte);

		/// <summary>
		/// Show the value of the spaces in megabyte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInMegabyte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Megabyte);

		/// <summary>
		/// Show the value of the spaces in gigabyte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInGigabyte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Gigabyte);

		/// <summary>
		/// Show the value of the spaces in terabyte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInTerabyte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Terabyte);

		/// <summary>
		/// Show the value of the spaces in pentabyte
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonShowValueInPentabyte_Click(object sender, EventArgs e) => ShowValueInUnit(unit: SizeUnit.Pentabyte);

		/// <summary>
		/// Update the decimal separator to 0 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo0_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 0);

		/// <summary>
		/// Update the decimal separator to 1 place
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo1_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 1);

		/// <summary>
		/// Update the decimal separator to 2 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo2_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 2);

		/// <summary>
		/// Update the decimal separator to 3 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo3_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 3);

		/// <summary>
		/// Update the decimal separator to 4 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo4_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 4);

		/// <summary>
		/// Update the decimal separator to 5 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo5_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 5);

		/// <summary>
		/// Update the decimal separator to 6 places
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemDecimalSeparatorTo6_Click(object sender, EventArgs e) => UpdateDecimalSeparator(places: 6);

		/// <summary>
		/// Open the program information window
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonInfo_Click(object sender, EventArgs e)
		{
			using AboutBoxForm aboutBoxForm = new();
			aboutBoxForm.TopMost = TopMost;
			_ = aboutBoxForm.ShowDialog();
		}

		/// <summary>
		/// Open the license window
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonLicense_Click(object sender, EventArgs e)
		{
			using LicenseForm licenseForm = new();
			licenseForm.TopMost = TopMost;
			_ = licenseForm.ShowDialog();
		}

		#endregion

		#region ButtonClick event handler

		/// <summary>
		/// Open the setting window and apply the settings
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripSplitButtonSettings_ButtonClick(object sender, EventArgs e)
		{
			if (menuitemStayOnTop.Checked)
			{
				TopMost = false;
			}
			using (SettingsForm settingsForm = new())
			{
				settingsForm.StayOnTop = menuitemStayOnTop.Checked;
				settingsForm.MinimizeToSystemTray = menuitemMinimizeToSystemTray.Checked;
				DialogResult dialogResult = settingsForm.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					menuitemStayOnTop.Checked = settingsForm.StayOnTop;
					menuitemMinimizeToSystemTray.Checked = settingsForm.MinimizeToSystemTray;
				}
			}
			if (menuitemStayOnTop.Checked)
			{
				TopMost = true;
			}
		}

		#endregion

		#region DoubleClick event handlers

		/// <summary>
		/// Open the main window from the notify icon
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		#endregion

		#region KeyDown event handlers

		/// <summary>
		/// Handles the KeyDown event of the LicenseForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MainForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion

		#region CheckedChanged event handlers

		/// <summary>
		/// Set window in foreground if the option "stay on top" is enabled
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MenuitemStayOnTop_CheckedChanged(object sender, EventArgs e) => TopMost = menuitemStayOnTop.Checked;

		#endregion

		#region Resize event handlers

		/// <summary>
		/// If the option 'minimize to system tray' is enabled, minimize to system tray
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
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

		#endregion

		#region FileSystemWatcher event handlers

		/// <summary>
		/// Update information about the disk using FileSystemWatcher event
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

		/// <summary>
		/// Update information about the disk using FileSystemWatcher event
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

		/// <summary>
		/// Update information about the disk using FileSystemWatcher event
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

		/// <summary>
		/// Update information about the disk using FileSystemWatcher event
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e) => UpdateSpaceInfo();

		#endregion
	}
}