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
            this.contextMenuStripFreeSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFreeSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFreeSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFreeSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFreeSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFreeSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFreeSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSpaceTotalUnit = new System.Windows.Forms.Label();
            this.contextMenuStripTotalSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTotalSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTotalSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTotalSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTotalSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTotalSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTotalSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSpacePercentage = new System.Windows.Forms.Label();
            this.progressBarPercentage = new System.Windows.Forms.ProgressBar();
            this.labelSpacePercentageValue = new System.Windows.Forms.Label();
            this.labelSpaceUsedUnit = new System.Windows.Forms.Label();
            this.contextMenuStripUsedSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUsedSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsedSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsedSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsedSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsedSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsedSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSpaceUsed = new System.Windows.Forms.TextBox();
            this.labelSpaceUsed = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.menuitemStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemMinimizeToSystemTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelSpaceDiff = new System.Windows.Forms.Label();
            this.textBoxSpaceDiff = new System.Windows.Forms.TextBox();
            this.labelSpaceDiffUnit = new System.Windows.Forms.Label();
            this.contextMenuStripDiffSpaceUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDiffSpaceUnitByte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiffSpaceUnitKilobyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiffSpaceUnitMegabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiffSpaceUnitGigabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiffSpaceUnitTerabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDiffSpaceUnitPentabyte = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFreeSpaceUnits.SuspendLayout();
            this.contextMenuStripTotalSpaceUnits.SuspendLayout();
            this.contextMenuStripUsedSpaceUnits.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripDiffSpaceUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labelSpaceFree
            // 
            this.labelSpaceFree.AccessibleDescription = "Show the free space";
            this.labelSpaceFree.AccessibleName = "free space";
            this.labelSpaceFree.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceFree.AutoEllipsis = true;
            this.labelSpaceFree.Location = new System.Drawing.Point(11, 41);
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
            this.textBoxSpaceFree.Location = new System.Drawing.Point(82, 38);
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
            this.textBoxSpaceTotal.Location = new System.Drawing.Point(82, 64);
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
            this.labelSpaceTotal.Location = new System.Drawing.Point(11, 67);
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
            this.labelSpaceFreeUnit.ContextMenuStrip = this.contextMenuStripFreeSpaceUnits;
            this.labelSpaceFreeUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSpaceFreeUnit.Location = new System.Drawing.Point(199, 41);
            this.labelSpaceFreeUnit.Name = "labelSpaceFreeUnit";
            this.labelSpaceFreeUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceFreeUnit.TabIndex = 5;
            this.labelSpaceFreeUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceFreeUnit, "Show the unit of the free space");
            this.labelSpaceFreeUnit.Click += new System.EventHandler(this.LabelSpaceFreeUnit_Click);
            this.labelSpaceFreeUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceFreeUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceFreeUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceFreeUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // contextMenuStripFreeSpaceUnits
            // 
            this.contextMenuStripFreeSpaceUnits.AccessibleDescription = "Show the units of the free space as context menu";
            this.contextMenuStripFreeSpaceUnits.AccessibleName = "units of the free space";
            this.contextMenuStripFreeSpaceUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
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
            this.contextMenuStripFreeSpaceUnits.Text = "Units of the free space";
            this.toolTip.SetToolTip(this.contextMenuStripFreeSpaceUnits, "Show the units of the free space as context menu");
            this.contextMenuStripFreeSpaceUnits.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.contextMenuStripFreeSpaceUnits.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitByte
            // 
            this.toolStripMenuItemFreeSpaceUnitByte.AccessibleDescription = "Choose byte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitByte.AccessibleName = "value \'byte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitByte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitByte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitByte.Checked = true;
            this.toolStripMenuItemFreeSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFreeSpaceUnitByte.Name = "toolStripMenuItemFreeSpaceUnitByte";
            this.toolStripMenuItemFreeSpaceUnitByte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitByte.Text = "&byte";
            this.toolStripMenuItemFreeSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitByte_Click);
            this.toolStripMenuItemFreeSpaceUnitByte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitByte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitKilobyte
            // 
            this.toolStripMenuItemFreeSpaceUnitKilobyte.AccessibleDescription = "Choose kilobyte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitKilobyte.AccessibleName = "value \'kilobyte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitKilobyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitKilobyte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitKilobyte.Name = "toolStripMenuItemFreeSpaceUnitKilobyte";
            this.toolStripMenuItemFreeSpaceUnitKilobyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitKilobyte.Text = "&kilobyte";
            this.toolStripMenuItemFreeSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitKilobyte_Click);
            this.toolStripMenuItemFreeSpaceUnitKilobyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitKilobyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitMegabyte
            // 
            this.toolStripMenuItemFreeSpaceUnitMegabyte.AccessibleDescription = "Choose megabyte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitMegabyte.AccessibleName = "value \'megabyte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitMegabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitMegabyte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitMegabyte.Name = "toolStripMenuItemFreeSpaceUnitMegabyte";
            this.toolStripMenuItemFreeSpaceUnitMegabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitMegabyte.Text = "&megabyte";
            this.toolStripMenuItemFreeSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitMegabyte_Click);
            this.toolStripMenuItemFreeSpaceUnitMegabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitMegabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitGigabyte
            // 
            this.toolStripMenuItemFreeSpaceUnitGigabyte.AccessibleDescription = "Choose gigabyte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitGigabyte.AccessibleName = "value \'gigabyte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitGigabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitGigabyte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitGigabyte.Name = "toolStripMenuItemFreeSpaceUnitGigabyte";
            this.toolStripMenuItemFreeSpaceUnitGigabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitGigabyte.Text = "&gigabyte";
            this.toolStripMenuItemFreeSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitGigabyte_Click);
            this.toolStripMenuItemFreeSpaceUnitGigabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitGigabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitTerabyte
            // 
            this.toolStripMenuItemFreeSpaceUnitTerabyte.AccessibleDescription = "Choose terabyte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitTerabyte.AccessibleName = "value \'terabyte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitTerabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitTerabyte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitTerabyte.Name = "toolStripMenuItemFreeSpaceUnitTerabyte";
            this.toolStripMenuItemFreeSpaceUnitTerabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitTerabyte.Text = "&terabyte";
            this.toolStripMenuItemFreeSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitTerabyte_Click);
            this.toolStripMenuItemFreeSpaceUnitTerabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitTerabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemFreeSpaceUnitPentabyte
            // 
            this.toolStripMenuItemFreeSpaceUnitPentabyte.AccessibleDescription = "Choose pentabyte as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitPentabyte.AccessibleName = "value \'pentabyte\' as unit for the free space";
            this.toolStripMenuItemFreeSpaceUnitPentabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemFreeSpaceUnitPentabyte.AutoToolTip = true;
            this.toolStripMenuItemFreeSpaceUnitPentabyte.Name = "toolStripMenuItemFreeSpaceUnitPentabyte";
            this.toolStripMenuItemFreeSpaceUnitPentabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemFreeSpaceUnitPentabyte.Text = "&pentabyte";
            this.toolStripMenuItemFreeSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemFreeSpaceUnitPentabyte_Click);
            this.toolStripMenuItemFreeSpaceUnitPentabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemFreeSpaceUnitPentabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpaceTotalUnit
            // 
            this.labelSpaceTotalUnit.AccessibleDescription = "Show the unit of the total space";
            this.labelSpaceTotalUnit.AccessibleName = "unit of the total space";
            this.labelSpaceTotalUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceTotalUnit.AutoEllipsis = true;
            this.labelSpaceTotalUnit.AutoSize = true;
            this.labelSpaceTotalUnit.ContextMenuStrip = this.contextMenuStripTotalSpaceUnits;
            this.labelSpaceTotalUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSpaceTotalUnit.Location = new System.Drawing.Point(199, 67);
            this.labelSpaceTotalUnit.Name = "labelSpaceTotalUnit";
            this.labelSpaceTotalUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceTotalUnit.TabIndex = 8;
            this.labelSpaceTotalUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceTotalUnit, "Show the unit of the total space");
            this.labelSpaceTotalUnit.Click += new System.EventHandler(this.LabelSpaceTotalUnit_Click);
            this.labelSpaceTotalUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotalUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceTotalUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceTotalUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // contextMenuStripTotalSpaceUnits
            // 
            this.contextMenuStripTotalSpaceUnits.AccessibleDescription = "Show the units of the total space as context menu";
            this.contextMenuStripTotalSpaceUnits.AccessibleName = "units of the total space";
            this.contextMenuStripTotalSpaceUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.contextMenuStripTotalSpaceUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTotalSpaceUnitByte,
            this.toolStripMenuItemTotalSpaceUnitKilobyte,
            this.toolStripMenuItemTotalSpaceUnitMegabyte,
            this.toolStripMenuItemTotalSpaceUnitGigabyte,
            this.toolStripMenuItemTotalSpaceUnitTerabyte,
            this.toolStripMenuItemTotalSpaceUnitPentabyte});
            this.contextMenuStripTotalSpaceUnits.Name = "contextMenuStripUsedTotalUnits";
            this.contextMenuStripTotalSpaceUnits.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripTotalSpaceUnits.Size = new System.Drawing.Size(128, 136);
            this.contextMenuStripTotalSpaceUnits.TabStop = true;
            this.contextMenuStripTotalSpaceUnits.Text = "units of the total space";
            this.toolTip.SetToolTip(this.contextMenuStripTotalSpaceUnits, "Show the units of the total space as context menu");
            this.contextMenuStripTotalSpaceUnits.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.contextMenuStripTotalSpaceUnits.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitByte
            // 
            this.toolStripMenuItemTotalSpaceUnitByte.AccessibleDescription = "Choose byte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitByte.AccessibleName = "value \'byte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitByte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitByte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitByte.Checked = true;
            this.toolStripMenuItemTotalSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemTotalSpaceUnitByte.Name = "toolStripMenuItemTotalSpaceUnitByte";
            this.toolStripMenuItemTotalSpaceUnitByte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitByte.Text = "&byte";
            this.toolStripMenuItemTotalSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitByte_Click);
            this.toolStripMenuItemTotalSpaceUnitByte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitByte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitKilobyte
            // 
            this.toolStripMenuItemTotalSpaceUnitKilobyte.AccessibleDescription = "Choose kilobyte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitKilobyte.AccessibleName = "value \'kilobyte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitKilobyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitKilobyte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitKilobyte.Name = "toolStripMenuItemTotalSpaceUnitKilobyte";
            this.toolStripMenuItemTotalSpaceUnitKilobyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitKilobyte.Text = "&kilobyte";
            this.toolStripMenuItemTotalSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitKilobyte_Click);
            this.toolStripMenuItemTotalSpaceUnitKilobyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitKilobyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitMegabyte
            // 
            this.toolStripMenuItemTotalSpaceUnitMegabyte.AccessibleDescription = "Choose megabyte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitMegabyte.AccessibleName = "value \'megabyte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitMegabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitMegabyte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitMegabyte.Name = "toolStripMenuItemTotalSpaceUnitMegabyte";
            this.toolStripMenuItemTotalSpaceUnitMegabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitMegabyte.Text = "&megabyte";
            this.toolStripMenuItemTotalSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitMegabyte_Click);
            this.toolStripMenuItemTotalSpaceUnitMegabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitMegabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitGigabyte
            // 
            this.toolStripMenuItemTotalSpaceUnitGigabyte.AccessibleDescription = "Choose gigabyte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitGigabyte.AccessibleName = "value \'gigabyte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitGigabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitGigabyte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitGigabyte.Name = "toolStripMenuItemTotalSpaceUnitGigabyte";
            this.toolStripMenuItemTotalSpaceUnitGigabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitGigabyte.Text = "&gigabyte";
            this.toolStripMenuItemTotalSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitGigabyte_Click);
            this.toolStripMenuItemTotalSpaceUnitGigabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitGigabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitTerabyte
            // 
            this.toolStripMenuItemTotalSpaceUnitTerabyte.AccessibleDescription = "Choose terabyte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitTerabyte.AccessibleName = "value \'terabyte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitTerabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitTerabyte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitTerabyte.Name = "toolStripMenuItemTotalSpaceUnitTerabyte";
            this.toolStripMenuItemTotalSpaceUnitTerabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitTerabyte.Text = "&terabyte";
            this.toolStripMenuItemTotalSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitTerabyte_Click);
            this.toolStripMenuItemTotalSpaceUnitTerabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitTerabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemTotalSpaceUnitPentabyte
            // 
            this.toolStripMenuItemTotalSpaceUnitPentabyte.AccessibleDescription = "Choose pentabyte as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitPentabyte.AccessibleName = "value \'pentabyte\' as unit for the total space";
            this.toolStripMenuItemTotalSpaceUnitPentabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemTotalSpaceUnitPentabyte.AutoToolTip = true;
            this.toolStripMenuItemTotalSpaceUnitPentabyte.Name = "toolStripMenuItemTotalSpaceUnitPentabyte";
            this.toolStripMenuItemTotalSpaceUnitPentabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemTotalSpaceUnitPentabyte.Text = "&pentabyte";
            this.toolStripMenuItemTotalSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemTotalSpaceUnitPentabyte_Click);
            this.toolStripMenuItemTotalSpaceUnitPentabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemTotalSpaceUnitPentabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSpacePercentage
            // 
            this.labelSpacePercentage.AccessibleDescription = "Show the percentage";
            this.labelSpacePercentage.AccessibleName = "pecrentage";
            this.labelSpacePercentage.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpacePercentage.AutoEllipsis = true;
            this.labelSpacePercentage.AutoSize = true;
            this.labelSpacePercentage.Location = new System.Drawing.Point(13, 116);
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
            this.progressBarPercentage.Location = new System.Drawing.Point(82, 116);
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
            this.labelSpacePercentageValue.Location = new System.Drawing.Point(199, 116);
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
            this.labelSpaceUsedUnit.ContextMenuStrip = this.contextMenuStripUsedSpaceUnits;
            this.labelSpaceUsedUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSpaceUsedUnit.Location = new System.Drawing.Point(199, 15);
            this.labelSpaceUsedUnit.Name = "labelSpaceUsedUnit";
            this.labelSpaceUsedUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceUsedUnit.TabIndex = 2;
            this.labelSpaceUsedUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceUsedUnit, "Show the unit of the used space");
            this.labelSpaceUsedUnit.Click += new System.EventHandler(this.LabelSpaceUsedUnit_Click);
            this.labelSpaceUsedUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsedUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceUsedUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceUsedUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // contextMenuStripUsedSpaceUnits
            // 
            this.contextMenuStripUsedSpaceUnits.AccessibleDescription = "Show the units of the used space as context menu";
            this.contextMenuStripUsedSpaceUnits.AccessibleName = "units of the used space";
            this.contextMenuStripUsedSpaceUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
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
            this.contextMenuStripUsedSpaceUnits.Text = "units of the used space";
            this.contextMenuStripUsedSpaceUnits.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.contextMenuStripUsedSpaceUnits.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitByte
            // 
            this.toolStripMenuItemUsedSpaceUnitByte.AccessibleDescription = "Choose byte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitByte.AccessibleName = "value \'byte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitByte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitByte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitByte.Checked = true;
            this.toolStripMenuItemUsedSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemUsedSpaceUnitByte.Name = "toolStripMenuItemUsedSpaceUnitByte";
            this.toolStripMenuItemUsedSpaceUnitByte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitByte.Text = "&byte";
            this.toolStripMenuItemUsedSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitByte_Click);
            this.toolStripMenuItemUsedSpaceUnitByte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitByte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitKilobyte
            // 
            this.toolStripMenuItemUsedSpaceUnitKilobyte.AccessibleDescription = "Choose kilobyte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitKilobyte.AccessibleName = "value \'kilobyte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitKilobyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitKilobyte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitKilobyte.Name = "toolStripMenuItemUsedSpaceUnitKilobyte";
            this.toolStripMenuItemUsedSpaceUnitKilobyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitKilobyte.Text = "&kilobyte";
            this.toolStripMenuItemUsedSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitKilobyte_Click);
            this.toolStripMenuItemUsedSpaceUnitKilobyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitKilobyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitMegabyte
            // 
            this.toolStripMenuItemUsedSpaceUnitMegabyte.AccessibleDescription = "Choose megabyte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitMegabyte.AccessibleName = "value \'megabyte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitMegabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitMegabyte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitMegabyte.Name = "toolStripMenuItemUsedSpaceUnitMegabyte";
            this.toolStripMenuItemUsedSpaceUnitMegabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitMegabyte.Text = "&megabyte";
            this.toolStripMenuItemUsedSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitMegabyte_Click);
            this.toolStripMenuItemUsedSpaceUnitMegabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitMegabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitGigabyte
            // 
            this.toolStripMenuItemUsedSpaceUnitGigabyte.AccessibleDescription = "Choose gigabyte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitGigabyte.AccessibleName = "value \'gigabyte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitGigabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitGigabyte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitGigabyte.Name = "toolStripMenuItemUsedSpaceUnitGigabyte";
            this.toolStripMenuItemUsedSpaceUnitGigabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitGigabyte.Text = "&gigabyte";
            this.toolStripMenuItemUsedSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitGigabyte_Click);
            this.toolStripMenuItemUsedSpaceUnitGigabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitGigabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitTerabyte
            // 
            this.toolStripMenuItemUsedSpaceUnitTerabyte.AccessibleDescription = "Choose terabyte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitTerabyte.AccessibleName = "value \'terabyte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitTerabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitTerabyte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitTerabyte.Name = "toolStripMenuItemUsedSpaceUnitTerabyte";
            this.toolStripMenuItemUsedSpaceUnitTerabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitTerabyte.Text = "&terabyte";
            this.toolStripMenuItemUsedSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitTerabyte_Click);
            this.toolStripMenuItemUsedSpaceUnitTerabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitTerabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemUsedSpaceUnitPentabyte
            // 
            this.toolStripMenuItemUsedSpaceUnitPentabyte.AccessibleDescription = "Choose pentabyte as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitPentabyte.AccessibleName = "value \'pentabyte\' as unit for the used space";
            this.toolStripMenuItemUsedSpaceUnitPentabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemUsedSpaceUnitPentabyte.AutoToolTip = true;
            this.toolStripMenuItemUsedSpaceUnitPentabyte.Name = "toolStripMenuItemUsedSpaceUnitPentabyte";
            this.toolStripMenuItemUsedSpaceUnitPentabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemUsedSpaceUnitPentabyte.Text = "&pentabyte";
            this.toolStripMenuItemUsedSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemUsedSpaceUnitPentabyte_Click);
            this.toolStripMenuItemUsedSpaceUnitPentabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemUsedSpaceUnitPentabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSpaceUsed
            // 
            this.textBoxSpaceUsed.AccessibleDescription = "Show the value of the used space";
            this.textBoxSpaceUsed.AccessibleName = "value of the used space";
            this.textBoxSpaceUsed.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSpaceUsed.Location = new System.Drawing.Point(82, 12);
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
            this.labelSpaceUsed.Location = new System.Drawing.Point(11, 15);
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
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation,
            this.toolStripSplitButtonSettings});
            this.statusStrip.Location = new System.Drawing.Point(0, 138);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(272, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 15;
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
            this.toolStripSplitButtonSettings.AccessibleName = "settings";
            this.toolStripSplitButtonSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
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
            // labelSpaceDiff
            // 
            this.labelSpaceDiff.AccessibleDescription = "Show the diff space";
            this.labelSpaceDiff.AccessibleName = "diff space";
            this.labelSpaceDiff.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSpaceDiff.AutoSize = true;
            this.labelSpaceDiff.Location = new System.Drawing.Point(12, 93);
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
            this.textBoxSpaceDiff.Location = new System.Drawing.Point(82, 90);
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
            this.labelSpaceDiffUnit.ContextMenuStrip = this.contextMenuStripDiffSpaceUnits;
            this.labelSpaceDiffUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSpaceDiffUnit.Location = new System.Drawing.Point(199, 93);
            this.labelSpaceDiffUnit.Name = "labelSpaceDiffUnit";
            this.labelSpaceDiffUnit.Size = new System.Drawing.Size(32, 13);
            this.labelSpaceDiffUnit.TabIndex = 11;
            this.labelSpaceDiffUnit.Text = "bytes";
            this.toolTip.SetToolTip(this.labelSpaceDiffUnit, "Show the unit of the used space");
            this.labelSpaceDiffUnit.Click += new System.EventHandler(this.LabelSpaceDiffUnit_Click);
            this.labelSpaceDiffUnit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiffUnit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSpaceDiffUnit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSpaceDiffUnit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // contextMenuStripDiffSpaceUnits
            // 
            this.contextMenuStripDiffSpaceUnits.AccessibleDescription = "Show the units of the diff space as context menu";
            this.contextMenuStripDiffSpaceUnits.AccessibleName = "units of the diff space";
            this.contextMenuStripDiffSpaceUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.contextMenuStripDiffSpaceUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDiffSpaceUnitByte,
            this.toolStripMenuItemDiffSpaceUnitKilobyte,
            this.toolStripMenuItemDiffSpaceUnitMegabyte,
            this.toolStripMenuItemDiffSpaceUnitGigabyte,
            this.toolStripMenuItemDiffSpaceUnitTerabyte,
            this.toolStripMenuItemDiffSpaceUnitPentabyte});
            this.contextMenuStripDiffSpaceUnits.Name = "contextMenuStripUsedTotalUnits";
            this.contextMenuStripDiffSpaceUnits.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripDiffSpaceUnits.Size = new System.Drawing.Size(128, 136);
            this.contextMenuStripDiffSpaceUnits.TabStop = true;
            this.contextMenuStripDiffSpaceUnits.Text = "units of the diff space";
            this.toolTip.SetToolTip(this.contextMenuStripDiffSpaceUnits, "Show the units of the diff space as context menu");
            this.contextMenuStripDiffSpaceUnits.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.contextMenuStripDiffSpaceUnits.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitByte
            // 
            this.toolStripMenuItemDiffSpaceUnitByte.AccessibleDescription = "Choose byte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitByte.AccessibleName = "value \'byte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitByte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitByte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitByte.Checked = true;
            this.toolStripMenuItemDiffSpaceUnitByte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemDiffSpaceUnitByte.Name = "toolStripMenuItemDiffSpaceUnitByte";
            this.toolStripMenuItemDiffSpaceUnitByte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitByte.Text = "&byte";
            this.toolStripMenuItemDiffSpaceUnitByte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitByte_Click);
            this.toolStripMenuItemDiffSpaceUnitByte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitByte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitKilobyte
            // 
            this.toolStripMenuItemDiffSpaceUnitKilobyte.AccessibleDescription = "Choose kilobyte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitKilobyte.AccessibleName = "value \'kilobyte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitKilobyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitKilobyte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitKilobyte.Name = "toolStripMenuItemDiffSpaceUnitKilobyte";
            this.toolStripMenuItemDiffSpaceUnitKilobyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitKilobyte.Text = "&kilobyte";
            this.toolStripMenuItemDiffSpaceUnitKilobyte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitKilobyte_Click);
            this.toolStripMenuItemDiffSpaceUnitKilobyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitKilobyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitMegabyte
            // 
            this.toolStripMenuItemDiffSpaceUnitMegabyte.AccessibleDescription = "Choose megabyte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitMegabyte.AccessibleName = "value \'megabyte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitMegabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitMegabyte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitMegabyte.Name = "toolStripMenuItemDiffSpaceUnitMegabyte";
            this.toolStripMenuItemDiffSpaceUnitMegabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitMegabyte.Text = "&megabyte";
            this.toolStripMenuItemDiffSpaceUnitMegabyte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitMegabyte_Click);
            this.toolStripMenuItemDiffSpaceUnitMegabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitMegabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitGigabyte
            // 
            this.toolStripMenuItemDiffSpaceUnitGigabyte.AccessibleDescription = "Choose gigabyte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitGigabyte.AccessibleName = "value \'gigabyte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitGigabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitGigabyte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitGigabyte.Name = "toolStripMenuItemDiffSpaceUnitGigabyte";
            this.toolStripMenuItemDiffSpaceUnitGigabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitGigabyte.Text = "&gigabyte";
            this.toolStripMenuItemDiffSpaceUnitGigabyte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitGigabyte_Click);
            this.toolStripMenuItemDiffSpaceUnitGigabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitGigabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitTerabyte
            // 
            this.toolStripMenuItemDiffSpaceUnitTerabyte.AccessibleDescription = "Choose terabyte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitTerabyte.AccessibleName = "value \'terabyte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitTerabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitTerabyte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitTerabyte.Name = "toolStripMenuItemDiffSpaceUnitTerabyte";
            this.toolStripMenuItemDiffSpaceUnitTerabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitTerabyte.Text = "&terabyte";
            this.toolStripMenuItemDiffSpaceUnitTerabyte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitTerabyte_Click);
            this.toolStripMenuItemDiffSpaceUnitTerabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitTerabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripMenuItemDiffSpaceUnitPentabyte
            // 
            this.toolStripMenuItemDiffSpaceUnitPentabyte.AccessibleDescription = "Choose pentabyte as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitPentabyte.AccessibleName = "value \'pentabyte\' as unit for the diff space";
            this.toolStripMenuItemDiffSpaceUnitPentabyte.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStripMenuItemDiffSpaceUnitPentabyte.AutoToolTip = true;
            this.toolStripMenuItemDiffSpaceUnitPentabyte.Name = "toolStripMenuItemDiffSpaceUnitPentabyte";
            this.toolStripMenuItemDiffSpaceUnitPentabyte.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDiffSpaceUnitPentabyte.Text = "&pentabyte";
            this.toolStripMenuItemDiffSpaceUnitPentabyte.Click += new System.EventHandler(this.ToolStripMenuItemDiffSpaceUnitPentabyte_Click);
            this.toolStripMenuItemDiffSpaceUnitPentabyte.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripMenuItemDiffSpaceUnitPentabyte.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // MainForm
            // 
            this.AccessibleDescription = "This is the main window";
            this.AccessibleName = "main window";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 160);
            this.Controls.Add(this.labelSpaceDiffUnit);
            this.Controls.Add(this.textBoxSpaceDiff);
            this.Controls.Add(this.labelSpaceDiff);
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
            this.contextMenuStripFreeSpaceUnits.ResumeLayout(false);
            this.contextMenuStripTotalSpaceUnits.ResumeLayout(false);
            this.contextMenuStripUsedSpaceUnits.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripDiffSpaceUnits.ResumeLayout(false);
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
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTotalSpaceUnits;
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
		private System.Windows.Forms.Label labelSpaceDiff;
		private System.Windows.Forms.TextBox textBoxSpaceDiff;
		private System.Windows.Forms.Label labelSpaceDiffUnit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDiffSpaceUnits;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitByte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitKilobyte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitMegabyte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitGigabyte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitTerabyte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiffSpaceUnitPentabyte;
    }
}

