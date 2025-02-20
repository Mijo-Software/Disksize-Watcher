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
		private DriveInfo drive = new(driveName: "c");

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
		/// Unchecks all drive buttons in the ToolStrip.
		/// </summary>
		private void UncheckAllDriveButtons()
		{
			toolStripButtonDriveA.Checked = false;
			toolStripButtonDriveB.Checked = false;
			toolStripButtonDriveC.Checked = false;
			toolStripButtonDriveD.Checked = false;
			toolStripButtonDriveE.Checked = false;
			toolStripButtonDriveF.Checked = false;
			toolStripButtonDriveG.Checked = false;
			toolStripButtonDriveH.Checked = false;
			toolStripButtonDriveI.Checked = false;
			toolStripButtonDriveJ.Checked = false;
			toolStripButtonDriveK.Checked = false;
			toolStripButtonDriveL.Checked = false;
			toolStripButtonDriveM.Checked = false;
			toolStripButtonDriveN.Checked = false;
			toolStripButtonDriveO.Checked = false;
			toolStripButtonDriveP.Checked = false;
			toolStripButtonDriveQ.Checked = false;
			toolStripButtonDriveR.Checked = false;
			toolStripButtonDriveS.Checked = false;
			toolStripButtonDriveT.Checked = false;
			toolStripButtonDriveU.Checked = false;
			toolStripButtonDriveV.Checked = false;
			toolStripButtonDriveW.Checked = false;
			toolStripButtonDriveX.Checked = false;
			toolStripButtonDriveY.Checked = false;
			toolStripButtonDriveZ.Checked = false;
		}

		/// <summary>
		/// Hides all drive buttons in the ToolStrip.
		/// </summary>
		private void UnvisibleAllDriveButtons()
		{
			toolStripButtonDriveA.Visible = false;
			toolStripButtonDriveB.Visible = false;
			toolStripButtonDriveC.Visible = false;
			toolStripButtonDriveD.Visible = false;
			toolStripButtonDriveE.Visible = false;
			toolStripButtonDriveF.Visible = false;
			toolStripButtonDriveG.Visible = false;
			toolStripButtonDriveH.Visible = false;
			toolStripButtonDriveI.Visible = false;
			toolStripButtonDriveJ.Visible = false;
			toolStripButtonDriveK.Visible = false;
			toolStripButtonDriveL.Visible = false;
			toolStripButtonDriveM.Visible = false;
			toolStripButtonDriveN.Visible = false;
			toolStripButtonDriveO.Visible = false;
			toolStripButtonDriveP.Visible = false;
			toolStripButtonDriveQ.Visible = false;
			toolStripButtonDriveR.Visible = false;
			toolStripButtonDriveS.Visible = false;
			toolStripButtonDriveT.Visible = false;
			toolStripButtonDriveU.Visible = false;
			toolStripButtonDriveV.Visible = false;
			toolStripButtonDriveW.Visible = false;
			toolStripButtonDriveX.Visible = false;
			toolStripButtonDriveY.Visible = false;
			toolStripButtonDriveZ.Visible = false;
		}

		/// <summary>
		/// Lists all drives on the system and updates the ToolStrip buttons to reflect the available drives.
		/// </summary>
		private void ListAllDrives()
		{
			/*
			_ = driveTemp.IsReady;
			if (isReady)
			{
				_ = drive.TotalSize;
				_ = drive.TotalFreeSpace;
				_ = drive.AvailableFreeSpace;
			}
			_ = drive.DriveFormat;
			_ = drive.DriveType;
			_ = drive.Name;
			_ = drive.VolumeLabel;
			_ = drive.RootDirectory;
			_ = drive.IsReady;
			_ = drive.DriveType;
			_ = drive.DriveType == DriveType.Network;
			_ = drive.DriveType == DriveType.CDRom;
			_ = drive.DriveType == DriveType.Removable;
			_ = drive.DriveType == DriveType.Ram;
			_ = drive.DriveType == DriveType.Unknown;
			 */
			try
			{
				DriveInfo[] allDrives = DriveInfo.GetDrives();
				bool firstDrive = true;

				foreach (DriveInfo driveTemp in allDrives)
				{
					try
					{
						bool isFixed = driveTemp.DriveType == DriveType.Fixed;

						if (driveTemp.Name.Equals(value: toolStripButtonDriveA.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveA.Text = driveTemp.Name;
							toolStripButtonDriveA.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveA.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveB.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveB.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveB.Text = driveTemp.Name;
							toolStripButtonDriveB.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveB.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveC.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveC.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveC.Text = driveTemp.Name;
							toolStripButtonDriveC.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveC.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveD.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveD.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveD.Text = driveTemp.Name;
							toolStripButtonDriveD.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveD.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveE.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveE.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveE.Text = driveTemp.Name;
							toolStripButtonDriveE.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveE.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveF.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveF.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveF.Text = driveTemp.Name;
							toolStripButtonDriveF.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveF.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveG.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveG.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveG.Text = driveTemp.Name;
							toolStripButtonDriveG.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveG.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveH.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveH.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveH.Text = driveTemp.Name;
							toolStripButtonDriveH.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveH.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveI.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveI.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveI.Text = driveTemp.Name;
							toolStripButtonDriveI.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveI.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveJ.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveJ.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveJ.Text = driveTemp.Name;
							toolStripButtonDriveJ.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveJ.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveK.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveK.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveK.Text = driveTemp.Name;
							toolStripButtonDriveK.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveK.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveL.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveL.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveL.Text = driveTemp.Name;
							toolStripButtonDriveL.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveL.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveM.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveM.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveM.Text = driveTemp.Name;
							toolStripButtonDriveM.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveM.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveN.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveN.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveN.Text = driveTemp.Name;
							toolStripButtonDriveN.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveN.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveO.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveO.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveO.Text = driveTemp.Name;
							toolStripButtonDriveO.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveO.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveP.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveP.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveP.Text = driveTemp.Name;
							toolStripButtonDriveP.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveP.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveQ.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveQ.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveQ.Text = driveTemp.Name;
							toolStripButtonDriveQ.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveQ.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveR.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveR.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveR.Text = driveTemp.Name;
							toolStripButtonDriveR.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveR.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveS.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveS.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveS.Text = driveTemp.Name;
							toolStripButtonDriveS.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveS.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveT.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveT.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveT.Text = driveTemp.Name;
							toolStripButtonDriveT.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveT.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveU.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveU.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveU.Text = driveTemp.Name;
							toolStripButtonDriveU.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveU.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveV.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveV.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveV.Text = driveTemp.Name;
							toolStripButtonDriveV.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveV.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveW.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveW.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveW.Text = driveTemp.Name;
							toolStripButtonDriveW.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveW.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveX.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveX.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveX.Text = driveTemp.Name;
							toolStripButtonDriveX.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveX.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveY.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveY.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveY.Text = driveTemp.Name;
							toolStripButtonDriveY.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveY.Checked = true;
								firstDrive = false;
							}
						}

						if (driveTemp.Name.Equals(value: toolStripButtonDriveZ.Tag?.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase) && isFixed)
						{
							toolStripButtonDriveZ.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							toolStripButtonDriveZ.Text = driveTemp.Name;
							toolStripButtonDriveZ.Visible = true;
							if (firstDrive)
							{
								toolStripButtonDriveZ.Checked = true;
								firstDrive = false;
							}
						}
					}
					catch (Exception ex)
					{
						// Log the exception for the current drive
						Logger.Error(ex, $"Error processing drive {driveTemp.Name}");
					}
				}
			}
			catch (Exception ex)
			{
				// Log the exception for the entire method
				Logger.Error(ex, "Error listing all drives");
			}
		}

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			try
			{
				labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
				labelInformation.Text = text;
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error setting status bar text");
			}
		}

		/// <summary>
		/// Set up the number with a fraction
		/// </summary>
		private void SetUpNumberWithFraction()
		{
			try
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
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error setting up number with fraction");
			}
		}

		/// <summary>
		/// Set up the number without a fraction
		/// </summary>
		private void SetUpNumberWithoutFraction()
		{
			try
			{
				if (toolStripButtonThousandSeparator.Checked)
				{
					numberFormat = Resources.numberformatN0;
				}
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error setting up number without fraction");
			}
		}

		/// <summary>
		/// Show the value of the spaces in the specified unit
		/// </summary>
		/// <param name="unit">The unit to display the values in</param>
		private void ShowValueInUnit(SizeUnit unit)
		{
			try
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
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error showing value in unit");
			}
		}

		/// <summary>
		/// Update the decimal separator to the specified number of places
		/// </summary>
		/// <param name="places">The number of decimal places</param>
		private void UpdateDecimalSeparator(int places)
		{
			try
			{
				ToolStripMenuItem[] menuItems =
				[
					toolStripMenuItemDecimalSeparatorTo0,
					toolStripMenuItemDecimalSeparatorTo1,
					toolStripMenuItemDecimalSeparatorTo2,
					toolStripMenuItemDecimalSeparatorTo3,
					toolStripMenuItemDecimalSeparatorTo4,toolStripMenuItemDecimalSeparatorTo5,
					toolStripMenuItemDecimalSeparatorTo6
				];

				for (int i = 0; i < menuItems.Length; i++)
				{
					menuItems[i].Checked = i == places;
				}
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error updating decimal separator");
			}
		}


		/// <summary>
		/// Update the information of the disk space
		/// </summary>
		/// <summary>
		/// Update the information of the disk space
		/// </summary>
		private void UpdateSpaceInfo()
		{
			try
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
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error updating space information");
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
			UnvisibleAllDriveButtons();
			ListAllDrives();
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
			try
			{
				SetStatusbarText(text: string.Empty);
				notifyIcon.Visible = false;

				if (drive.IsReady)
				{
					textBoxSpaceTotal.Text = drive.TotalSize.ToString(provider: CultureInfo.CurrentCulture);
					fileSystemWatcher.Path = drive.Name;
				}
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error loading main form");
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
			try
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
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbarText(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripButton { AccessibleDescription: { } } control5)
				{
					SetStatusbarText(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control6)
				{
					SetStatusbarText(text: control6.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control7)
				{
					SetStatusbarText(text: control7.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error setting status bar text on enter");
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

		/// <summary>
		/// Handles the click event for the Drive A button.
		/// Unchecks all drive buttons, checks the Drive A button, and sets the drive to "A".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveA_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveA.Checked = true;
			drive = new DriveInfo(driveName: "A");
		}

		/// <summary>
		/// Handles the click event for the Drive B button.
		/// Unchecks all drive buttons, checks the Drive B button, and sets the drive to "B".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveB_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveB.Checked = true;
			drive = new DriveInfo(driveName: "B");
		}

		/// <summary>
		/// Handles the click event for the Drive C button.
		/// Unchecks all drive buttons, checks the Drive C button, and sets the drive to "C".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveC_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveC.Checked = true;
			drive = new DriveInfo(driveName: "C");
		}

		/// <summary>
		/// Handles the click event for the Drive D button.
		/// Unchecks all drive buttons, checks the Drive D button, and sets the drive to "D".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveD_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveD.Checked = true;
			drive = new DriveInfo(driveName: "D");
		}

		/// <summary>
		/// Handles the click event for the Drive E button.
		/// Unchecks all drive buttons, checks the Drive E button, and sets the drive to "E".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveE_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveE.Checked = true;
			drive = new DriveInfo(driveName: "E");
		}

		/// <summary>
		/// Handles the click event for the Drive F button.
		/// Unchecks all drive buttons, checks the Drive F button, and sets the drive to "F".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveF_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveF.Checked = true;
			drive = new DriveInfo(driveName: "F");
		}

		/// <summary>
		/// Handles the click event for the Drive G button.
		/// Unchecks all drive buttons, checks the Drive G button, and sets the drive to "G".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveG_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveG.Checked = true;
			drive = new DriveInfo(driveName: "G");
		}

		/// <summary>
		/// Handles the click event for the Drive H button.
		/// Unchecks all drive buttons, checks the Drive H button, and sets the drive to "H".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveH_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveH.Checked = true;
			drive = new DriveInfo(driveName: "H");
		}

		/// <summary>
		/// Handles the click event for the Drive I button.
		/// Unchecks all drive buttons, checks the Drive I button, and sets the drive to "I".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveI_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveI.Checked = true;
			drive = new DriveInfo(driveName: "I");
		}

		/// <summary>
		/// Handles the click event for the Drive J button.
		/// Unchecks all drive buttons, checks the Drive J button, and sets the drive to "J".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveJ_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveJ.Checked = true;
			drive = new DriveInfo(driveName: "J");
		}

		/// <summary>
		/// Handles the click event for the Drive K button.
		/// Unchecks all drive buttons, checks the Drive K button, and sets the drive to "K".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveK_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveK.Checked = true;
			drive = new DriveInfo(driveName: "K");
		}

		/// <summary>
		/// Handles the click event for the Drive L button.
		/// Unchecks all drive buttons, checks the Drive L button, and sets the drive to "L".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveL_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveL.Checked = true;
			drive = new DriveInfo(driveName: "L");
		}

		/// <summary>
		/// Handles the click event for the Drive M button.
		/// Unchecks all drive buttons, checks the Drive M button, and sets the drive to "M".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveM_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveM.Checked = true;
			drive = new DriveInfo(driveName: "M");
		}

		/// <summary>
		/// Handles the click event for the Drive N button.
		/// Unchecks all drive buttons, checks the Drive N button, and sets the drive to "N".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveN_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveN.Checked = true;
			drive = new DriveInfo(driveName: "N");
		}

		/// <summary>
		/// Handles the click event for the Drive O button.
		/// Unchecks all drive buttons, checks the Drive O button, and sets the drive to "O".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveO_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveO.Checked = true;
			drive = new DriveInfo(driveName: "O");
		}

		/// <summary>
		/// Handles the click event for the Drive P button.
		/// Unchecks all drive buttons, checks the Drive P button, and sets the drive to "P".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveP_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveP.Checked = true;
			drive = new DriveInfo(driveName: "P");
		}

		/// <summary>
		/// Handles the click event for the Drive Q button.
		/// Unchecks all drive buttons, checks the Drive Q button, and sets the drive to "Q".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveQ_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveQ.Checked = true;
			drive = new DriveInfo(driveName: "Q");
		}

		/// <summary>
		/// Handles the click event for the Drive R button.
		/// Unchecks all drive buttons, checks the Drive R button, and sets the drive to "R".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveR_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveR.Checked = true;
			drive = new DriveInfo(driveName: "R");
		}

		/// <summary>
		/// Handles the click event for the Drive S button.
		/// Unchecks all drive buttons, checks the Drive S button, and sets the drive to "S".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveS_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveS.Checked = true;
			drive = new DriveInfo(driveName: "S");
		}

		/// <summary>
		/// Handles the click event for the Drive T button.
		/// Unchecks all drive buttons, checks the Drive T button, and sets the drive to "T".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveT_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveT.Checked = true;
			drive = new DriveInfo(driveName: "T");
		}

		/// <summary>
		/// Handles the click event for the Drive U button.
		/// Unchecks all drive buttons, checks the Drive U button, and sets the drive to "U".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveU_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveU.Checked = true;
			drive = new DriveInfo(driveName: "U");
		}

		/// <summary>
		/// Handles the click event for the Drive V button.
		/// Unchecks all drive buttons, checks the Drive V button, and sets the drive to "V".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveV_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveV.Checked = true;
			drive = new DriveInfo(driveName: "V");
		}

		/// <summary>
		/// Handles the click event for the Drive W button.
		/// Unchecks all drive buttons, checks the Drive W button, and sets the drive to "W".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveW_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveW.Checked = true;
			drive = new DriveInfo(driveName: "W");
		}

		/// <summary>
		/// Handles the click event for the Drive X button.
		/// Unchecks all drive buttons, checks the Drive X button, and sets the drive to "X".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveX_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveX.Checked = true;
			drive = new DriveInfo(driveName: "X");
		}

		/// <summary>
		/// Handles the click event for the Drive Y button.
		/// Unchecks all drive buttons, checks the Drive Y button, and sets the drive to "Y".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveY_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveY.Checked = true;
			drive = new DriveInfo(driveName: "Y");
		}

		/// <summary>
		/// Handles the click event for the Drive Z button.
		/// Unchecks all drive buttons, checks the Drive Z button, and sets the drive to "Z".
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event data.</param>
		private void ToolStripButtonDriveZ_Click(object sender, EventArgs e)
		{
			UncheckAllDriveButtons();
			toolStripButtonDriveZ.Checked = true;
			drive = new DriveInfo(driveName: "Z");
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
			try
			{
				Show();
				WindowState = FormWindowState.Normal;
				notifyIcon.Visible = false;
			}
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error handling notify icon double click");
			}
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
			try
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
			catch (Exception ex)
			{
				// Log the exception
				Logger.Error(ex, "Error handling form resize");
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