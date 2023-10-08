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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelSpaceDiff = new System.Windows.Forms.Label();
            this.textBoxSpaceDiff = new System.Windows.Forms.TextBox();
            this.labelSpaceDiffUnit = new System.Windows.Forms.Label();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonSettings2 = new System.Windows.Forms.ToolStripSplitButton();
            this.menuitemStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemMinimizeToSystemTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowValueInByte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowValueInKilobyte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowValueInMegabyte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowValueInGigabyte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowValueInTerabyte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowValueInPentabyte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonThousandSeparator = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonDecimalSeparator = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemDecimalSeparatorTo0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecimalSeparatorTo6 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSpaceFree
            // 
            this.labelSpaceFree.AccessibleDescription = "Show the free space";
            this.labelSpaceFree.AccessibleName = "free space";
            this.labelSpaceFree.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceFree.AutoEllipsis = true;
            this.labelSpaceFree.Location = new System.Drawing.Point(3, 36);
            this.labelSpaceFree.Name = "labelSpaceFree";
            this.labelSpaceFree.Size = new System.Drawing.Size(63, 13);
            this.labelSpaceFree.TabIndex = 3;
            this.labelSpaceFree.Text = "&Free space:";
            this.toolTip.SetToolTip(this.labelSpaceFree, "Show the free space");
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
            this.textBoxSpaceFree.AccessibleName = "value of the free space";
            this.textBoxSpaceFree.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSpaceFree.Location = new System.Drawing.Point(74, 33);
            this.textBoxSpaceFree.Name = "textBoxSpaceFree";
            this.textBoxSpaceFree.ReadOnly = true;
            this.textBoxSpaceFree.Size = new System.Drawing.Size(111, 20);
            this.textBoxSpaceFree.TabIndex = 4;
            this.textBoxSpaceFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxSpaceFree, "Show the value of the free space");
            this.textBoxSpaceFree.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceFree.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSpaceFree.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceFree.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSpaceTotal
            // 
            this.textBoxSpaceTotal.AccessibleDescription = "Show the value of the total space";
            this.textBoxSpaceTotal.AccessibleName = "value of the total space";
            this.textBoxSpaceTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSpaceTotal.Location = new System.Drawing.Point(74, 59);
            this.textBoxSpaceTotal.Name = "textBoxSpaceTotal";
            this.textBoxSpaceTotal.ReadOnly = true;
            this.textBoxSpaceTotal.Size = new System.Drawing.Size(111, 20);
            this.textBoxSpaceTotal.TabIndex = 7;
            this.textBoxSpaceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxSpaceTotal, "Show the value of the total space");
            this.textBoxSpaceTotal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceTotal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSpaceTotal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceTotal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceTotal
            // 
            this.labelSpaceTotal.AccessibleDescription = "Show the total space";
            this.labelSpaceTotal.AccessibleName = "total space";
            this.labelSpaceTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceTotal.AutoEllipsis = true;
            this.labelSpaceTotal.AutoSize = true;
            this.labelSpaceTotal.Location = new System.Drawing.Point(3, 62);
            this.labelSpaceTotal.Name = "labelSpaceTotal";
            this.labelSpaceTotal.Size = new System.Drawing.Size(66, 13);
            this.labelSpaceTotal.TabIndex = 6;
            this.labelSpaceTotal.Text = "&Total space:";
            this.toolTip.SetToolTip(this.labelSpaceTotal, "Show the total space");
            this.labelSpaceTotal.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotal.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceTotal.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotal.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceFreeUnit
            // 
            this.labelSpaceFreeUnit.AccessibleDescription = "Show the unit of the free space";
            this.labelSpaceFreeUnit.AccessibleName = "unit of the free space";
            this.labelSpaceFreeUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceFreeUnit.AutoEllipsis = true;
            this.labelSpaceFreeUnit.AutoSize = true;
            this.labelSpaceFreeUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSpaceFreeUnit.Location = new System.Drawing.Point(191, 36);
            this.labelSpaceFreeUnit.Name = "labelSpaceFreeUnit";
            this.labelSpaceFreeUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceFreeUnit.TabIndex = 5;
            this.labelSpaceFreeUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceFreeUnit, "Show the unit of the free space");
            this.labelSpaceFreeUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceFreeUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceFreeUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceFreeUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceTotalUnit
            // 
            this.labelSpaceTotalUnit.AccessibleDescription = "Show the unit of the total space";
            this.labelSpaceTotalUnit.AccessibleName = "unit of the total space";
            this.labelSpaceTotalUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceTotalUnit.AutoEllipsis = true;
            this.labelSpaceTotalUnit.AutoSize = true;
            this.labelSpaceTotalUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSpaceTotalUnit.Location = new System.Drawing.Point(191, 62);
            this.labelSpaceTotalUnit.Name = "labelSpaceTotalUnit";
            this.labelSpaceTotalUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceTotalUnit.TabIndex = 8;
            this.labelSpaceTotalUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceTotalUnit, "Show the unit of the total space");
            this.labelSpaceTotalUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotalUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceTotalUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotalUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpacePercentage
            // 
            this.labelSpacePercentage.AccessibleDescription = "Show the percentage";
            this.labelSpacePercentage.AccessibleName = "pecrentage";
            this.labelSpacePercentage.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpacePercentage.AutoEllipsis = true;
            this.labelSpacePercentage.AutoSize = true;
            this.labelSpacePercentage.Location = new System.Drawing.Point(5, 111);
            this.labelSpacePercentage.Name = "labelSpacePercentage";
            this.labelSpacePercentage.Size = new System.Drawing.Size(65, 13);
            this.labelSpacePercentage.TabIndex = 12;
            this.labelSpacePercentage.Text = "Percentage:";
            this.toolTip.SetToolTip(this.labelSpacePercentage, "Show the percentage");
            this.labelSpacePercentage.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpacePercentage.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpacePercentage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpacePercentage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // progressBarPercentage
            // 
            this.progressBarPercentage.AccessibleDescription = "Show the state of the percentage";
            this.progressBarPercentage.Location = new System.Drawing.Point(74, 111);
            this.progressBarPercentage.Name = "progressBarPercentage";
            this.progressBarPercentage.Size = new System.Drawing.Size(111, 13);
            this.progressBarPercentage.Step = 1;
            this.progressBarPercentage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPercentage.TabIndex = 13;
            this.toolTip.SetToolTip(this.progressBarPercentage, "Show the state of the percentage");
            this.progressBarPercentage.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.progressBarPercentage.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpacePercentageValue
            // 
            this.labelSpacePercentageValue.AccessibleDescription = "Show the value of the percentage";
            this.labelSpacePercentageValue.AccessibleName = "value of the percentage";
            this.labelSpacePercentageValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpacePercentageValue.AutoEllipsis = true;
            this.labelSpacePercentageValue.AutoSize = true;
            this.labelSpacePercentageValue.Location = new System.Drawing.Point(191, 111);
            this.labelSpacePercentageValue.Name = "labelSpacePercentageValue";
            this.labelSpacePercentageValue.Size = new System.Drawing.Size(15, 13);
            this.labelSpacePercentageValue.TabIndex = 14;
            this.labelSpacePercentageValue.Text = "%";
            this.toolTip.SetToolTip(this.labelSpacePercentageValue, "Show the value of the percentage");
            this.labelSpacePercentageValue.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpacePercentageValue.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpacePercentageValue.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpacePercentageValue.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceUsedUnit
            // 
            this.labelSpaceUsedUnit.AccessibleDescription = "Show the unit of the used space";
            this.labelSpaceUsedUnit.AccessibleName = "unit of the used space";
            this.labelSpaceUsedUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceUsedUnit.AutoEllipsis = true;
            this.labelSpaceUsedUnit.AutoSize = true;
            this.labelSpaceUsedUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSpaceUsedUnit.Location = new System.Drawing.Point(191, 10);
            this.labelSpaceUsedUnit.Name = "labelSpaceUsedUnit";
            this.labelSpaceUsedUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceUsedUnit.TabIndex = 2;
            this.labelSpaceUsedUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceUsedUnit, "Show the unit of the used space");
            this.labelSpaceUsedUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsedUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceUsedUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsedUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSpaceUsed
            // 
            this.textBoxSpaceUsed.AccessibleDescription = "Show the value of the used space";
            this.textBoxSpaceUsed.AccessibleName = "value of the used space";
            this.textBoxSpaceUsed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSpaceUsed.Location = new System.Drawing.Point(74, 7);
            this.textBoxSpaceUsed.Name = "textBoxSpaceUsed";
            this.textBoxSpaceUsed.ReadOnly = true;
            this.textBoxSpaceUsed.Size = new System.Drawing.Size(111, 20);
            this.textBoxSpaceUsed.TabIndex = 1;
            this.textBoxSpaceUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxSpaceUsed, "Show the value of the used space");
            this.textBoxSpaceUsed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceUsed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSpaceUsed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceUsed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceUsed
            // 
            this.labelSpaceUsed.AccessibleDescription = "Show the used space";
            this.labelSpaceUsed.AccessibleName = "used space";
            this.labelSpaceUsed.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceUsed.AutoEllipsis = true;
            this.labelSpaceUsed.AutoSize = true;
            this.labelSpaceUsed.Location = new System.Drawing.Point(3, 10);
            this.labelSpaceUsed.Name = "labelSpaceUsed";
            this.labelSpaceUsed.Size = new System.Drawing.Size(67, 13);
            this.labelSpaceUsed.TabIndex = 0;
            this.labelSpaceUsed.Text = "&Used space:";
            this.toolTip.SetToolTip(this.labelSpaceUsed, "Show the used space");
            this.labelSpaceUsed.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsed.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceUsed.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsed.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Show the status bar";
            this.statusStrip.AccessibleName = "status bar";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.AllowItemReorder = true;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(272, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.TabStop = true;
            this.statusStrip.Text = "statusStrip";
            this.toolTip.SetToolTip(this.statusStrip, "Show the status bar");
            this.statusStrip.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.statusStrip.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.statusStrip.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.statusStrip.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelInformation
            // 
            this.labelInformation.AccessibleDescription = "Show some information";
            this.labelInformation.AccessibleName = "some information";
            this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelInformation.AutoToolTip = true;
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(257, 17);
            this.labelInformation.Spring = true;
            this.labelInformation.Text = "info";
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceDiff
            // 
            this.labelSpaceDiff.AccessibleDescription = "Show the diff space";
            this.labelSpaceDiff.AccessibleName = "diff space";
            this.labelSpaceDiff.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceDiff.AutoEllipsis = true;
            this.labelSpaceDiff.AutoSize = true;
            this.labelSpaceDiff.Location = new System.Drawing.Point(4, 88);
            this.labelSpaceDiff.Name = "labelSpaceDiff";
            this.labelSpaceDiff.Size = new System.Drawing.Size(58, 13);
            this.labelSpaceDiff.TabIndex = 9;
            this.labelSpaceDiff.Text = "&Diff space:";
            this.toolTip.SetToolTip(this.labelSpaceDiff, "Show the diff space");
            this.labelSpaceDiff.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiff.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceDiff.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiff.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSpaceDiff
            // 
            this.textBoxSpaceDiff.AccessibleDescription = "Show the value of the diff space";
            this.textBoxSpaceDiff.AccessibleName = "value of the diff space";
            this.textBoxSpaceDiff.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSpaceDiff.Location = new System.Drawing.Point(74, 85);
            this.textBoxSpaceDiff.Name = "textBoxSpaceDiff";
            this.textBoxSpaceDiff.ReadOnly = true;
            this.textBoxSpaceDiff.Size = new System.Drawing.Size(110, 20);
            this.textBoxSpaceDiff.TabIndex = 10;
            this.textBoxSpaceDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxSpaceDiff, "Show the value of the diff space");
            this.textBoxSpaceDiff.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceDiff.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSpaceDiff.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSpaceDiff.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceDiffUnit
            // 
            this.labelSpaceDiffUnit.AccessibleDescription = "Show the unit of the diff space";
            this.labelSpaceDiffUnit.AccessibleName = "unit of the diff space";
            this.labelSpaceDiffUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceDiffUnit.AutoEllipsis = true;
            this.labelSpaceDiffUnit.AutoSize = true;
            this.labelSpaceDiffUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSpaceDiffUnit.Location = new System.Drawing.Point(191, 88);
            this.labelSpaceDiffUnit.Name = "labelSpaceDiffUnit";
            this.labelSpaceDiffUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceDiffUnit.TabIndex = 11;
            this.labelSpaceDiffUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceDiffUnit, "Show the unit of the used space");
            this.labelSpaceDiffUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiffUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceDiffUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiffUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.FileSystemWatcher_Renamed);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceUsed);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceFree);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxSpaceFree);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxSpaceTotal);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceDiffUnit);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceFreeUnit);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxSpaceDiff);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceTotalUnit);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceDiff);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpacePercentage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpaceUsedUnit);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.progressBarPercentage);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxSpaceUsed);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelSpacePercentageValue);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(272, 137);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(272, 184);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfo,
            this.toolStripSplitButtonSettings2,
            this.toolStripSeparator1,
            this.toolStripButtonShowValueInByte,
            this.toolStripButtonShowValueInKilobyte,
            this.toolStripButtonShowValueInMegabyte,
            this.toolStripButtonShowValueInGigabyte,
            this.toolStripButtonShowValueInTerabyte,
            this.toolStripButtonShowValueInPentabyte,
            this.toolStripSeparator2,
            this.toolStripButtonThousandSeparator,
            this.toolStripDropDownButtonDecimalSeparator});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(272, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            this.toolStrip.TabStop = true;
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.AccessibleDescription = "Open the program information";
            this.toolStripButtonInfo.AccessibleName = "program information";
            this.toolStripButtonInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInfo.Image = global::DisksizeWatcher.Properties.Resources.fatcow_infomation_16;
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInfo.Text = "Program information";
            this.toolStripButtonInfo.Click += new System.EventHandler(this.ToolStripButtonInfo_Click);
            this.toolStripButtonInfo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonInfo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripSplitButtonSettings2
            // 
            this.toolStripSplitButtonSettings2.AccessibleDescription = "Click to open the settings";
            this.toolStripSplitButtonSettings2.AccessibleName = "settings";
            this.toolStripSplitButtonSettings2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripSplitButtonSettings2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonSettings2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemStayOnTop,
            this.menuitemMinimizeToSystemTray});
            this.toolStripSplitButtonSettings2.Image = global::DisksizeWatcher.Properties.Resources.fatcow_wrench_16;
            this.toolStripSplitButtonSettings2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSettings2.Name = "toolStripSplitButtonSettings2";
            this.toolStripSplitButtonSettings2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonSettings2.Text = "Settings";
            this.toolStripSplitButtonSettings2.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonSettings_ButtonClick);
            this.toolStripSplitButtonSettings2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripSplitButtonSettings2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // menuitemStayOnTop
            // 
            this.menuitemStayOnTop.AccessibleDescription = "Click to stay on top";
            this.menuitemStayOnTop.AccessibleName = "stay on top";
            this.menuitemStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
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
            this.menuitemMinimizeToSystemTray.AccessibleName = "minimize to system tray";
            this.menuitemMinimizeToSystemTray.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.menuitemMinimizeToSystemTray.AutoToolTip = true;
            this.menuitemMinimizeToSystemTray.CheckOnClick = true;
            this.menuitemMinimizeToSystemTray.Name = "menuitemMinimizeToSystemTray";
            this.menuitemMinimizeToSystemTray.Size = new System.Drawing.Size(200, 22);
            this.menuitemMinimizeToSystemTray.Text = "&Minimize to system tray";
            this.menuitemMinimizeToSystemTray.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.menuitemMinimizeToSystemTray.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = "Just a separator";
            this.toolStripSeparator1.AccessibleName = "Separator";
            this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonShowValueInByte
            // 
            this.toolStripButtonShowValueInByte.AccessibleDescription = "Show the value in byte";
            this.toolStripButtonShowValueInByte.AccessibleName = "value in byte";
            this.toolStripButtonShowValueInByte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInByte.Checked = true;
            this.toolStripButtonShowValueInByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonShowValueInByte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInByte.Image = global::DisksizeWatcher.Properties.Resources.value_byte_16;
            this.toolStripButtonShowValueInByte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInByte.Name = "toolStripButtonShowValueInByte";
            this.toolStripButtonShowValueInByte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInByte.Text = "Byte";
            this.toolStripButtonShowValueInByte.Click += new System.EventHandler(this.ToolStripButtonShowValueInByte_Click);
            this.toolStripButtonShowValueInByte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInByte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripButtonShowValueInKilobyte
            // 
            this.toolStripButtonShowValueInKilobyte.AccessibleDescription = "Show the value in kilobyte";
            this.toolStripButtonShowValueInKilobyte.AccessibleName = "value in kilobyte";
            this.toolStripButtonShowValueInKilobyte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInKilobyte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInKilobyte.Image = global::DisksizeWatcher.Properties.Resources.value_kilobyte_16;
            this.toolStripButtonShowValueInKilobyte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInKilobyte.Name = "toolStripButtonShowValueInKilobyte";
            this.toolStripButtonShowValueInKilobyte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInKilobyte.Text = "Kilobyte";
            this.toolStripButtonShowValueInKilobyte.Click += new System.EventHandler(this.ToolStripButtonShowValueInKilobyte_Click);
            this.toolStripButtonShowValueInKilobyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInKilobyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripButtonShowValueInMegabyte
            // 
            this.toolStripButtonShowValueInMegabyte.AccessibleDescription = "Show the value in megabyte";
            this.toolStripButtonShowValueInMegabyte.AccessibleName = "value in megabyte";
            this.toolStripButtonShowValueInMegabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInMegabyte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInMegabyte.Image = global::DisksizeWatcher.Properties.Resources.value_megabyte_16;
            this.toolStripButtonShowValueInMegabyte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInMegabyte.Name = "toolStripButtonShowValueInMegabyte";
            this.toolStripButtonShowValueInMegabyte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInMegabyte.Text = "Megabyte";
            this.toolStripButtonShowValueInMegabyte.Click += new System.EventHandler(this.ToolStripButtonShowValueInMegabyte_Click);
            this.toolStripButtonShowValueInMegabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInMegabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripButtonShowValueInGigabyte
            // 
            this.toolStripButtonShowValueInGigabyte.AccessibleDescription = "Show the value in gigabyte";
            this.toolStripButtonShowValueInGigabyte.AccessibleName = "value in gigabyte";
            this.toolStripButtonShowValueInGigabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInGigabyte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInGigabyte.Image = global::DisksizeWatcher.Properties.Resources.value_gigabyte_16;
            this.toolStripButtonShowValueInGigabyte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInGigabyte.Name = "toolStripButtonShowValueInGigabyte";
            this.toolStripButtonShowValueInGigabyte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInGigabyte.Text = "Gigabyte";
            this.toolStripButtonShowValueInGigabyte.Click += new System.EventHandler(this.ToolStripButtonShowValueInGigabyte_Click);
            this.toolStripButtonShowValueInGigabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInGigabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripButtonShowValueInTerabyte
            // 
            this.toolStripButtonShowValueInTerabyte.AccessibleDescription = "Show the value in terabyte";
            this.toolStripButtonShowValueInTerabyte.AccessibleName = "value in terabyte";
            this.toolStripButtonShowValueInTerabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInTerabyte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInTerabyte.Image = global::DisksizeWatcher.Properties.Resources.value_terabyte_16;
            this.toolStripButtonShowValueInTerabyte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInTerabyte.Name = "toolStripButtonShowValueInTerabyte";
            this.toolStripButtonShowValueInTerabyte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInTerabyte.Text = "Terabyte";
            this.toolStripButtonShowValueInTerabyte.Click += new System.EventHandler(this.ToolStripButtonShowValueInTerabyte_Click);
            this.toolStripButtonShowValueInTerabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInTerabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripButtonShowValueInPentabyte
            // 
            this.toolStripButtonShowValueInPentabyte.AccessibleDescription = "Show the value in pentabyte";
            this.toolStripButtonShowValueInPentabyte.AccessibleName = "value in pentabyte";
            this.toolStripButtonShowValueInPentabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonShowValueInPentabyte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowValueInPentabyte.Image = global::DisksizeWatcher.Properties.Resources.value_pentabyte_16;
            this.toolStripButtonShowValueInPentabyte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowValueInPentabyte.Name = "toolStripButtonShowValueInPentabyte";
            this.toolStripButtonShowValueInPentabyte.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonShowValueInPentabyte.Text = "Pentabyte";
            this.toolStripButtonShowValueInPentabyte.Click += new System.EventHandler(this.ToolStripButtonShowValueInPentabyte_Click);
            this.toolStripButtonShowValueInPentabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonShowValueInPentabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = "Just a separator";
            this.toolStripSeparator2.AccessibleName = "Separator";
            this.toolStripSeparator2.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonThousandSeparator
            // 
            this.toolStripButtonThousandSeparator.AccessibleDescription = "Enable or disable the thousand separator";
            this.toolStripButtonThousandSeparator.AccessibleName = "Thousand separator";
            this.toolStripButtonThousandSeparator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.toolStripButtonThousandSeparator.CheckOnClick = true;
            this.toolStripButtonThousandSeparator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonThousandSeparator.Image = global::DisksizeWatcher.Properties.Resources.thousand_separator_16;
            this.toolStripButtonThousandSeparator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThousandSeparator.Name = "toolStripButtonThousandSeparator";
            this.toolStripButtonThousandSeparator.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonThousandSeparator.Text = "Thousand separator";
            this.toolStripButtonThousandSeparator.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripButtonThousandSeparator.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripDropDownButtonDecimalSeparator
            // 
            this.toolStripDropDownButtonDecimalSeparator.AccessibleDescription = "Choose the value of the decimal separator";
            this.toolStripDropDownButtonDecimalSeparator.AccessibleName = "Decimal separator";
            this.toolStripDropDownButtonDecimalSeparator.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.toolStripDropDownButtonDecimalSeparator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonDecimalSeparator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDecimalSeparatorTo0,
            this.toolStripMenuItemDecimalSeparatorTo1,
            this.toolStripMenuItemDecimalSeparatorTo2,
            this.toolStripMenuItemDecimalSeparatorTo3,
            this.toolStripMenuItemDecimalSeparatorTo4,
            this.toolStripMenuItemDecimalSeparatorTo5,
            this.toolStripMenuItemDecimalSeparatorTo6});
            this.toolStripDropDownButtonDecimalSeparator.Image = global::DisksizeWatcher.Properties.Resources.decimal_separator_16;
            this.toolStripDropDownButtonDecimalSeparator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonDecimalSeparator.Name = "toolStripDropDownButtonDecimalSeparator";
            this.toolStripDropDownButtonDecimalSeparator.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonDecimalSeparator.Text = "Decimal separator";
            this.toolStripDropDownButtonDecimalSeparator.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripDropDownButtonDecimalSeparator.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo0
            // 
            this.toolStripMenuItemDecimalSeparatorTo0.AccessibleDescription = "Set the value of the decimal separator to 0";
            this.toolStripMenuItemDecimalSeparatorTo0.AccessibleName = "Value of the decimal separator is 0";
            this.toolStripMenuItemDecimalSeparatorTo0.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo0.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo0.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo0.Name = "toolStripMenuItemDecimalSeparatorTo0";
            this.toolStripMenuItemDecimalSeparatorTo0.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo0.Text = "&0";
            this.toolStripMenuItemDecimalSeparatorTo0.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo0_Click);
            this.toolStripMenuItemDecimalSeparatorTo0.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo0.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo1
            // 
            this.toolStripMenuItemDecimalSeparatorTo1.AccessibleDescription = "Set the value of the decimal separator to 1";
            this.toolStripMenuItemDecimalSeparatorTo1.AccessibleName = "Value of the decimal separator is 1";
            this.toolStripMenuItemDecimalSeparatorTo1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo1.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo1.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo1.Name = "toolStripMenuItemDecimalSeparatorTo1";
            this.toolStripMenuItemDecimalSeparatorTo1.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo1.Text = "&1";
            this.toolStripMenuItemDecimalSeparatorTo1.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo1_Click);
            this.toolStripMenuItemDecimalSeparatorTo1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo2
            // 
            this.toolStripMenuItemDecimalSeparatorTo2.AccessibleDescription = "Set the value of the decimal separator to 2";
            this.toolStripMenuItemDecimalSeparatorTo2.AccessibleName = "Value of the decimal separator is 2";
            this.toolStripMenuItemDecimalSeparatorTo2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo2.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo2.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo2.Name = "toolStripMenuItemDecimalSeparatorTo2";
            this.toolStripMenuItemDecimalSeparatorTo2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo2.Text = "&2";
            this.toolStripMenuItemDecimalSeparatorTo2.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo2_Click);
            this.toolStripMenuItemDecimalSeparatorTo2.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo2.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo3
            // 
            this.toolStripMenuItemDecimalSeparatorTo3.AccessibleDescription = "Set the value of the decimal separator to 3";
            this.toolStripMenuItemDecimalSeparatorTo3.AccessibleName = "Value of the decimal separator is 3";
            this.toolStripMenuItemDecimalSeparatorTo3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo3.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo3.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo3.Name = "toolStripMenuItemDecimalSeparatorTo3";
            this.toolStripMenuItemDecimalSeparatorTo3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo3.Text = "&3";
            this.toolStripMenuItemDecimalSeparatorTo3.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo3_Click);
            this.toolStripMenuItemDecimalSeparatorTo3.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo3.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo4
            // 
            this.toolStripMenuItemDecimalSeparatorTo4.AccessibleDescription = "Set the value of the decimal separator to 4";
            this.toolStripMenuItemDecimalSeparatorTo4.AccessibleName = "Value of the decimal separator is 4";
            this.toolStripMenuItemDecimalSeparatorTo4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo4.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo4.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo4.Name = "toolStripMenuItemDecimalSeparatorTo4";
            this.toolStripMenuItemDecimalSeparatorTo4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo4.Text = "&4";
            this.toolStripMenuItemDecimalSeparatorTo4.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo4_Click);
            this.toolStripMenuItemDecimalSeparatorTo4.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo4.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo5
            // 
            this.toolStripMenuItemDecimalSeparatorTo5.AccessibleDescription = "Set the value of the decimal separator to 5";
            this.toolStripMenuItemDecimalSeparatorTo5.AccessibleName = "Value of the decimal separator is 5";
            this.toolStripMenuItemDecimalSeparatorTo5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo5.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo5.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo5.Name = "toolStripMenuItemDecimalSeparatorTo5";
            this.toolStripMenuItemDecimalSeparatorTo5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo5.Text = "&5";
            this.toolStripMenuItemDecimalSeparatorTo5.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo5_Click);
            this.toolStripMenuItemDecimalSeparatorTo5.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo5.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDecimalSeparatorTo6
            // 
            this.toolStripMenuItemDecimalSeparatorTo6.AccessibleDescription = "Set the value of the decimal separator to 6";
            this.toolStripMenuItemDecimalSeparatorTo6.AccessibleName = "Value of the decimal separator is 6";
            this.toolStripMenuItemDecimalSeparatorTo6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDecimalSeparatorTo6.AutoToolTip = true;
            this.toolStripMenuItemDecimalSeparatorTo6.Checked = true;
            this.toolStripMenuItemDecimalSeparatorTo6.CheckOnClick = true;
            this.toolStripMenuItemDecimalSeparatorTo6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemDecimalSeparatorTo6.Name = "toolStripMenuItemDecimalSeparatorTo6";
            this.toolStripMenuItemDecimalSeparatorTo6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemDecimalSeparatorTo6.Text = "&6";
            this.toolStripMenuItemDecimalSeparatorTo6.Click += new System.EventHandler(this.ToolStripMenuItemDecimalSeparatorTo6_Click);
            this.toolStripMenuItemDecimalSeparatorTo6.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDecimalSeparatorTo6.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // MainForm
            // 
            this.AccessibleDescription = "This is the main window.";
            this.AccessibleName = "Main window";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 184);
            this.Controls.Add(this.toolStripContainer1);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.TextBox textBoxSpaceTotal;
		private System.Windows.Forms.Label labelSpaceTotal;
		private System.Windows.Forms.TextBox textBoxSpaceFree;
		private System.Windows.Forms.Label labelSpaceFree;
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
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelSpaceDiff;
		private System.Windows.Forms.TextBox textBoxSpaceDiff;
		private System.Windows.Forms.Label labelSpaceDiffUnit;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInByte;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInKilobyte;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInMegabyte;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInGigabyte;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInTerabyte;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowValueInPentabyte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonThousandSeparator;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDecimalSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo0;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecimalSeparatorTo6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSettings2;
        private System.Windows.Forms.ToolStripMenuItem menuitemStayOnTop;
        private System.Windows.Forms.ToolStripMenuItem menuitemMinimizeToSystemTray;
    }
}

