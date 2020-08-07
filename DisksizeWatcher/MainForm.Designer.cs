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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.labelSpaceFree = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.textBoxSpaceFree = new System.Windows.Forms.TextBox();
			this.textBoxSpaceTotal = new System.Windows.Forms.TextBox();
			this.labelSpaceTotal = new System.Windows.Forms.Label();
			this.labelSpaceFreeUnit = new System.Windows.Forms.Label();
			this.labelSpaceTotalUnit = new System.Windows.Forms.Label();
			this.labelSpacePercentage = new System.Windows.Forms.Label();
			this.progressBarPercentage = new System.Windows.Forms.ProgressBar();
			this.labelSpacePercentageValue = new System.Windows.Forms.Label();
			this.labelSpaceUsedUnit = new System.Windows.Forms.Label();
			this.textBoxSpaceUsed = new System.Windows.Forms.TextBox();
			this.labelSpaceUsed = new System.Windows.Forms.Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSplitButtonSettings = new System.Windows.Forms.ToolStripSplitButton();
			this.menuitemStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemMinimizeToSystemTray = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.contextMenuStripUsedSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemUsedSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemUsedSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemUsedSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemUsedSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemUsedSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemUsedSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripFreeSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStripUsedTotalUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemFreeSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreeSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreeSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreeSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreeSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreeSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTotalSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			this.contextMenuStripUsedSpaceUnits.SuspendLayout();
			this.contextMenuStripFreeSpaceUnits.SuspendLayout();
			this.contextMenuStripUsedTotalUnits.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// labelSpaceFree
			// 
			this.labelSpaceFree.AccessibleDescription = "Show the free space";
			this.labelSpaceFree.AutoEllipsis = true;
			this.labelSpaceFree.Location = new System.Drawing.Point(11, 41);
			this.labelSpaceFree.Name = "labelSpaceFree";
			this.labelSpaceFree.Size = new System.Drawing.Size(63, 13);
			this.labelSpaceFree.TabIndex = 3;
			this.labelSpaceFree.Text = "&Free space:";
			this.labelSpaceFree.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceFree.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceFree.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceFree.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Disksize Watcher";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
			// 
			// textBoxSpaceFree
			// 
			this.textBoxSpaceFree.AccessibleDescription = "Show the value of the free space";
			this.textBoxSpaceFree.Location = new System.Drawing.Point(82, 38);
			this.textBoxSpaceFree.Name = "textBoxSpaceFree";
			this.textBoxSpaceFree.ReadOnly = true;
			this.textBoxSpaceFree.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceFree.TabIndex = 4;
			this.textBoxSpaceFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxSpaceFree.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceFree.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textBoxSpaceFree.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceFree.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textBoxSpaceTotal
			// 
			this.textBoxSpaceTotal.AccessibleDescription = "Show the value of the total space";
			this.textBoxSpaceTotal.Location = new System.Drawing.Point(82, 64);
			this.textBoxSpaceTotal.Name = "textBoxSpaceTotal";
			this.textBoxSpaceTotal.ReadOnly = true;
			this.textBoxSpaceTotal.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceTotal.TabIndex = 7;
			this.textBoxSpaceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxSpaceTotal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceTotal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textBoxSpaceTotal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceTotal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpaceTotal
			// 
			this.labelSpaceTotal.AccessibleDescription = "Show the total space";
			this.labelSpaceTotal.AutoEllipsis = true;
			this.labelSpaceTotal.AutoSize = true;
			this.labelSpaceTotal.Location = new System.Drawing.Point(11, 67);
			this.labelSpaceTotal.Name = "labelSpaceTotal";
			this.labelSpaceTotal.Size = new System.Drawing.Size(66, 13);
			this.labelSpaceTotal.TabIndex = 6;
			this.labelSpaceTotal.Text = "&Total space:";
			this.labelSpaceTotal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceTotal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceTotal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceTotal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpaceFreeUnit
			// 
			this.labelSpaceFreeUnit.AccessibleDescription = "Show the unit of the free space";
			this.labelSpaceFreeUnit.AutoEllipsis = true;
			this.labelSpaceFreeUnit.AutoSize = true;
			this.labelSpaceFreeUnit.ContextMenuStrip = this.contextMenuStripFreeSpaceUnits;
			this.labelSpaceFreeUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelSpaceFreeUnit.Location = new System.Drawing.Point(199, 41);
			this.labelSpaceFreeUnit.Name = "labelSpaceFreeUnit";
			this.labelSpaceFreeUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceFreeUnit.TabIndex = 5;
			this.labelSpaceFreeUnit.Text = "bytes";
			this.labelSpaceFreeUnit.Click += new System.EventHandler(this.LabelSpaceFreeUnit_Click);
			this.labelSpaceFreeUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceFreeUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceFreeUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceFreeUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpaceTotalUnit
			// 
			this.labelSpaceTotalUnit.AccessibleDescription = "Show the unit of the total space";
			this.labelSpaceTotalUnit.AutoEllipsis = true;
			this.labelSpaceTotalUnit.AutoSize = true;
			this.labelSpaceTotalUnit.ContextMenuStrip = this.contextMenuStripUsedTotalUnits;
			this.labelSpaceTotalUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelSpaceTotalUnit.Location = new System.Drawing.Point(199, 67);
			this.labelSpaceTotalUnit.Name = "labelSpaceTotalUnit";
			this.labelSpaceTotalUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceTotalUnit.TabIndex = 8;
			this.labelSpaceTotalUnit.Text = "bytes";
			this.labelSpaceTotalUnit.Click += new System.EventHandler(this.LabelSpaceTotalUnit_Click);
			this.labelSpaceTotalUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceTotalUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceTotalUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceTotalUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpacePercentage
			// 
			this.labelSpacePercentage.AccessibleDescription = "Show the percentage";
			this.labelSpacePercentage.AutoEllipsis = true;
			this.labelSpacePercentage.AutoSize = true;
			this.labelSpacePercentage.Location = new System.Drawing.Point(11, 90);
			this.labelSpacePercentage.Name = "labelSpacePercentage";
			this.labelSpacePercentage.Size = new System.Drawing.Size(65, 13);
			this.labelSpacePercentage.TabIndex = 9;
			this.labelSpacePercentage.Text = "Percentage:";
			this.labelSpacePercentage.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpacePercentage.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpacePercentage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpacePercentage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// progressBarPercentage
			// 
			this.progressBarPercentage.AccessibleDescription = "Show the state of the percentage";
			this.progressBarPercentage.Location = new System.Drawing.Point(82, 90);
			this.progressBarPercentage.Name = "progressBarPercentage";
			this.progressBarPercentage.Size = new System.Drawing.Size(111, 13);
			this.progressBarPercentage.Step = 1;
			this.progressBarPercentage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarPercentage.TabIndex = 10;
			this.progressBarPercentage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.progressBarPercentage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpacePercentageValue
			// 
			this.labelSpacePercentageValue.AccessibleDescription = "Show the value of the percentage";
			this.labelSpacePercentageValue.AutoEllipsis = true;
			this.labelSpacePercentageValue.AutoSize = true;
			this.labelSpacePercentageValue.Location = new System.Drawing.Point(199, 90);
			this.labelSpacePercentageValue.Name = "labelSpacePercentageValue";
			this.labelSpacePercentageValue.Size = new System.Drawing.Size(15, 13);
			this.labelSpacePercentageValue.TabIndex = 11;
			this.labelSpacePercentageValue.Text = "%";
			this.labelSpacePercentageValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpacePercentageValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpacePercentageValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpacePercentageValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpaceUsedUnit
			// 
			this.labelSpaceUsedUnit.AccessibleDescription = "Show the unit of the used space";
			this.labelSpaceUsedUnit.AutoEllipsis = true;
			this.labelSpaceUsedUnit.AutoSize = true;
			this.labelSpaceUsedUnit.ContextMenuStrip = this.contextMenuStripUsedSpaceUnits;
			this.labelSpaceUsedUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelSpaceUsedUnit.Location = new System.Drawing.Point(199, 15);
			this.labelSpaceUsedUnit.Name = "labelSpaceUsedUnit";
			this.labelSpaceUsedUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceUsedUnit.TabIndex = 2;
			this.labelSpaceUsedUnit.Text = "bytes";
			this.labelSpaceUsedUnit.Click += new System.EventHandler(this.LabelSpaceUsedUnit_Click);
			this.labelSpaceUsedUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceUsedUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceUsedUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceUsedUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// textBoxSpaceUsed
			// 
			this.textBoxSpaceUsed.AccessibleDescription = "Show the value of the used space";
			this.textBoxSpaceUsed.Location = new System.Drawing.Point(82, 12);
			this.textBoxSpaceUsed.Name = "textBoxSpaceUsed";
			this.textBoxSpaceUsed.ReadOnly = true;
			this.textBoxSpaceUsed.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceUsed.TabIndex = 1;
			this.textBoxSpaceUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxSpaceUsed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceUsed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.textBoxSpaceUsed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.textBoxSpaceUsed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelSpaceUsed
			// 
			this.labelSpaceUsed.AccessibleDescription = "Show the used space";
			this.labelSpaceUsed.AutoEllipsis = true;
			this.labelSpaceUsed.AutoSize = true;
			this.labelSpaceUsed.Location = new System.Drawing.Point(11, 15);
			this.labelSpaceUsed.Name = "labelSpaceUsed";
			this.labelSpaceUsed.Size = new System.Drawing.Size(67, 13);
			this.labelSpaceUsed.TabIndex = 0;
			this.labelSpaceUsed.Text = "&Used space:";
			this.labelSpaceUsed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceUsed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelSpaceUsed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelSpaceUsed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AllowItemReorder = true;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation,
            this.toolStripSplitButtonSettings});
			this.statusStrip.Location = new System.Drawing.Point(0, 113);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(272, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 12;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Show some information";
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(225, 17);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "info";
			this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripSplitButtonSettings
			// 
			this.toolStripSplitButtonSettings.AccessibleDescription = "Click to open the settings";
			this.toolStripSplitButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemStayOnTop,
            this.menuitemMinimizeToSystemTray});
			this.toolStripSplitButtonSettings.Image = global::DisksizeWatcher.Properties.Resources.fatcow_wrench_16;
			this.toolStripSplitButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonSettings.Name = "toolStripSplitButtonSettings";
			this.toolStripSplitButtonSettings.Size = new System.Drawing.Size(32, 20);
			this.toolStripSplitButtonSettings.Text = "Settings";
			this.toolStripSplitButtonSettings.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonSettings_ButtonClick);
			this.toolStripSplitButtonSettings.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonSettings.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemStayOnTop
			// 
			this.menuitemStayOnTop.AccessibleDescription = "Click to stay on top";
			this.menuitemStayOnTop.AutoToolTip = true;
			this.menuitemStayOnTop.CheckOnClick = true;
			this.menuitemStayOnTop.Name = "menuitemStayOnTop";
			this.menuitemStayOnTop.Size = new System.Drawing.Size(200, 22);
			this.menuitemStayOnTop.Text = "&Stay on top";
			this.menuitemStayOnTop.CheckedChanged += new System.EventHandler(this.MenuitemStayOnTop_CheckedChanged);
			this.menuitemStayOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemStayOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// menuitemMinimizeToSystemTray
			// 
			this.menuitemMinimizeToSystemTray.AccessibleDescription = "Click to minimize to system tray";
			this.menuitemMinimizeToSystemTray.AutoToolTip = true;
			this.menuitemMinimizeToSystemTray.CheckOnClick = true;
			this.menuitemMinimizeToSystemTray.Name = "menuitemMinimizeToSystemTray";
			this.menuitemMinimizeToSystemTray.Size = new System.Drawing.Size(200, 22);
			this.menuitemMinimizeToSystemTray.Text = "&Minimize to system tray";
			this.menuitemMinimizeToSystemTray.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.menuitemMinimizeToSystemTray.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuStripUsedSpaceUnits
			// 
			this.contextMenuStripUsedSpaceUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUsedSpaceUnitByte,
            this.toolStripMenuItemUsedSpaceUnitKilobyte,
            this.toolStripMenuItemUsedSpaceUnitMegabyte,
            this.toolStripMenuItemUsedSpaceUnitGigabyte,
            this.toolStripMenuItemUsedSpaceUnitTerabyte,
            this.toolStripMenuItemUsedSpaceUnitPentabyte});
			this.contextMenuStripUsedSpaceUnits.Name = "unitsOfusedSpace";
			this.contextMenuStripUsedSpaceUnits.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStripUsedSpaceUnits.Size = new System.Drawing.Size(128, 136);
			this.contextMenuStripUsedSpaceUnits.TabStop = true;
			// 
			// toolStripMenuItemUsedSpaceUnitByte
			// 
			this.toolStripMenuItemUsedSpaceUnitByte.Checked = true;
			this.toolStripMenuItemUsedSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemUsedSpaceUnitByte.Name = "toolStripMenuItemUsedSpaceUnitByte";
			this.toolStripMenuItemUsedSpaceUnitByte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitByte.Text = "&byte";
			this.toolStripMenuItemUsedSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitByte_Click);
			// 
			// toolStripMenuItemUsedSpaceUnitKilobyte
			// 
			this.toolStripMenuItemUsedSpaceUnitKilobyte.Name = "toolStripMenuItemUsedSpaceUnitKilobyte";
			this.toolStripMenuItemUsedSpaceUnitKilobyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitKilobyte.Text = "&kilobyte";
			this.toolStripMenuItemUsedSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitKilobyte_Click);
			// 
			// toolStripMenuItemUsedSpaceUnitMegabyte
			// 
			this.toolStripMenuItemUsedSpaceUnitMegabyte.Name = "toolStripMenuItemUsedSpaceUnitMegabyte";
			this.toolStripMenuItemUsedSpaceUnitMegabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitMegabyte.Text = "&megabyte";
			this.toolStripMenuItemUsedSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitMegabyte_Click);
			// 
			// toolStripMenuItemUsedSpaceUnitGigabyte
			// 
			this.toolStripMenuItemUsedSpaceUnitGigabyte.Name = "toolStripMenuItemUsedSpaceUnitGigabyte";
			this.toolStripMenuItemUsedSpaceUnitGigabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitGigabyte.Text = "&gigabyte";
			this.toolStripMenuItemUsedSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitGigabyte_Click);
			// 
			// toolStripMenuItemUsedSpaceUnitTerabyte
			// 
			this.toolStripMenuItemUsedSpaceUnitTerabyte.Name = "toolStripMenuItemUsedSpaceUnitTerabyte";
			this.toolStripMenuItemUsedSpaceUnitTerabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitTerabyte.Text = "&terabyte";
			this.toolStripMenuItemUsedSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitTerabyte_Click);
			// 
			// toolStripMenuItemUsedSpaceUnitPentabyte
			// 
			this.toolStripMenuItemUsedSpaceUnitPentabyte.Name = "toolStripMenuItemUsedSpaceUnitPentabyte";
			this.toolStripMenuItemUsedSpaceUnitPentabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemUsedSpaceUnitPentabyte.Text = "&pentabyte";
			this.toolStripMenuItemUsedSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitPentabyte_Click);
			// 
			// contextMenuStripFreeSpaceUnits
			// 
			this.contextMenuStripFreeSpaceUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFreeSpaceUnitByte,
            this.toolStripMenuItemFreeSpaceUnitKilobyte,
            this.toolStripMenuItemFreeSpaceUnitMegabyte,
            this.toolStripMenuItemFreeSpaceUnitGigabyte,
            this.toolStripMenuItemFreeSpaceUnitTerabyte,
            this.toolStripMenuItemFreeSpaceUnitPentabyte});
			this.contextMenuStripFreeSpaceUnits.Name = "toolStripMenuItemFreeSpaceUnitMegabyte";
			this.contextMenuStripFreeSpaceUnits.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStripFreeSpaceUnits.Size = new System.Drawing.Size(128, 136);
			this.contextMenuStripFreeSpaceUnits.TabStop = true;
			// 
			// contextMenuStripUsedTotalUnits
			// 
			this.contextMenuStripUsedTotalUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTotalSpaceUnitByte,
            this.toolStripMenuItemTotalSpaceUnitKilobyte,
            this.toolStripMenuItemTotalSpaceUnitMegabyte,
            this.toolStripMenuItemTotalSpaceUnitGigabyte,
            this.toolStripMenuItemTotalSpaceUnitTerabyte,
            this.toolStripMenuItemTotalSpaceUnitPentabyte});
			this.contextMenuStripUsedTotalUnits.Name = "contextMenuStripUsedTotalUnits";
			this.contextMenuStripUsedTotalUnits.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStripUsedTotalUnits.Size = new System.Drawing.Size(181, 158);
			this.contextMenuStripUsedTotalUnits.TabStop = true;
			// 
			// toolStripMenuItemFreeSpaceUnitByte
			// 
			this.toolStripMenuItemFreeSpaceUnitByte.Checked = true;
			this.toolStripMenuItemFreeSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemFreeSpaceUnitByte.Name = "toolStripMenuItemFreeSpaceUnitByte";
			this.toolStripMenuItemFreeSpaceUnitByte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitByte.Text = "&byte";
			this.toolStripMenuItemFreeSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitByte_Click);
			// 
			// toolStripMenuItemFreeSpaceUnitKilobyte
			// 
			this.toolStripMenuItemFreeSpaceUnitKilobyte.Name = "toolStripMenuItemFreeSpaceUnitKilobyte";
			this.toolStripMenuItemFreeSpaceUnitKilobyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitKilobyte.Text = "&kilobyte";
			this.toolStripMenuItemFreeSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitKilobyte_Click);
			// 
			// toolStripMenuItemFreeSpaceUnitMegabyte
			// 
			this.toolStripMenuItemFreeSpaceUnitMegabyte.Name = "toolStripMenuItemFreeSpaceUnitMegabyte";
			this.toolStripMenuItemFreeSpaceUnitMegabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitMegabyte.Text = "&megabyte";
			this.toolStripMenuItemFreeSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitMegabyte_Click);
			// 
			// toolStripMenuItemFreeSpaceUnitGigabyte
			// 
			this.toolStripMenuItemFreeSpaceUnitGigabyte.Name = "toolStripMenuItemFreeSpaceUnitGigabyte";
			this.toolStripMenuItemFreeSpaceUnitGigabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitGigabyte.Text = "&gigabyte";
			this.toolStripMenuItemFreeSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitGigabyte_Click);
			// 
			// toolStripMenuItemFreeSpaceUnitTerabyte
			// 
			this.toolStripMenuItemFreeSpaceUnitTerabyte.Name = "toolStripMenuItemFreeSpaceUnitTerabyte";
			this.toolStripMenuItemFreeSpaceUnitTerabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitTerabyte.Text = "&terabyte";
			this.toolStripMenuItemFreeSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitTerabyte_Click);
			// 
			// toolStripMenuItemFreeSpaceUnitPentabyte
			// 
			this.toolStripMenuItemFreeSpaceUnitPentabyte.Name = "toolStripMenuItemFreeSpaceUnitPentabyte";
			this.toolStripMenuItemFreeSpaceUnitPentabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemFreeSpaceUnitPentabyte.Text = "&pentabyte";
			this.toolStripMenuItemFreeSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitPentabyte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitByte
			// 
			this.toolStripMenuItemTotalSpaceUnitByte.Checked = true;
			this.toolStripMenuItemTotalSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemTotalSpaceUnitByte.Name = "toolStripMenuItemTotalSpaceUnitByte";
			this.toolStripMenuItemTotalSpaceUnitByte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitByte.Text = "&byte";
			this.toolStripMenuItemTotalSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitByte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitKilobyte
			// 
			this.toolStripMenuItemTotalSpaceUnitKilobyte.Name = "toolStripMenuItemTotalSpaceUnitKilobyte";
			this.toolStripMenuItemTotalSpaceUnitKilobyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitKilobyte.Text = "&kilobyte";
			this.toolStripMenuItemTotalSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitKilobyte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitMegabyte
			// 
			this.toolStripMenuItemTotalSpaceUnitMegabyte.Name = "toolStripMenuItemTotalSpaceUnitMegabyte";
			this.toolStripMenuItemTotalSpaceUnitMegabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitMegabyte.Text = "&megabyte";
			this.toolStripMenuItemTotalSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitMegabyte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitGigabyte
			// 
			this.toolStripMenuItemTotalSpaceUnitGigabyte.Name = "toolStripMenuItemTotalSpaceUnitGigabyte";
			this.toolStripMenuItemTotalSpaceUnitGigabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitGigabyte.Text = "&gigabyte";
			this.toolStripMenuItemTotalSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitGigabyte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitTerabyte
			// 
			this.toolStripMenuItemTotalSpaceUnitTerabyte.Name = "toolStripMenuItemTotalSpaceUnitTerabyte";
			this.toolStripMenuItemTotalSpaceUnitTerabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitTerabyte.Text = "&terabyte";
			this.toolStripMenuItemTotalSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitTerabyte_Click);
			// 
			// toolStripMenuItemTotalSpaceUnitPentabyte
			// 
			this.toolStripMenuItemTotalSpaceUnitPentabyte.Name = "toolStripMenuItemTotalSpaceUnitPentabyte";
			this.toolStripMenuItemTotalSpaceUnitPentabyte.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemTotalSpaceUnitPentabyte.Text = "&pentabyte";
			this.toolStripMenuItemTotalSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitPentabyte_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 135);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.labelSpaceUsedUnit);
			this.Controls.Add(this.textBoxSpaceUsed);
			this.Controls.Add(this.labelSpaceUsed);
			this.Controls.Add(this.labelSpacePercentageValue);
			this.Controls.Add(this.progressBarPercentage);
			this.Controls.Add(this.labelSpacePercentage);
			this.Controls.Add(this.labelSpaceTotalUnit);
			this.Controls.Add(this.labelSpaceFreeUnit);
			this.Controls.Add(this.textBoxSpaceTotal);
			this.Controls.Add(this.labelSpaceTotal);
			this.Controls.Add(this.textBoxSpaceFree);
			this.Controls.Add(this.labelSpaceFree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Disksize Watcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStripUsedSpaceUnits.ResumeLayout(false);
			this.contextMenuStripFreeSpaceUnits.ResumeLayout(false);
			this.contextMenuStripUsedTotalUnits.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.TextBox textBoxSpaceTotal;
		private System.Windows.Forms.Label labelSpaceTotal;
		private System.Windows.Forms.TextBox textBoxSpaceFree;
		private System.Windows.Forms.Label labelSpaceFree;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label labelSpaceTotalUnit;
		private System.Windows.Forms.Label labelSpaceFreeUnit;
		private System.Windows.Forms.Label labelSpacePercentageValue;
		private System.Windows.Forms.ProgressBar progressBarPercentage;
		private System.Windows.Forms.Label labelSpacePercentage;
		private System.Windows.Forms.Label labelSpaceUsedUnit;
		private System.Windows.Forms.TextBox textBoxSpaceUsed;
		private System.Windows.Forms.Label labelSpaceUsed;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSettings;
		private System.Windows.Forms.ToolStripMenuItem menuitemStayOnTop;
		private System.Windows.Forms.ToolStripMenuItem menuitemMinimizeToSystemTray;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripUsedSpaceUnits;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitByte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitKilobyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitMegabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitGigabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitTerabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsedSpaceUnitPentabyte;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripFreeSpaceUnits;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripUsedTotalUnits;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitByte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitKilobyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitMegabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitGigabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitTerabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreeSpaceUnitPentabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitByte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitKilobyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitMegabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitGigabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitTerabyte;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTotalSpaceUnitPentabyte;
	}
}

