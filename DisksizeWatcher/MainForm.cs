using DisksizeWatcher.Properties;
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

        private short unitUsedSpace, unitFreeSpace, unitTotalSpace, unitDiffSpace;

        private double usedSpace, freeSpace, totalSpace, diffSpace, usedSpaceOrig, freeSpaceOrig, totalSpaceOrig, diffSpaceOrig, freeSpacePerc, usedSpacePerc;

        private string numberFormat;

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

        #region Local methods

        /// <summary>
        /// Detects if a float number has a fraction
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns></returns>
        private static bool HasFraction(double number) => !(number - Math.Truncate(d: number) == 0);

        /// <summary>
        /// Uncheck all menu item in the associated context menu for the used space
        /// </summary>
        private void UncheckContextMenuForUsedSpaceUnits()
        {
            toolStripMenuItemUsedSpaceUnitByte.Checked = false;
            toolStripMenuItemUsedSpaceUnitKilobyte.Checked = false;
            toolStripMenuItemUsedSpaceUnitMegabyte.Checked = false;
            toolStripMenuItemUsedSpaceUnitGigabyte.Checked = false;
            toolStripMenuItemUsedSpaceUnitTerabyte.Checked = false;
            toolStripMenuItemUsedSpaceUnitPentabyte.Checked = false;
        }

        /// <summary>
        /// Uncheck all menu item in the associated context menu for the free space
        /// </summary>
        private void UncheckContextMenuForFreeSpaceUnits()
        {
            toolStripMenuItemFreeSpaceUnitByte.Checked = false;
            toolStripMenuItemFreeSpaceUnitKilobyte.Checked = false;
            toolStripMenuItemFreeSpaceUnitMegabyte.Checked = false;
            toolStripMenuItemFreeSpaceUnitGigabyte.Checked = false;
            toolStripMenuItemFreeSpaceUnitTerabyte.Checked = false;
            toolStripMenuItemFreeSpaceUnitPentabyte.Checked = false;
        }

        /// <summary>
        /// Uncheck all menu item in the associated context menu for the total space
        /// </summary>
        private void UncheckContextMenuForTotalSpaceUnits()
        {
            toolStripMenuItemTotalSpaceUnitByte.Checked = false;
            toolStripMenuItemTotalSpaceUnitKilobyte.Checked = false;
            toolStripMenuItemTotalSpaceUnitMegabyte.Checked = false;
            toolStripMenuItemTotalSpaceUnitGigabyte.Checked = false;
            toolStripMenuItemTotalSpaceUnitTerabyte.Checked = false;
            toolStripMenuItemTotalSpaceUnitPentabyte.Checked = false;
        }

        /// <summary>
        /// Uncheck all menu item in the associated context menu for the total space
        /// </summary>
        private void UncheckContextMenuForDiffSpaceUnits()
        {
            toolStripMenuItemDiffSpaceUnitByte.Checked = false;
            toolStripMenuItemDiffSpaceUnitKilobyte.Checked = false;
            toolStripMenuItemDiffSpaceUnitMegabyte.Checked = false;
            toolStripMenuItemDiffSpaceUnitGigabyte.Checked = false;
            toolStripMenuItemDiffSpaceUnitTerabyte.Checked = false;
            toolStripMenuItemDiffSpaceUnitPentabyte.Checked = false;
        }

        /// <summary>
        /// Choose the correct unit for the used space
        /// </summary>
        private void CaseUsedSpaceUnits()
        {
            switch (unitUsedSpace)
            {
                case (int)SizeUnit.Byte: labelSpaceUsedUnit.Text = Resources.bytes; toolStripMenuItemUsedSpaceUnitByte.Checked = true; break;
                case (int)SizeUnit.Kilobyte: labelSpaceUsedUnit.Text = Resources.kilobytes; toolStripMenuItemUsedSpaceUnitKilobyte.Checked = true; break;
                case (int)SizeUnit.Megabyte: labelSpaceUsedUnit.Text = Resources.megabytes; toolStripMenuItemUsedSpaceUnitMegabyte.Checked = true; break;
                case (int)SizeUnit.Gigabyte: labelSpaceUsedUnit.Text = Resources.gigabytes; toolStripMenuItemUsedSpaceUnitGigabyte.Checked = true; break;
                case (int)SizeUnit.Terabyte: labelSpaceUsedUnit.Text = Resources.terabytes; toolStripMenuItemUsedSpaceUnitTerabyte.Checked = true; break;
                case (int)SizeUnit.Pentabyte: labelSpaceUsedUnit.Text = Resources.pentabytes; toolStripMenuItemUsedSpaceUnitPentabyte.Checked = true; break;
                default: labelSpaceUsedUnit.Text = Resources.bytes; toolStripMenuItemUsedSpaceUnitByte.Checked = true; unitUsedSpace = 0; break;
            }
        }

        /// <summary>
        /// Choose the correct unit for the free space
        /// </summary>
        private void CaseFreeSpaceUnits()
        {
            switch (unitFreeSpace)
            {
                case (int)SizeUnit.Byte: labelSpaceFreeUnit.Text = Resources.bytes; toolStripMenuItemFreeSpaceUnitByte.Checked = true; break;
                case (int)SizeUnit.Kilobyte: labelSpaceFreeUnit.Text = Resources.kilobytes; toolStripMenuItemFreeSpaceUnitKilobyte.Checked = true; break;
                case (int)SizeUnit.Megabyte: labelSpaceFreeUnit.Text = Resources.megabytes; toolStripMenuItemFreeSpaceUnitMegabyte.Checked = true; break;
                case (int)SizeUnit.Gigabyte: labelSpaceFreeUnit.Text = Resources.gigabytes; toolStripMenuItemFreeSpaceUnitGigabyte.Checked = true; break;
                case (int)SizeUnit.Terabyte: labelSpaceFreeUnit.Text = Resources.terabytes; toolStripMenuItemFreeSpaceUnitTerabyte.Checked = true; break;
                case (int)SizeUnit.Pentabyte: labelSpaceFreeUnit.Text = Resources.pentabytes; toolStripMenuItemFreeSpaceUnitPentabyte.Checked = true; break;
                default: labelSpaceFreeUnit.Text = Resources.bytes; toolStripMenuItemFreeSpaceUnitByte.Checked = true; unitFreeSpace = 0; break;
            }
        }

        /// <summary>
        /// Choose the correct unit for the total space
        /// </summary>
        private void CaseTotalSpaceUnits()
        {
            switch (unitTotalSpace)
            {
                case (int)SizeUnit.Byte: labelSpaceTotalUnit.Text = Resources.bytes; toolStripMenuItemTotalSpaceUnitByte.Checked = true; break;
                case (int)SizeUnit.Kilobyte: labelSpaceTotalUnit.Text = Resources.kilobytes; toolStripMenuItemTotalSpaceUnitKilobyte.Checked = true; break;
                case (int)SizeUnit.Megabyte: labelSpaceTotalUnit.Text = Resources.megabytes; toolStripMenuItemTotalSpaceUnitMegabyte.Checked = true; break;
                case (int)SizeUnit.Gigabyte: labelSpaceTotalUnit.Text = Resources.gigabytes; toolStripMenuItemTotalSpaceUnitGigabyte.Checked = true; break;
                case (int)SizeUnit.Terabyte: labelSpaceTotalUnit.Text = Resources.terabytes; toolStripMenuItemTotalSpaceUnitTerabyte.Checked = true; break;
                case (int)SizeUnit.Pentabyte: labelSpaceTotalUnit.Text = Resources.pentabytes; toolStripMenuItemTotalSpaceUnitPentabyte.Checked = true; break;
                default: labelSpaceTotalUnit.Text = Resources.bytes; toolStripMenuItemTotalSpaceUnitByte.Checked = true; unitTotalSpace = 0; break;
            }
        }

        /// <summary>
        /// Choose the correct unit for the diff space
        /// </summary>
        private void CaseDiffSpaceUnits()
        {
            switch (unitDiffSpace)
            {
                case (int)SizeUnit.Byte: labelSpaceDiffUnit.Text = Resources.bytes; toolStripMenuItemDiffSpaceUnitByte.Checked = true; break;
                case (int)SizeUnit.Kilobyte: labelSpaceDiffUnit.Text = Resources.kilobytes; toolStripMenuItemDiffSpaceUnitKilobyte.Checked = true; break;
                case (int)SizeUnit.Megabyte: labelSpaceDiffUnit.Text = Resources.megabytes; toolStripMenuItemDiffSpaceUnitMegabyte.Checked = true; break;
                case (int)SizeUnit.Gigabyte: labelSpaceDiffUnit.Text = Resources.gigabytes; toolStripMenuItemDiffSpaceUnitGigabyte.Checked = true; break;
                case (int)SizeUnit.Terabyte: labelSpaceDiffUnit.Text = Resources.terabytes; toolStripMenuItemDiffSpaceUnitTerabyte.Checked = true; break;
                case (int)SizeUnit.Pentabyte: labelSpaceDiffUnit.Text = Resources.pentabytes; toolStripMenuItemDiffSpaceUnitPentabyte.Checked = true; break;
                default: labelSpaceDiffUnit.Text = Resources.bytes; toolStripMenuItemDiffSpaceUnitByte.Checked = true; unitDiffSpace = 0; break;
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
        /// Update the information of the disk space
        /// </summary>
        private void UpdateSpaceInfo()
        {
            if (driveC.IsReady)
            {
                diffSpaceOrig = usedSpaceOrig;
                usedSpaceOrig = driveC.TotalSize - driveC.TotalFreeSpace;
                freeSpaceOrig = driveC.TotalFreeSpace;
                totalSpaceOrig = driveC.TotalSize;
                usedSpace = usedSpaceOrig;
                freeSpace = freeSpaceOrig;
                totalSpace = totalSpaceOrig;
                diffSpace = diffSpaceOrig;
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
                switch (unitDiffSpace)
                {
                    case (int)SizeUnit.Kilobyte: diffSpace /= 1024; break;
                    case (int)SizeUnit.Megabyte: diffSpace = diffSpace / 1024 / 1024; break;
                    case (int)SizeUnit.Gigabyte: diffSpace = diffSpace / 1024 / 1024 / 1024; break;
                    case (int)SizeUnit.Terabyte: diffSpace = diffSpace / 1024 / 1024 / 1024 / 1024; break;
                    case (int)SizeUnit.Pentabyte: diffSpace = diffSpace / 1024 / 1024 / 1024 / 1024 / 1024; break;
                    default: break;
                }
                freeSpacePerc = freeSpaceOrig / totalSpaceOrig * 100;
                usedSpacePerc = 100 - freeSpacePerc;
                progressBarPercentage.Value = (int)usedSpacePerc;
                numberFormat = Resources.numberformatG6;
                labelSpacePercentageValue.Text = $"{usedSpacePerc.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture)} %";
                numberFormat = string.Empty;
                if (HasFraction(number: usedSpace))
                {
                    numberFormat = Resources.numberformatF6;
                }
                textBoxSpaceUsed.Text = usedSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
                numberFormat = string.Empty;
                if (HasFraction(number: freeSpace))
                {
                    numberFormat = Resources.numberformatF6;
                }
                textBoxSpaceFree.Text = freeSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
                numberFormat = string.Empty;
                if (HasFraction(number: totalSpace))
                {
                    numberFormat = Resources.numberformatF6;
                }
                textBoxSpaceTotal.Text = totalSpace.ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
                numberFormat = string.Empty;
                if (HasFraction(number: diffSpace))
                {
                    numberFormat = Resources.numberformatF6;
                }
                usedSpace = usedSpaceOrig;
                switch (unitDiffSpace)
                {
                    case (int)SizeUnit.Kilobyte: usedSpace /= 1024; break;
                    case (int)SizeUnit.Megabyte: usedSpace = usedSpace / 1024 / 1024; break;
                    case (int)SizeUnit.Gigabyte: usedSpace = usedSpace / 1024 / 1024 / 1024; break;
                    case (int)SizeUnit.Terabyte: usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024; break;
                    case (int)SizeUnit.Pentabyte: usedSpace = usedSpace / 1024 / 1024 / 1024 / 1024 / 1024; break;
                    default: break;
                }
                textBoxSpaceDiff.Text = Math.Abs(diffSpace - usedSpace).ToString(format: numberFormat, provider: CultureInfo.InvariantCulture);
            }

        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm() => InitializeComponent();

        #endregion

        #region Load event handler

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
                fileSystemWatcher.Path = driveC.Name;
            }
        }

        #endregion

        #region Enter event handler

        /// <summary>
        /// Detect the accessibility description to set as information text in the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void SetStatusbar_Enter(object sender, EventArgs e)
        {
            string text = string.Empty;
            switch (sender)
            {
                case Control control:
                    text = control.AccessibleDescription;
                    break;
                case ToolStripSplitButton toolStripSplitButton:
                    text = toolStripSplitButton.AccessibleDescription;
                    break;
                case ToolStripButton toolStripButton:
                    text = toolStripButton.AccessibleDescription;
                    break;
                case ToolStripLabel toolStripLabel:
                    text = toolStripLabel.AccessibleDescription;
                    break;
                case ToolStripMenuItem toolStripMenuItem:
                    text = toolStripMenuItem.AccessibleDescription;
                    break;
            }
            SetStatusbarText(text: text);
        }

        #endregion

        #region Leave event handlers

        /// <summary>
        /// Clear the information text of the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

        #endregion

        #region Click event handlers

        /// <summary>
        /// Set the next unit for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void LabelSpaceUsedUnit_Click(object sender, EventArgs e)
        {
            unitUsedSpace++;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the next unit for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void LabelSpaceFreeUnit_Click(object sender, EventArgs e)
        {
            unitFreeSpace++;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the next unit for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void LabelSpaceTotalUnit_Click(object sender, EventArgs e)
        {
            unitTotalSpace++;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the next unit for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void LabelSpaceDiffUnit_Click(object sender, EventArgs e)
        {
            unitDiffSpace++;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'byte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitByte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Byte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'kilobyte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitKilobyte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Kilobyte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'megabyte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitMegabyte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Megabyte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'gigabyte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitGigabyte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Gigabyte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'tera byte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitTerabyte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Terabyte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'penta byte' for the used space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemUsedSpaceUnitPentabyte_Click(object sender, EventArgs e)
        {
            unitUsedSpace = (int)SizeUnit.Pentabyte;
            UncheckContextMenuForUsedSpaceUnits();
            CaseUsedSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'byte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitByte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Byte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'kilobyte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitKilobyte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Kilobyte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'megabyte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitMegabyte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Megabyte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'gigabyte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitGigabyte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Gigabyte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'tera byte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitTerabyte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Terabyte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'penta byte' for the free space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemFreeSpaceUnitPentabyte_Click(object sender, EventArgs e)
        {
            unitFreeSpace = (int)SizeUnit.Pentabyte;
            UncheckContextMenuForFreeSpaceUnits();
            CaseFreeSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'byte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitByte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Byte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'kilobyte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitKilobyte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Kilobyte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'megabyte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitMegabyte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Megabyte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'gigabyte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitGigabyte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Gigabyte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'terabyte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitTerabyte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Terabyte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'penta byte' for the total space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemTotalSpaceUnitPentabyte_Click(object sender, EventArgs e)
        {
            unitTotalSpace = (int)SizeUnit.Pentabyte;
            UncheckContextMenuForTotalSpaceUnits();
            CaseTotalSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'byte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitByte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Byte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'kilobyte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitKilobyte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Kilobyte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Open the program information window
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripButtonInfo_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm aboutBoxForm = new AboutBoxForm())
            {
                aboutBoxForm.TopMost = TopMost;
                aboutBoxForm.ShowDialog();
            }
        }

        /// <summary>
        /// Set the unit 'megabyte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitMegabyte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Megabyte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'gigabyte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitGigabyte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Gigabyte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'tera byte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitTerabyte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Terabyte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        /// <summary>
        /// Set the unit 'penta byte' for the diff space
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDiffSpaceUnitPentabyte_Click(object sender, EventArgs e)
        {
            unitDiffSpace = (int)SizeUnit.Pentabyte;
            UncheckContextMenuForDiffSpaceUnits();
            CaseDiffSpaceUnits();
        }

        #endregion

        #region ButtonClick event handler

        /// <summary>
        /// Open the setting window and apply the settings
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
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
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        #endregion

        #region CheckedChanged event handlers

        /// <summary>
        /// Set window in foreground if the option "stay on top" is enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuitemStayOnTop_CheckedChanged(object sender, EventArgs e) => TopMost = menuitemStayOnTop.Checked;

        #endregion

        #region Resize event handlers

        /// <summary>
        /// If the option 'minimize to system tray' is enabled, minimize to system tray
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
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
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

        /// <summary>
        /// Update information about the disk using FileSystemWatcher event
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

        /// <summary>
        /// Update information about the disk using FileSystemWatcher event
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) => UpdateSpaceInfo();

        /// <summary>
        /// Update information about the disk using FileSystemWatcher event
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e) => UpdateSpaceInfo();

        #endregion
    }
}
