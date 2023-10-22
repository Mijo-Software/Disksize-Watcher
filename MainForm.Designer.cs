namespace DisksizeWatcher
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			labelSpaceFree = new Label();
			notifyIcon = new NotifyIcon(components);
			textBoxSpaceFree = new TextBox();
			textBoxSpaceTotal = new TextBox();
			labelSpaceTotal = new Label();
			labelSpaceFreeUnit = new Label();
			labelSpaceTotalUnit = new Label();
			labelSpacePercentage = new Label();
			progressBarPercentage = new ProgressBar();
			labelSpacePercentageValue = new Label();
			labelSpaceUsedUnit = new Label();
			textBoxSpaceUsed = new TextBox();
			labelSpaceUsed = new Label();
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			labelSpaceDiff = new Label();
			textBoxSpaceDiff = new TextBox();
			labelSpaceDiffUnit = new Label();
			fileSystemWatcher = new FileSystemWatcher();
			toolStripContainer = new ToolStripContainer();
			toolStrip = new ToolStrip();
			toolStripButtonInfo = new ToolStripButton();
			toolStripButtonLicense = new ToolStripButton();
			toolStripSplitButtonSettings = new ToolStripSplitButton();
			menuitemStayOnTop = new ToolStripMenuItem();
			menuitemMinimizeToSystemTray = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonShowValueInByte = new ToolStripButton();
			toolStripButtonShowValueInKilobyte = new ToolStripButton();
			toolStripButtonShowValueInMegabyte = new ToolStripButton();
			toolStripButtonShowValueInGigabyte = new ToolStripButton();
			toolStripButtonShowValueInTerabyte = new ToolStripButton();
			toolStripButtonShowValueInPentabyte = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripButtonThousandSeparator = new ToolStripButton();
			toolStripDropDownButtonDecimalSeparator = new ToolStripDropDownButton();
			toolStripMenuItemDecimalSeparatorTo0 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo1 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo2 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo3 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo4 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo5 = new ToolStripMenuItem();
			toolStripMenuItemDecimalSeparatorTo6 = new ToolStripMenuItem();
			statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher).BeginInit();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			toolStrip.SuspendLayout();
			SuspendLayout();
			// 
			// labelSpaceFree
			// 
			labelSpaceFree.AccessibleDescription = "Show the free space";
			labelSpaceFree.AccessibleName = "free space";
			labelSpaceFree.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceFree.AutoEllipsis = true;
			labelSpaceFree.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceFree.Location = new Point(4, 42);
			labelSpaceFree.Margin = new Padding(4, 0, 4, 0);
			labelSpaceFree.Name = "labelSpaceFree";
			labelSpaceFree.Size = new Size(74, 15);
			labelSpaceFree.TabIndex = 3;
			labelSpaceFree.Text = "&Free space:";
			toolTip.SetToolTip(labelSpaceFree, "Show the free space");
			labelSpaceFree.Enter += SetStatusbar_Enter;
			labelSpaceFree.Leave += ClearStatusbar_Leave;
			labelSpaceFree.MouseEnter += SetStatusbar_Enter;
			labelSpaceFree.MouseLeave += ClearStatusbar_Leave;
			// 
			// notifyIcon
			// 
			notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
			notifyIcon.Text = "Disksize Watcher";
			notifyIcon.Visible = true;
			notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
			// 
			// textBoxSpaceFree
			// 
			textBoxSpaceFree.AccessibleDescription = "Show the value of the free space";
			textBoxSpaceFree.AccessibleName = "value of the free space";
			textBoxSpaceFree.AccessibleRole = AccessibleRole.Text;
			textBoxSpaceFree.Location = new Point(86, 38);
			textBoxSpaceFree.Margin = new Padding(4, 3, 4, 3);
			textBoxSpaceFree.Name = "textBoxSpaceFree";
			textBoxSpaceFree.ReadOnly = true;
			textBoxSpaceFree.Size = new Size(129, 23);
			textBoxSpaceFree.TabIndex = 4;
			textBoxSpaceFree.TextAlign = HorizontalAlignment.Right;
			toolTip.SetToolTip(textBoxSpaceFree, "Show the value of the free space");
			textBoxSpaceFree.Enter += SetStatusbar_Enter;
			textBoxSpaceFree.Leave += ClearStatusbar_Leave;
			textBoxSpaceFree.MouseEnter += SetStatusbar_Enter;
			textBoxSpaceFree.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSpaceTotal
			// 
			textBoxSpaceTotal.AccessibleDescription = "Show the value of the total space";
			textBoxSpaceTotal.AccessibleName = "value of the total space";
			textBoxSpaceTotal.AccessibleRole = AccessibleRole.Text;
			textBoxSpaceTotal.Location = new Point(86, 68);
			textBoxSpaceTotal.Margin = new Padding(4, 3, 4, 3);
			textBoxSpaceTotal.Name = "textBoxSpaceTotal";
			textBoxSpaceTotal.ReadOnly = true;
			textBoxSpaceTotal.Size = new Size(129, 23);
			textBoxSpaceTotal.TabIndex = 7;
			textBoxSpaceTotal.TextAlign = HorizontalAlignment.Right;
			toolTip.SetToolTip(textBoxSpaceTotal, "Show the value of the total space");
			textBoxSpaceTotal.Enter += SetStatusbar_Enter;
			textBoxSpaceTotal.Leave += ClearStatusbar_Leave;
			textBoxSpaceTotal.MouseEnter += SetStatusbar_Enter;
			textBoxSpaceTotal.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceTotal
			// 
			labelSpaceTotal.AccessibleDescription = "Show the total space";
			labelSpaceTotal.AccessibleName = "total space";
			labelSpaceTotal.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceTotal.AutoEllipsis = true;
			labelSpaceTotal.AutoSize = true;
			labelSpaceTotal.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceTotal.Location = new Point(4, 72);
			labelSpaceTotal.Margin = new Padding(4, 0, 4, 0);
			labelSpaceTotal.Name = "labelSpaceTotal";
			labelSpaceTotal.Size = new Size(68, 15);
			labelSpaceTotal.TabIndex = 6;
			labelSpaceTotal.Text = "&Total space:";
			toolTip.SetToolTip(labelSpaceTotal, "Show the total space");
			labelSpaceTotal.Enter += SetStatusbar_Enter;
			labelSpaceTotal.Leave += ClearStatusbar_Leave;
			labelSpaceTotal.MouseEnter += SetStatusbar_Enter;
			labelSpaceTotal.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceFreeUnit
			// 
			labelSpaceFreeUnit.AccessibleDescription = "Show the unit of the free space";
			labelSpaceFreeUnit.AccessibleName = "unit of the free space";
			labelSpaceFreeUnit.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceFreeUnit.AutoEllipsis = true;
			labelSpaceFreeUnit.AutoSize = true;
			labelSpaceFreeUnit.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceFreeUnit.Location = new Point(223, 42);
			labelSpaceFreeUnit.Margin = new Padding(4, 0, 4, 0);
			labelSpaceFreeUnit.Name = "labelSpaceFreeUnit";
			labelSpaceFreeUnit.Size = new Size(35, 15);
			labelSpaceFreeUnit.TabIndex = 5;
			labelSpaceFreeUnit.Text = "bytes";
			toolTip.SetToolTip(labelSpaceFreeUnit, "Show the unit of the free space");
			labelSpaceFreeUnit.Enter += SetStatusbar_Enter;
			labelSpaceFreeUnit.Leave += ClearStatusbar_Leave;
			labelSpaceFreeUnit.MouseEnter += SetStatusbar_Enter;
			labelSpaceFreeUnit.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceTotalUnit
			// 
			labelSpaceTotalUnit.AccessibleDescription = "Show the unit of the total space";
			labelSpaceTotalUnit.AccessibleName = "unit of the total space";
			labelSpaceTotalUnit.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceTotalUnit.AutoEllipsis = true;
			labelSpaceTotalUnit.AutoSize = true;
			labelSpaceTotalUnit.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceTotalUnit.Location = new Point(223, 72);
			labelSpaceTotalUnit.Margin = new Padding(4, 0, 4, 0);
			labelSpaceTotalUnit.Name = "labelSpaceTotalUnit";
			labelSpaceTotalUnit.Size = new Size(35, 15);
			labelSpaceTotalUnit.TabIndex = 8;
			labelSpaceTotalUnit.Text = "bytes";
			toolTip.SetToolTip(labelSpaceTotalUnit, "Show the unit of the total space");
			labelSpaceTotalUnit.Enter += SetStatusbar_Enter;
			labelSpaceTotalUnit.Leave += ClearStatusbar_Leave;
			labelSpaceTotalUnit.MouseEnter += SetStatusbar_Enter;
			labelSpaceTotalUnit.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpacePercentage
			// 
			labelSpacePercentage.AccessibleDescription = "Show the percentage";
			labelSpacePercentage.AccessibleName = "pecrentage";
			labelSpacePercentage.AccessibleRole = AccessibleRole.StaticText;
			labelSpacePercentage.AutoEllipsis = true;
			labelSpacePercentage.AutoSize = true;
			labelSpacePercentage.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpacePercentage.Location = new Point(6, 128);
			labelSpacePercentage.Margin = new Padding(4, 0, 4, 0);
			labelSpacePercentage.Name = "labelSpacePercentage";
			labelSpacePercentage.Size = new Size(69, 15);
			labelSpacePercentage.TabIndex = 12;
			labelSpacePercentage.Text = "Percentage:";
			toolTip.SetToolTip(labelSpacePercentage, "Show the percentage");
			labelSpacePercentage.Enter += SetStatusbar_Enter;
			labelSpacePercentage.Leave += ClearStatusbar_Leave;
			labelSpacePercentage.MouseEnter += SetStatusbar_Enter;
			labelSpacePercentage.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBarPercentage
			// 
			progressBarPercentage.AccessibleDescription = "Show the state of the percentage";
			progressBarPercentage.AccessibleName = "progress bar";
			progressBarPercentage.AccessibleRole = AccessibleRole.ProgressBar;
			progressBarPercentage.Location = new Point(86, 128);
			progressBarPercentage.Margin = new Padding(4, 3, 4, 3);
			progressBarPercentage.Name = "progressBarPercentage";
			progressBarPercentage.Size = new Size(130, 15);
			progressBarPercentage.Step = 1;
			progressBarPercentage.Style = ProgressBarStyle.Continuous;
			progressBarPercentage.TabIndex = 13;
			toolTip.SetToolTip(progressBarPercentage, "Show the state of the percentage");
			progressBarPercentage.MouseEnter += SetStatusbar_Enter;
			progressBarPercentage.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpacePercentageValue
			// 
			labelSpacePercentageValue.AccessibleDescription = "Show the value of the percentage";
			labelSpacePercentageValue.AccessibleName = "value of the percentage";
			labelSpacePercentageValue.AccessibleRole = AccessibleRole.StaticText;
			labelSpacePercentageValue.AutoEllipsis = true;
			labelSpacePercentageValue.AutoSize = true;
			labelSpacePercentageValue.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpacePercentageValue.Location = new Point(223, 128);
			labelSpacePercentageValue.Margin = new Padding(4, 0, 4, 0);
			labelSpacePercentageValue.Name = "labelSpacePercentageValue";
			labelSpacePercentageValue.Size = new Size(17, 15);
			labelSpacePercentageValue.TabIndex = 14;
			labelSpacePercentageValue.Text = "%";
			toolTip.SetToolTip(labelSpacePercentageValue, "Show the value of the percentage");
			labelSpacePercentageValue.Enter += SetStatusbar_Enter;
			labelSpacePercentageValue.Leave += ClearStatusbar_Leave;
			labelSpacePercentageValue.MouseEnter += SetStatusbar_Enter;
			labelSpacePercentageValue.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceUsedUnit
			// 
			labelSpaceUsedUnit.AccessibleDescription = "Show the unit of the used space";
			labelSpaceUsedUnit.AccessibleName = "unit of the used space";
			labelSpaceUsedUnit.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceUsedUnit.AutoEllipsis = true;
			labelSpaceUsedUnit.AutoSize = true;
			labelSpaceUsedUnit.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceUsedUnit.Location = new Point(223, 12);
			labelSpaceUsedUnit.Margin = new Padding(4, 0, 4, 0);
			labelSpaceUsedUnit.Name = "labelSpaceUsedUnit";
			labelSpaceUsedUnit.Size = new Size(35, 15);
			labelSpaceUsedUnit.TabIndex = 2;
			labelSpaceUsedUnit.Text = "bytes";
			toolTip.SetToolTip(labelSpaceUsedUnit, "Show the unit of the used space");
			labelSpaceUsedUnit.Enter += SetStatusbar_Enter;
			labelSpaceUsedUnit.Leave += ClearStatusbar_Leave;
			labelSpaceUsedUnit.MouseEnter += SetStatusbar_Enter;
			labelSpaceUsedUnit.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSpaceUsed
			// 
			textBoxSpaceUsed.AccessibleDescription = "Show the value of the used space";
			textBoxSpaceUsed.AccessibleName = "value of the used space";
			textBoxSpaceUsed.AccessibleRole = AccessibleRole.Text;
			textBoxSpaceUsed.Location = new Point(86, 8);
			textBoxSpaceUsed.Margin = new Padding(4, 3, 4, 3);
			textBoxSpaceUsed.Name = "textBoxSpaceUsed";
			textBoxSpaceUsed.ReadOnly = true;
			textBoxSpaceUsed.Size = new Size(129, 23);
			textBoxSpaceUsed.TabIndex = 1;
			textBoxSpaceUsed.TextAlign = HorizontalAlignment.Right;
			toolTip.SetToolTip(textBoxSpaceUsed, "Show the value of the used space");
			textBoxSpaceUsed.Enter += SetStatusbar_Enter;
			textBoxSpaceUsed.Leave += ClearStatusbar_Leave;
			textBoxSpaceUsed.MouseEnter += SetStatusbar_Enter;
			textBoxSpaceUsed.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceUsed
			// 
			labelSpaceUsed.AccessibleDescription = "Show the used space";
			labelSpaceUsed.AccessibleName = "used space";
			labelSpaceUsed.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceUsed.AutoEllipsis = true;
			labelSpaceUsed.AutoSize = true;
			labelSpaceUsed.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceUsed.Location = new Point(4, 12);
			labelSpaceUsed.Margin = new Padding(4, 0, 4, 0);
			labelSpaceUsed.Name = "labelSpaceUsed";
			labelSpaceUsed.Size = new Size(69, 15);
			labelSpaceUsed.TabIndex = 0;
			labelSpaceUsed.Text = "&Used space:";
			toolTip.SetToolTip(labelSpaceUsed, "Show the used space");
			labelSpaceUsed.Enter += SetStatusbar_Enter;
			labelSpaceUsed.Leave += ClearStatusbar_Leave;
			labelSpaceUsed.MouseEnter += SetStatusbar_Enter;
			labelSpaceUsed.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Show the status bar";
			statusStrip.AccessibleName = "status bar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.AllowItemReorder = true;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(317, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			toolTip.SetToolTip(statusStrip, "Show the status bar");
			statusStrip.Enter += SetStatusbar_Enter;
			statusStrip.Leave += ClearStatusbar_Leave;
			statusStrip.MouseEnter += SetStatusbar_Enter;
			statusStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(302, 17);
			labelInformation.Spring = true;
			labelInformation.Text = "info";
			labelInformation.TextAlign = ContentAlignment.MiddleLeft;
			labelInformation.MouseEnter += SetStatusbar_Enter;
			labelInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceDiff
			// 
			labelSpaceDiff.AccessibleDescription = "Show the diff space";
			labelSpaceDiff.AccessibleName = "diff space";
			labelSpaceDiff.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceDiff.AutoEllipsis = true;
			labelSpaceDiff.AutoSize = true;
			labelSpaceDiff.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceDiff.Location = new Point(5, 102);
			labelSpaceDiff.Margin = new Padding(4, 0, 4, 0);
			labelSpaceDiff.Name = "labelSpaceDiff";
			labelSpaceDiff.Size = new Size(62, 15);
			labelSpaceDiff.TabIndex = 9;
			labelSpaceDiff.Text = "&Diff space:";
			toolTip.SetToolTip(labelSpaceDiff, "Show the diff space");
			labelSpaceDiff.Enter += SetStatusbar_Enter;
			labelSpaceDiff.Leave += ClearStatusbar_Leave;
			labelSpaceDiff.MouseEnter += SetStatusbar_Enter;
			labelSpaceDiff.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSpaceDiff
			// 
			textBoxSpaceDiff.AccessibleDescription = "Show the value of the diff space";
			textBoxSpaceDiff.AccessibleName = "value of the diff space";
			textBoxSpaceDiff.AccessibleRole = AccessibleRole.Text;
			textBoxSpaceDiff.Location = new Point(86, 98);
			textBoxSpaceDiff.Margin = new Padding(4, 3, 4, 3);
			textBoxSpaceDiff.Name = "textBoxSpaceDiff";
			textBoxSpaceDiff.ReadOnly = true;
			textBoxSpaceDiff.Size = new Size(128, 23);
			textBoxSpaceDiff.TabIndex = 10;
			textBoxSpaceDiff.TextAlign = HorizontalAlignment.Right;
			toolTip.SetToolTip(textBoxSpaceDiff, "Show the value of the diff space");
			textBoxSpaceDiff.Enter += SetStatusbar_Enter;
			textBoxSpaceDiff.Leave += ClearStatusbar_Leave;
			textBoxSpaceDiff.MouseEnter += SetStatusbar_Enter;
			textBoxSpaceDiff.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSpaceDiffUnit
			// 
			labelSpaceDiffUnit.AccessibleDescription = "Show the unit of the diff space";
			labelSpaceDiffUnit.AccessibleName = "unit of the diff space";
			labelSpaceDiffUnit.AccessibleRole = AccessibleRole.StaticText;
			labelSpaceDiffUnit.AutoEllipsis = true;
			labelSpaceDiffUnit.AutoSize = true;
			labelSpaceDiffUnit.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelSpaceDiffUnit.Location = new Point(223, 102);
			labelSpaceDiffUnit.Margin = new Padding(4, 0, 4, 0);
			labelSpaceDiffUnit.Name = "labelSpaceDiffUnit";
			labelSpaceDiffUnit.Size = new Size(35, 15);
			labelSpaceDiffUnit.TabIndex = 11;
			labelSpaceDiffUnit.Text = "bytes";
			toolTip.SetToolTip(labelSpaceDiffUnit, "Show the unit of the used space");
			labelSpaceDiffUnit.Enter += SetStatusbar_Enter;
			labelSpaceDiffUnit.Leave += ClearStatusbar_Leave;
			labelSpaceDiffUnit.MouseEnter += SetStatusbar_Enter;
			labelSpaceDiffUnit.MouseLeave += ClearStatusbar_Leave;
			// 
			// fileSystemWatcher
			// 
			fileSystemWatcher.EnableRaisingEvents = true;
			fileSystemWatcher.IncludeSubdirectories = true;
			fileSystemWatcher.SynchronizingObject = this;
			fileSystemWatcher.Changed += FileSystemWatcher_Changed;
			fileSystemWatcher.Created += FileSystemWatcher_Created;
			fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
			fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Just a container";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceUsed);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceFree);
			toolStripContainer.ContentPanel.Controls.Add(textBoxSpaceFree);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceTotal);
			toolStripContainer.ContentPanel.Controls.Add(textBoxSpaceTotal);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceDiffUnit);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceFreeUnit);
			toolStripContainer.ContentPanel.Controls.Add(textBoxSpaceDiff);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceTotalUnit);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceDiff);
			toolStripContainer.ContentPanel.Controls.Add(labelSpacePercentage);
			toolStripContainer.ContentPanel.Controls.Add(labelSpaceUsedUnit);
			toolStripContainer.ContentPanel.Controls.Add(progressBarPercentage);
			toolStripContainer.ContentPanel.Controls.Add(textBoxSpaceUsed);
			toolStripContainer.ContentPanel.Controls.Add(labelSpacePercentageValue);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(317, 165);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(317, 212);
			toolStripContainer.TabIndex = 16;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.Controls.Add(toolStrip);
			// 
			// toolStrip
			// 
			toolStrip.AccessibleDescription = "Just a tool tip";
			toolStrip.AccessibleName = "tool tip";
			toolStrip.AccessibleRole = AccessibleRole.ToolTip;
			toolStrip.Dock = DockStyle.None;
			toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonInfo, toolStripButtonLicense, toolStripSplitButtonSettings, toolStripSeparator1, toolStripButtonShowValueInByte, toolStripButtonShowValueInKilobyte, toolStripButtonShowValueInMegabyte, toolStripButtonShowValueInGigabyte, toolStripButtonShowValueInTerabyte, toolStripButtonShowValueInPentabyte, toolStripSeparator2, toolStripButtonThousandSeparator, toolStripDropDownButtonDecimalSeparator });
			toolStrip.Location = new Point(0, 0);
			toolStrip.Name = "toolStrip";
			toolStrip.RenderMode = ToolStripRenderMode.System;
			toolStrip.Size = new Size(317, 25);
			toolStrip.Stretch = true;
			toolStrip.TabIndex = 0;
			toolStrip.TabStop = true;
			// 
			// toolStripButtonInfo
			// 
			toolStripButtonInfo.AccessibleDescription = "Open the program information";
			toolStripButtonInfo.AccessibleName = "program information";
			toolStripButtonInfo.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonInfo.Image = Properties.Resources.fatcow_infomation_16;
			toolStripButtonInfo.ImageTransparentColor = Color.Magenta;
			toolStripButtonInfo.Name = "toolStripButtonInfo";
			toolStripButtonInfo.Size = new Size(23, 22);
			toolStripButtonInfo.Text = "Program information";
			toolStripButtonInfo.Click += ToolStripButtonInfo_Click;
			toolStripButtonInfo.MouseEnter += SetStatusbar_Enter;
			toolStripButtonInfo.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonLicense
			// 
			toolStripButtonLicense.AccessibleDescription = "Open the license";
			toolStripButtonLicense.AccessibleName = "License";
			toolStripButtonLicense.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonLicense.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonLicense.Image = Properties.Resources.fatcow_script_16;
			toolStripButtonLicense.ImageTransparentColor = Color.Magenta;
			toolStripButtonLicense.Name = "toolStripButtonLicense";
			toolStripButtonLicense.Size = new Size(23, 22);
			toolStripButtonLicense.Text = "License";
			toolStripButtonLicense.Click += ToolStripButtonLicense_Click;
			toolStripButtonLicense.MouseEnter += SetStatusbar_Enter;
			toolStripButtonLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSplitButtonSettings
			// 
			toolStripSplitButtonSettings.AccessibleDescription = "Click to open the settings";
			toolStripSplitButtonSettings.AccessibleName = "settings";
			toolStripSplitButtonSettings.AccessibleRole = AccessibleRole.PushButton;
			toolStripSplitButtonSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButtonSettings.DropDownItems.AddRange(new ToolStripItem[] { menuitemStayOnTop, menuitemMinimizeToSystemTray });
			toolStripSplitButtonSettings.Image = Properties.Resources.fatcow_wrench_16;
			toolStripSplitButtonSettings.ImageTransparentColor = Color.Magenta;
			toolStripSplitButtonSettings.Name = "toolStripSplitButtonSettings";
			toolStripSplitButtonSettings.Size = new Size(32, 22);
			toolStripSplitButtonSettings.Text = "Settings";
			toolStripSplitButtonSettings.ButtonClick += ToolStripSplitButtonSettings_ButtonClick;
			toolStripSplitButtonSettings.MouseEnter += SetStatusbar_Enter;
			toolStripSplitButtonSettings.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemStayOnTop
			// 
			menuitemStayOnTop.AccessibleDescription = "Click to stay on top";
			menuitemStayOnTop.AccessibleName = "stay on top";
			menuitemStayOnTop.AccessibleRole = AccessibleRole.MenuItem;
			menuitemStayOnTop.AutoToolTip = true;
			menuitemStayOnTop.CheckOnClick = true;
			menuitemStayOnTop.Name = "menuitemStayOnTop";
			menuitemStayOnTop.Size = new Size(200, 22);
			menuitemStayOnTop.Text = "&Stay on top";
			menuitemStayOnTop.CheckedChanged += MenuitemStayOnTop_CheckedChanged;
			menuitemStayOnTop.MouseEnter += SetStatusbar_Enter;
			menuitemStayOnTop.MouseLeave += ClearStatusbar_Leave;
			// 
			// menuitemMinimizeToSystemTray
			// 
			menuitemMinimizeToSystemTray.AccessibleDescription = "Click to minimize to system tray";
			menuitemMinimizeToSystemTray.AccessibleName = "minimize to system tray";
			menuitemMinimizeToSystemTray.AccessibleRole = AccessibleRole.MenuItem;
			menuitemMinimizeToSystemTray.AutoToolTip = true;
			menuitemMinimizeToSystemTray.CheckOnClick = true;
			menuitemMinimizeToSystemTray.Name = "menuitemMinimizeToSystemTray";
			menuitemMinimizeToSystemTray.Size = new Size(200, 22);
			menuitemMinimizeToSystemTray.Text = "&Minimize to system tray";
			menuitemMinimizeToSystemTray.MouseEnter += SetStatusbar_Enter;
			menuitemMinimizeToSystemTray.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.AccessibleDescription = "Just a separator";
			toolStripSeparator1.AccessibleName = "Separator";
			toolStripSeparator1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// toolStripButtonShowValueInByte
			// 
			toolStripButtonShowValueInByte.AccessibleDescription = "Show the value in byte";
			toolStripButtonShowValueInByte.AccessibleName = "value in byte";
			toolStripButtonShowValueInByte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInByte.Checked = true;
			toolStripButtonShowValueInByte.CheckState = CheckState.Checked;
			toolStripButtonShowValueInByte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInByte.Image = Properties.Resources.value_byte_16;
			toolStripButtonShowValueInByte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInByte.Name = "toolStripButtonShowValueInByte";
			toolStripButtonShowValueInByte.Size = new Size(23, 22);
			toolStripButtonShowValueInByte.Text = "Byte";
			toolStripButtonShowValueInByte.Click += ToolStripButtonShowValueInByte_Click;
			toolStripButtonShowValueInByte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInByte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonShowValueInKilobyte
			// 
			toolStripButtonShowValueInKilobyte.AccessibleDescription = "Show the value in kilobyte";
			toolStripButtonShowValueInKilobyte.AccessibleName = "value in kilobyte";
			toolStripButtonShowValueInKilobyte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInKilobyte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInKilobyte.Image = Properties.Resources.value_kilobyte_16;
			toolStripButtonShowValueInKilobyte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInKilobyte.Name = "toolStripButtonShowValueInKilobyte";
			toolStripButtonShowValueInKilobyte.Size = new Size(23, 22);
			toolStripButtonShowValueInKilobyte.Text = "Kilobyte";
			toolStripButtonShowValueInKilobyte.Click += ToolStripButtonShowValueInKilobyte_Click;
			toolStripButtonShowValueInKilobyte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInKilobyte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonShowValueInMegabyte
			// 
			toolStripButtonShowValueInMegabyte.AccessibleDescription = "Show the value in megabyte";
			toolStripButtonShowValueInMegabyte.AccessibleName = "value in megabyte";
			toolStripButtonShowValueInMegabyte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInMegabyte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInMegabyte.Image = Properties.Resources.value_megabyte_16;
			toolStripButtonShowValueInMegabyte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInMegabyte.Name = "toolStripButtonShowValueInMegabyte";
			toolStripButtonShowValueInMegabyte.Size = new Size(23, 22);
			toolStripButtonShowValueInMegabyte.Text = "Megabyte";
			toolStripButtonShowValueInMegabyte.Click += ToolStripButtonShowValueInMegabyte_Click;
			toolStripButtonShowValueInMegabyte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInMegabyte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonShowValueInGigabyte
			// 
			toolStripButtonShowValueInGigabyte.AccessibleDescription = "Show the value in gigabyte";
			toolStripButtonShowValueInGigabyte.AccessibleName = "value in gigabyte";
			toolStripButtonShowValueInGigabyte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInGigabyte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInGigabyte.Image = Properties.Resources.value_gigabyte_16;
			toolStripButtonShowValueInGigabyte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInGigabyte.Name = "toolStripButtonShowValueInGigabyte";
			toolStripButtonShowValueInGigabyte.Size = new Size(23, 22);
			toolStripButtonShowValueInGigabyte.Text = "Gigabyte";
			toolStripButtonShowValueInGigabyte.Click += ToolStripButtonShowValueInGigabyte_Click;
			toolStripButtonShowValueInGigabyte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInGigabyte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonShowValueInTerabyte
			// 
			toolStripButtonShowValueInTerabyte.AccessibleDescription = "Show the value in terabyte";
			toolStripButtonShowValueInTerabyte.AccessibleName = "value in terabyte";
			toolStripButtonShowValueInTerabyte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInTerabyte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInTerabyte.Image = Properties.Resources.value_terabyte_16;
			toolStripButtonShowValueInTerabyte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInTerabyte.Name = "toolStripButtonShowValueInTerabyte";
			toolStripButtonShowValueInTerabyte.Size = new Size(23, 22);
			toolStripButtonShowValueInTerabyte.Text = "Terabyte";
			toolStripButtonShowValueInTerabyte.Click += ToolStripButtonShowValueInTerabyte_Click;
			toolStripButtonShowValueInTerabyte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInTerabyte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonShowValueInPentabyte
			// 
			toolStripButtonShowValueInPentabyte.AccessibleDescription = "Show the value in pentabyte";
			toolStripButtonShowValueInPentabyte.AccessibleName = "value in pentabyte";
			toolStripButtonShowValueInPentabyte.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonShowValueInPentabyte.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonShowValueInPentabyte.Image = Properties.Resources.value_pentabyte_16;
			toolStripButtonShowValueInPentabyte.ImageTransparentColor = Color.Magenta;
			toolStripButtonShowValueInPentabyte.Name = "toolStripButtonShowValueInPentabyte";
			toolStripButtonShowValueInPentabyte.Size = new Size(23, 22);
			toolStripButtonShowValueInPentabyte.Text = "Pentabyte";
			toolStripButtonShowValueInPentabyte.Click += ToolStripButtonShowValueInPentabyte_Click;
			toolStripButtonShowValueInPentabyte.MouseEnter += SetStatusbar_Enter;
			toolStripButtonShowValueInPentabyte.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.AccessibleDescription = "Just a separator";
			toolStripSeparator2.AccessibleName = "Separator";
			toolStripSeparator2.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
			// 
			// toolStripButtonThousandSeparator
			// 
			toolStripButtonThousandSeparator.AccessibleDescription = "Enable or disable the thousand separator";
			toolStripButtonThousandSeparator.AccessibleName = "Thousand separator";
			toolStripButtonThousandSeparator.AccessibleRole = AccessibleRole.PushButton;
			toolStripButtonThousandSeparator.CheckOnClick = true;
			toolStripButtonThousandSeparator.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonThousandSeparator.Image = Properties.Resources.thousand_separator_16;
			toolStripButtonThousandSeparator.ImageTransparentColor = Color.Magenta;
			toolStripButtonThousandSeparator.Name = "toolStripButtonThousandSeparator";
			toolStripButtonThousandSeparator.Size = new Size(23, 22);
			toolStripButtonThousandSeparator.Text = "Thousand separator";
			toolStripButtonThousandSeparator.MouseEnter += SetStatusbar_Enter;
			toolStripButtonThousandSeparator.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripDropDownButtonDecimalSeparator
			// 
			toolStripDropDownButtonDecimalSeparator.AccessibleDescription = "Choose the value of the decimal separator";
			toolStripDropDownButtonDecimalSeparator.AccessibleName = "Decimal separator";
			toolStripDropDownButtonDecimalSeparator.AccessibleRole = AccessibleRole.DropList;
			toolStripDropDownButtonDecimalSeparator.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButtonDecimalSeparator.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDecimalSeparatorTo0, toolStripMenuItemDecimalSeparatorTo1, toolStripMenuItemDecimalSeparatorTo2, toolStripMenuItemDecimalSeparatorTo3, toolStripMenuItemDecimalSeparatorTo4, toolStripMenuItemDecimalSeparatorTo5, toolStripMenuItemDecimalSeparatorTo6 });
			toolStripDropDownButtonDecimalSeparator.Image = Properties.Resources.decimal_separator_16;
			toolStripDropDownButtonDecimalSeparator.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButtonDecimalSeparator.Name = "toolStripDropDownButtonDecimalSeparator";
			toolStripDropDownButtonDecimalSeparator.Size = new Size(29, 22);
			toolStripDropDownButtonDecimalSeparator.Text = "Decimal separator";
			toolStripDropDownButtonDecimalSeparator.MouseEnter += SetStatusbar_Enter;
			toolStripDropDownButtonDecimalSeparator.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo0
			// 
			toolStripMenuItemDecimalSeparatorTo0.AccessibleDescription = "Set the value of the decimal separator to 0";
			toolStripMenuItemDecimalSeparatorTo0.AccessibleName = "Value of the decimal separator is 0";
			toolStripMenuItemDecimalSeparatorTo0.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo0.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo0.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo0.Name = "toolStripMenuItemDecimalSeparatorTo0";
			toolStripMenuItemDecimalSeparatorTo0.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo0.Text = "&0";
			toolStripMenuItemDecimalSeparatorTo0.Click += ToolStripMenuItemDecimalSeparatorTo0_Click;
			toolStripMenuItemDecimalSeparatorTo0.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo0.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo1
			// 
			toolStripMenuItemDecimalSeparatorTo1.AccessibleDescription = "Set the value of the decimal separator to 1";
			toolStripMenuItemDecimalSeparatorTo1.AccessibleName = "Value of the decimal separator is 1";
			toolStripMenuItemDecimalSeparatorTo1.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo1.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo1.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo1.Name = "toolStripMenuItemDecimalSeparatorTo1";
			toolStripMenuItemDecimalSeparatorTo1.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo1.Text = "&1";
			toolStripMenuItemDecimalSeparatorTo1.Click += ToolStripMenuItemDecimalSeparatorTo1_Click;
			toolStripMenuItemDecimalSeparatorTo1.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo1.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo2
			// 
			toolStripMenuItemDecimalSeparatorTo2.AccessibleDescription = "Set the value of the decimal separator to 2";
			toolStripMenuItemDecimalSeparatorTo2.AccessibleName = "Value of the decimal separator is 2";
			toolStripMenuItemDecimalSeparatorTo2.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo2.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo2.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo2.Name = "toolStripMenuItemDecimalSeparatorTo2";
			toolStripMenuItemDecimalSeparatorTo2.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo2.Text = "&2";
			toolStripMenuItemDecimalSeparatorTo2.Click += ToolStripMenuItemDecimalSeparatorTo2_Click;
			toolStripMenuItemDecimalSeparatorTo2.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo2.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo3
			// 
			toolStripMenuItemDecimalSeparatorTo3.AccessibleDescription = "Set the value of the decimal separator to 3";
			toolStripMenuItemDecimalSeparatorTo3.AccessibleName = "Value of the decimal separator is 3";
			toolStripMenuItemDecimalSeparatorTo3.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo3.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo3.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo3.Name = "toolStripMenuItemDecimalSeparatorTo3";
			toolStripMenuItemDecimalSeparatorTo3.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo3.Text = "&3";
			toolStripMenuItemDecimalSeparatorTo3.Click += ToolStripMenuItemDecimalSeparatorTo3_Click;
			toolStripMenuItemDecimalSeparatorTo3.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo3.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo4
			// 
			toolStripMenuItemDecimalSeparatorTo4.AccessibleDescription = "Set the value of the decimal separator to 4";
			toolStripMenuItemDecimalSeparatorTo4.AccessibleName = "Value of the decimal separator is 4";
			toolStripMenuItemDecimalSeparatorTo4.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo4.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo4.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo4.Name = "toolStripMenuItemDecimalSeparatorTo4";
			toolStripMenuItemDecimalSeparatorTo4.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo4.Text = "&4";
			toolStripMenuItemDecimalSeparatorTo4.Click += ToolStripMenuItemDecimalSeparatorTo4_Click;
			toolStripMenuItemDecimalSeparatorTo4.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo4.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo5
			// 
			toolStripMenuItemDecimalSeparatorTo5.AccessibleDescription = "Set the value of the decimal separator to 5";
			toolStripMenuItemDecimalSeparatorTo5.AccessibleName = "Value of the decimal separator is 5";
			toolStripMenuItemDecimalSeparatorTo5.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo5.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo5.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo5.Name = "toolStripMenuItemDecimalSeparatorTo5";
			toolStripMenuItemDecimalSeparatorTo5.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo5.Text = "&5";
			toolStripMenuItemDecimalSeparatorTo5.Click += ToolStripMenuItemDecimalSeparatorTo5_Click;
			toolStripMenuItemDecimalSeparatorTo5.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo5.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemDecimalSeparatorTo6
			// 
			toolStripMenuItemDecimalSeparatorTo6.AccessibleDescription = "Set the value of the decimal separator to 6";
			toolStripMenuItemDecimalSeparatorTo6.AccessibleName = "Value of the decimal separator is 6";
			toolStripMenuItemDecimalSeparatorTo6.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDecimalSeparatorTo6.AutoToolTip = true;
			toolStripMenuItemDecimalSeparatorTo6.Checked = true;
			toolStripMenuItemDecimalSeparatorTo6.CheckOnClick = true;
			toolStripMenuItemDecimalSeparatorTo6.CheckState = CheckState.Checked;
			toolStripMenuItemDecimalSeparatorTo6.Name = "toolStripMenuItemDecimalSeparatorTo6";
			toolStripMenuItemDecimalSeparatorTo6.Size = new Size(80, 22);
			toolStripMenuItemDecimalSeparatorTo6.Text = "&6";
			toolStripMenuItemDecimalSeparatorTo6.Click += ToolStripMenuItemDecimalSeparatorTo6_Click;
			toolStripMenuItemDecimalSeparatorTo6.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDecimalSeparatorTo6.MouseLeave += ClearStatusbar_Leave;
			// 
			// MainForm
			// 
			AccessibleDescription = "This is the main window.";
			AccessibleName = "Main window";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(317, 212);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Disksize Watcher";
			Load += MainForm_Load;
			Resize += MainForm_Resize;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher).EndInit();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ContentPanel.PerformLayout();
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			toolStrip.ResumeLayout(false);
			toolStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private TextBox textBoxSpaceTotal;
		private Label labelSpaceTotal;
		private TextBox textBoxSpaceFree;
		private Label labelSpaceFree;
		private NotifyIcon notifyIcon;
		private Label labelSpaceTotalUnit;
		private Label labelSpaceFreeUnit;
		private Label labelSpacePercentageValue;
		private ProgressBar progressBarPercentage;
		private Label labelSpacePercentage;
		private Label labelSpaceUsedUnit;
		private TextBox textBoxSpaceUsed;
		private Label labelSpaceUsed;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private Label labelSpaceDiff;
		private TextBox textBoxSpaceDiff;
		private Label labelSpaceDiffUnit;
		private FileSystemWatcher fileSystemWatcher;
		private ToolStripContainer toolStripContainer;
		private ToolStrip toolStrip;
		private ToolStripButton toolStripButtonInfo;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButtonShowValueInByte;
		private ToolStripButton toolStripButtonShowValueInKilobyte;
		private ToolStripButton toolStripButtonShowValueInMegabyte;
		private ToolStripButton toolStripButtonShowValueInGigabyte;
		private ToolStripButton toolStripButtonShowValueInTerabyte;
		private ToolStripButton toolStripButtonShowValueInPentabyte;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButtonThousandSeparator;
		private ToolStripDropDownButton toolStripDropDownButtonDecimalSeparator;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo0;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo1;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo2;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo3;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo4;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo5;
		private ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo6;
		private ToolStripSplitButton toolStripSplitButtonSettings;
		private ToolStripMenuItem menuitemStayOnTop;
		private ToolStripMenuItem menuitemMinimizeToSystemTray;
		private ToolStripButton toolStripButtonLicense;
	}
}

