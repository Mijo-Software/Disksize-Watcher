﻿using System;
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

		private short unitUsedSpace, unitFreeSpace, unitTotalSpace, swap;

		private double usedSpace, freeSpace, totalSpace, usedSpaceOrig, freeSpaceOrig, totalSpaceOrig, freeSpacePerc, usedSpacePerc;

		private string numberFormat = string.Empty;

		private enum SizeUnit
		{
			Byte = 0,
			Kilobyte = 1,
			Megabyte = 2,
			Gigabyte = 3,
			Terabyte = 4,
			Pentabyte = 5
		}

		private bool HasFraction(double number) => !(number - Math.Truncate(d: number) == 0);

		private void UncheckContextMenuForUsedSpaceUnits()
		{
			toolStripMenuItemUsedSpaceUnitByte.Checked = false;
			toolStripMenuItemUsedSpaceUnitKilobyte.Checked = false;
			toolStripMenuItemUsedSpaceUnitMegabyte.Checked = false;
			toolStripMenuItemUsedSpaceUnitGigabyte.Checked = false;
			toolStripMenuItemUsedSpaceUnitTerabyte.Checked = false;
			toolStripMenuItemUsedSpaceUnitPentabyte.Checked = false;
		}

		private void UncheckContextMenuForFreeSpaceUnits()
		{
			toolStripMenuItemFreeSpaceUnitByte.Checked = false;
			toolStripMenuItemFreeSpaceUnitKilobyte.Checked = false;
			toolStripMenuItemFreeSpaceUnitMegabyte.Checked = false;
			toolStripMenuItemFreeSpaceUnitGigabyte.Checked = false;
			toolStripMenuItemFreeSpaceUnitTerabyte.Checked = false;
			toolStripMenuItemFreeSpaceUnitPentabyte.Checked = false;
		}

		private void UncheckContextMenuForTotalSpaceUnits()
		{
			toolStripMenuItemTotalSpaceUnitByte.Checked = false;
			toolStripMenuItemTotalSpaceUnitKilobyte.Checked = false;
			toolStripMenuItemTotalSpaceUnitMegabyte.Checked = false;
			toolStripMenuItemTotalSpaceUnitGigabyte.Checked = false;
			toolStripMenuItemTotalSpaceUnitTerabyte.Checked = false;
			toolStripMenuItemTotalSpaceUnitPentabyte.Checked = false;
		}

		private void CaseUsedSpaceUnits()
		{
			switch (unitUsedSpace)
			{
				case (int)SizeUnit.Byte: labelSpaceUsedUnit.Text = "bytes"; toolStripMenuItemUsedSpaceUnitByte.Checked = true; break;
				case (int)SizeUnit.Kilobyte: labelSpaceUsedUnit.Text = "kilobytes"; toolStripMenuItemUsedSpaceUnitKilobyte.Checked = true; break;
				case (int)SizeUnit.Megabyte: labelSpaceUsedUnit.Text = "megabytes"; toolStripMenuItemUsedSpaceUnitMegabyte.Checked = true; break;
				case (int)SizeUnit.Gigabyte: labelSpaceUsedUnit.Text = "gigabytes"; toolStripMenuItemUsedSpaceUnitGigabyte.Checked = true; break;
				case (int)SizeUnit.Terabyte: labelSpaceUsedUnit.Text = "terabytes"; toolStripMenuItemUsedSpaceUnitTerabyte.Checked = true; break;
				case (int)SizeUnit.Pentabyte: labelSpaceUsedUnit.Text = "pentabytes"; toolStripMenuItemUsedSpaceUnitPentabyte.Checked = true; break;
				default: labelSpaceUsedUnit.Text = "bytes"; toolStripMenuItemUsedSpaceUnitByte.Checked = true; unitUsedSpace = 0; break;
			}
		}

		private void CaseFreeSpaceUnits()
		{
			switch (unitFreeSpace)
			{
				case (int)SizeUnit.Byte: labelSpaceFreeUnit.Text = "bytes"; toolStripMenuItemFreeSpaceUnitByte.Checked = true; break;
				case (int)SizeUnit.Kilobyte: labelSpaceFreeUnit.Text = "kilobytes"; toolStripMenuItemFreeSpaceUnitKilobyte.Checked = true; break;
				case (int)SizeUnit.Megabyte: labelSpaceFreeUnit.Text = "megabytes"; toolStripMenuItemFreeSpaceUnitMegabyte.Checked = true; break;
				case (int)SizeUnit.Gigabyte: labelSpaceFreeUnit.Text = "gigabytes"; toolStripMenuItemFreeSpaceUnitGigabyte.Checked = true; break;
				case (int)SizeUnit.Terabyte: labelSpaceFreeUnit.Text = "terabytes"; toolStripMenuItemFreeSpaceUnitTerabyte.Checked = true; break;
				case (int)SizeUnit.Pentabyte: labelSpaceFreeUnit.Text = "pentabytes"; toolStripMenuItemFreeSpaceUnitPentabyte.Checked = true; break;
				default: labelSpaceFreeUnit.Text = "bytes"; unitFreeSpace = 0; toolStripMenuItemFreeSpaceUnitByte.Checked = true; break;
			}
		}

		private void CaseTotalSpaceUnits()
		{
			switch (unitTotalSpace)
			{
				case (int)SizeUnit.Byte: labelSpaceTotalUnit.Text = "bytes"; toolStripMenuItemTotalSpaceUnitByte.Checked = true; break;
				case (int)SizeUnit.Kilobyte: labelSpaceTotalUnit.Text = "kilobytes"; toolStripMenuItemTotalSpaceUnitKilobyte.Checked = true; break;
				case (int)SizeUnit.Megabyte: labelSpaceTotalUnit.Text = "megabytes"; toolStripMenuItemTotalSpaceUnitMegabyte.Checked = true; break;
				case (int)SizeUnit.Gigabyte: labelSpaceTotalUnit.Text = "gigabytes"; toolStripMenuItemTotalSpaceUnitGigabyte.Checked = true; break;
				case (int)SizeUnit.Terabyte: labelSpaceTotalUnit.Text = "terabytes"; toolStripMenuItemTotalSpaceUnitTerabyte.Checked = true; break;
				case (int)SizeUnit.Pentabyte: labelSpaceTotalUnit.Text = "pentabytes"; toolStripMenuItemTotalSpaceUnitPentabyte.Checked = true; break;
				default: labelSpaceTotalUnit.Text = "bytes"; unitTotalSpace = 0; toolStripMenuItemTotalSpaceUnitByte.Checked = true; break;
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

		private void ToolStripMenuItemUsedSpaceUnitByte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Byte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitKilobyte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Kilobyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitMegabyte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Megabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitGigabyte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Gigabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitTerabyte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Terabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitPentabyte_Click(object sender, EventArgs e)
		{
			unitUsedSpace = (int)SizeUnit.Pentabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitByte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Byte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitKilobyte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Kilobyte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitMegabyte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Megabyte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitGigabyte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Gigabyte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitTerabyte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Terabyte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemFreeSpaceUnitPentabyte_Click(object sender, EventArgs e)
		{
			unitFreeSpace = (int)SizeUnit.Pentabyte;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitByte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Byte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitKilobyte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Kilobyte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitMegabyte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Megabyte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitGigabyte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Gigabyte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitTerabyte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Terabyte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemTotalSpaceUnitPentabyte_Click(object sender, EventArgs e)
		{
			unitTotalSpace = (int)SizeUnit.Pentabyte;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitByte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Byte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitKilobyte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Kilobyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitMegabyte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Megabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitGigabyte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Gigabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitTerabyte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Terabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitPentabyte_MouseEnter(object sender, EventArgs e)
		{
			swap = unitUsedSpace;
			unitUsedSpace = (int)SizeUnit.Pentabyte;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitByte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitKilobyte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitMegabyte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitGigabyte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitTerabyte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
		}

		private void ToolStripMenuItemUsedSpaceUnitPentabyte_MouseLeave(object sender, EventArgs e)
		{
			unitUsedSpace = swap;
			CaseUsedSpaceUnits();
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
				usedSpaceOrig = driveC.TotalSize - driveC.TotalFreeSpace;
				freeSpaceOrig = driveC.TotalFreeSpace;
				totalSpaceOrig = driveC.TotalSize;
				usedSpace = usedSpaceOrig;
				freeSpace = freeSpaceOrig;
				totalSpace = totalSpaceOrig;

				switch (unitUsedSpace)
				{
					case (int)SizeUnit.Kilobyte: usedSpace /= 1024; break;
					case (int)SizeUnit.Megabyte: usedSpace = usedSpace / 1024 / 1024; break;
					case (int)SizeUnit.Gigabyte: usedSpace = usedSpace / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Terabyte: usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Pentabyte: usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024 / 1024; break;
					default: break;
				}
				switch (unitFreeSpace)
				{
					case (int)SizeUnit.Kilobyte: freeSpace /= 1024; break;
					case (int)SizeUnit.Megabyte: freeSpace = freeSpace / 1024 / 1024; break;
					case (int)SizeUnit.Gigabyte: freeSpace = freeSpace / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Terabyte: freeSpace = freeSpace / 1024 / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Pentabyte: freeSpace = freeSpace / 1024 / 1024 / 1024 / 1024 / 1024; break;
					default: break;
				}
				switch (unitTotalSpace)
				{
					case (int)SizeUnit.Kilobyte: totalSpace /= 1024; break;
					case (int)SizeUnit.Megabyte: totalSpace = totalSpace / 1024 / 1024; break;
					case (int)SizeUnit.Gigabyte: totalSpace = totalSpace / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Terabyte: totalSpace = totalSpace / 1024 / 1024 / 1024 / 1024; break;
					case (int)SizeUnit.Pentabyte: totalSpace = totalSpace / 1024 / 1024 / 1024 / 1024 / 1024; break;
					default: break;
				}
				freeSpacePerc = freeSpaceOrig / totalSpaceOrig * 100;
				usedSpacePerc = 100 - freeSpacePerc;
				progressBarPercentage.Value = (int)usedSpacePerc;
				labelSpacePercentageValue.Text = $"{usedSpacePerc:G6} %";
				numberFormat = "";
				if (HasFraction(number: usedSpace))
				{
					numberFormat = "F6";
				}
				textBoxSpaceUsed.Text = usedSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
				numberFormat = "";
				if (HasFraction(number: freeSpace))
				{
					numberFormat = "F6";
				}
				textBoxSpaceFree.Text = freeSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
				numberFormat = "";
				if (HasFraction(number: totalSpace))
				{
					numberFormat = "F6";
				}
				textBoxSpaceTotal.Text = totalSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
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

		private void LabelSpaceUsedUnit_Click(object sender, EventArgs e)
		{
			unitUsedSpace++;
			UncheckContextMenuForUsedSpaceUnits();
			CaseUsedSpaceUnits();
		}

		private void LabelSpaceFreeUnit_Click(object sender, EventArgs e)
		{
			unitFreeSpace++;
			UncheckContextMenuForFreeSpaceUnits();
			CaseFreeSpaceUnits();
		}

		private void LabelSpaceTotalUnit_Click(object sender, EventArgs e)
		{
			unitTotalSpace++;
			UncheckContextMenuForTotalSpaceUnits();
			CaseTotalSpaceUnits();
		}
	}
}
