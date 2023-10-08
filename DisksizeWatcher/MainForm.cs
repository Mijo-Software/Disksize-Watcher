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
        /// <summary>
        /// Drive information
        /// </summary>
        private readonly DriveInfo drive = new DriveInfo(driveName: "C");

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
        /// Choose the correct unit for the diff space
        /// </summary>
        private void CaseSpaceUnits()
        {
            switch (unitSpace)
            {
                case (int)SizeUnit.Byte:
                    labelSpaceUsedUnit.Text = Resources.bytes;
                    labelSpaceFreeUnit.Text = Resources.bytes;
                    labelSpaceTotalUnit.Text = Resources.bytes;
                    labelSpaceDiffUnit.Text = Resources.bytes;
                    break;
                case (int)SizeUnit.Kilobyte:
                    labelSpaceUsedUnit.Text = Resources.kilobytes;
                    labelSpaceFreeUnit.Text = Resources.kilobytes;
                    labelSpaceTotalUnit.Text = Resources.kilobytes;
                    labelSpaceDiffUnit.Text = Resources.kilobytes;
                    break;
                case (int)SizeUnit.Megabyte:
                    labelSpaceUsedUnit.Text = Resources.megabytes;
                    labelSpaceFreeUnit.Text = Resources.megabytes;
                    labelSpaceTotalUnit.Text = Resources.megabytes;
                    labelSpaceDiffUnit.Text = Resources.megabytes;
                    break;
                case (int)SizeUnit.Gigabyte:
                    labelSpaceUsedUnit.Text = Resources.gigabytes;
                    labelSpaceFreeUnit.Text = Resources.gigabytes;
                    labelSpaceTotalUnit.Text = Resources.gigabytes;
                    labelSpaceDiffUnit.Text = Resources.gigabytes;
                    break;
                case (int)SizeUnit.Terabyte:
                    labelSpaceUsedUnit.Text = Resources.terabytes;
                    labelSpaceFreeUnit.Text = Resources.terabytes;
                    labelSpaceTotalUnit.Text = Resources.terabytes;
                    labelSpaceDiffUnit.Text = Resources.terabytes;
                    break;
                case (int)SizeUnit.Pentabyte:
                    labelSpaceUsedUnit.Text = Resources.pentabytes;
                    labelSpaceFreeUnit.Text = Resources.pentabytes;
                    labelSpaceTotalUnit.Text = Resources.pentabytes;
                    labelSpaceDiffUnit.Text = Resources.pentabytes;
                    break;
                default:
                    labelSpaceUsedUnit.Text = Resources.bytes;
                    labelSpaceFreeUnit.Text = Resources.bytes;
                    labelSpaceTotalUnit.Text = Resources.bytes;
                    labelSpaceDiffUnit.Text = Resources.bytes;
                    unitSpace = 0;
                    break;
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
            if (toolStripButtonThousandSeparator.Checked)
            {
                if (toolStripMenuItemDecimalSeparatorTo0.Checked)
                {
                    numberFormat = Resources.numberformatN0;
                }
                else if (toolStripMenuItemDecimalSeparatorTo1.Checked)
                {
                    numberFormat = Resources.numberformatN1;
                }
                else if (toolStripMenuItemDecimalSeparatorTo2.Checked)
                {
                    numberFormat = Resources.numberformatN2;
                }
                else if (toolStripMenuItemDecimalSeparatorTo3.Checked)
                {
                    numberFormat = Resources.numberformatN3;
                }
                else if (toolStripMenuItemDecimalSeparatorTo4.Checked)
                {
                    numberFormat = Resources.numberformatN4;
                }
                else if (toolStripMenuItemDecimalSeparatorTo5.Checked)
                {
                    numberFormat = Resources.numberformatN5;
                }
                else if (toolStripMenuItemDecimalSeparatorTo6.Checked)
                {
                    numberFormat = Resources.numberformatN6;
                }
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo0.Checked)
            {
                numberFormat = Resources.numberformatF0;
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo1.Checked)
            {
                numberFormat = Resources.numberformatF1;
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo2.Checked)
            {
                numberFormat = Resources.numberformatF2;
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo3.Checked)
            {
                numberFormat = Resources.numberformatF3;
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo4.Checked)
            {
                numberFormat = Resources.numberformatF4;
                return;
            }
            if (toolStripMenuItemDecimalSeparatorTo5.Checked)
            {
                numberFormat = Resources.numberformatF5;
                return;
            }
            if (!toolStripMenuItemDecimalSeparatorTo6.Checked)
            {
                return;
            }
            numberFormat = Resources.numberformatF6;
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
                textBoxSpaceDiff.Text = Math.Abs(diffSpace - usedSpace)
                    .ToString(format: numberFormat, provider: CultureInfo.CurrentCulture);
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
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void SetStatusbar_Enter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox textBox:
                    SetStatusbarText(text: textBox.AccessibleDescription);
                    break;
                case Button button:
                    SetStatusbarText(text: button.AccessibleDescription);
                    break;
                case RadioButton radioButton:
                    SetStatusbarText(text: radioButton.AccessibleDescription);
                    break;
                case CheckBox checkBox:
                    SetStatusbarText(text: checkBox.AccessibleDescription);
                    break;
                case DateTimePicker dateTimePicker:
                    SetStatusbarText(text: dateTimePicker.AccessibleDescription);
                    break;
                case Label label:
                    SetStatusbarText(text: label.AccessibleDescription);
                    break;
                case PictureBox pictureBox:
                    SetStatusbarText(text: pictureBox.AccessibleDescription);
                    break;
                case CheckedListBox checkedListBox:
                    SetStatusbarText(text: checkedListBox.AccessibleDescription);
                    break;
                case ComboBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case DataGridView view:
                    SetStatusbarText(text: view.AccessibleDescription);
                    break;
                case GroupBox group:
                    SetStatusbarText(text: group.AccessibleDescription);
                    break;
                case ListBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case ListView view:
                    SetStatusbarText(text: view.AccessibleDescription);
                    break;
                case MaskedTextBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case NumericUpDown numericUpDown:
                    SetStatusbarText(text: numericUpDown.AccessibleDescription);
                    break;
                case MonthCalendar monthCalendar:
                    SetStatusbarText(text: monthCalendar.AccessibleDescription);
                    break;
                case PropertyGrid propertyGrid:
                    SetStatusbarText(text: propertyGrid.AccessibleDescription);
                    break;
                case RichTextBox richTextBox:
                    SetStatusbarText(text: richTextBox.AccessibleDescription);
                    break;
                case ScrollBar scrollBar:
                    SetStatusbarText(text: scrollBar.AccessibleDescription);
                    break;
                case TrackBar trackBar:
                    SetStatusbarText(text: trackBar.AccessibleDescription);
                    break;
                case WebBrowser webBrowser:
                    SetStatusbarText(text: webBrowser.AccessibleDescription);
                    break;
                case DomainUpDown domainUpDown:
                    SetStatusbarText(text: domainUpDown.AccessibleDescription);
                    break;
                case ToolStripButton toolStripButton:
                    SetStatusbarText(text: toolStripButton.AccessibleDescription);
                    break;
                case ToolStripMenuItem toolStripMenuItem:
                    SetStatusbarText(text: toolStripMenuItem.AccessibleDescription);
                    break;
                case ToolStripLabel toolStripLabel:
                    SetStatusbarText(text: toolStripLabel.AccessibleDescription);
                    break;
                case ToolStripComboBox toolStripComboBox:
                    SetStatusbarText(text: toolStripComboBox.AccessibleDescription);
                    break;
                case ToolStripDropDown toolStripDropDown:
                    SetStatusbarText(text: toolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripDropDownButton toolStripDropDownButton:
                    SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription);
                    break;
                case ToolStripDropDownItem toolStripDropDownItem:
                    SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription);
                    break;
                case ToolStripProgressBar progressBar:
                    SetStatusbarText(text: progressBar.AccessibleDescription);
                    break;
                case ToolStripSeparator toolStripSeparator:
                    SetStatusbarText(text: toolStripSeparator.AccessibleDescription);
                    break;
                case ToolStripTextBox toolStripTextBox:
                    SetStatusbarText(text: toolStripTextBox.AccessibleDescription);
                    break;
            }
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
        /// Show the value of the spaces in byte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInByte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Byte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = true;
            toolStripButtonShowValueInKilobyte.Checked = false;
            toolStripButtonShowValueInMegabyte.Checked = false;
            toolStripButtonShowValueInGigabyte.Checked = false;
            toolStripButtonShowValueInTerabyte.Checked = false;
            toolStripButtonShowValueInPentabyte.Checked = false;
        }

        /// <summary>
        /// Show the value of the spaces in kilobyte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInKilobyte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Kilobyte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = false;
            toolStripButtonShowValueInKilobyte.Checked = true;
            toolStripButtonShowValueInMegabyte.Checked = false;
            toolStripButtonShowValueInGigabyte.Checked = false;
            toolStripButtonShowValueInTerabyte.Checked = false;
            toolStripButtonShowValueInPentabyte.Checked = false;
        }

        /// <summary>
        /// Show the value of the spaces in megabyte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInMegabyte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Megabyte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = false;
            toolStripButtonShowValueInKilobyte.Checked = false;
            toolStripButtonShowValueInMegabyte.Checked = true;
            toolStripButtonShowValueInGigabyte.Checked = false;
            toolStripButtonShowValueInTerabyte.Checked = false;
            toolStripButtonShowValueInPentabyte.Checked = false;
        }

        /// <summary>
        /// Show the value of the spaces in gigabyte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInGigabyte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Gigabyte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = false;
            toolStripButtonShowValueInKilobyte.Checked = false;
            toolStripButtonShowValueInMegabyte.Checked = false;
            toolStripButtonShowValueInGigabyte.Checked = true;
            toolStripButtonShowValueInTerabyte.Checked = false;
            toolStripButtonShowValueInPentabyte.Checked = false;
        }

        /// <summary>
        /// Show the value of the spaces in terabyte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInTerabyte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Terabyte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = false;
            toolStripButtonShowValueInKilobyte.Checked = false;
            toolStripButtonShowValueInMegabyte.Checked = false;
            toolStripButtonShowValueInGigabyte.Checked = false;
            toolStripButtonShowValueInTerabyte.Checked = true;
            toolStripButtonShowValueInPentabyte.Checked = false;
        }

        /// <summary>
        /// Show the value of the spaces in pentabyte
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripButtonShowValueInPentabyte_Click(object sender, EventArgs e)
        {
            unitSpace = (short)SizeUnit.Pentabyte;
            CaseSpaceUnits();
            toolStripButtonShowValueInByte.Checked = false;
            toolStripButtonShowValueInKilobyte.Checked = false;
            toolStripButtonShowValueInMegabyte.Checked = false;
            toolStripButtonShowValueInGigabyte.Checked = false;
            toolStripButtonShowValueInTerabyte.Checked = false;
            toolStripButtonShowValueInPentabyte.Checked = true;
        }

        /// <summary>
        /// Update the decimal separator to 0 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo0_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 1 place
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo1_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 2 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo2_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 3 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo3_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 4 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo4_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 5 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo5_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo6.Checked = false;
        }

        /// <summary>
        /// Update the decimal separator to 6 places
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void ToolStripMenuItemDecimalSeparatorTo6_Click(object sender, EventArgs e)
        {
            toolStripMenuItemDecimalSeparatorTo0.Checked = false;
            toolStripMenuItemDecimalSeparatorTo1.Checked = false;
            toolStripMenuItemDecimalSeparatorTo2.Checked = false;
            toolStripMenuItemDecimalSeparatorTo3.Checked = false;
            toolStripMenuItemDecimalSeparatorTo4.Checked = false;
            toolStripMenuItemDecimalSeparatorTo5.Checked = false;
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
