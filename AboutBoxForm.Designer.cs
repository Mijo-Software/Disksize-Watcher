
namespace DisksizeWatcher
{
    partial class AboutBoxForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AccessibleDescription = "Just a pane";
            this.tableLayoutPanel.AccessibleName = "pane";
            this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.25F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.94268F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.84076F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(240, 116);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.AccessibleDescription = "This is the program icon.";
            this.logoPictureBox.AccessibleName = "program icon";
            this.logoPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::DisksizeWatcher.Properties.Resources.fatcow_disk_space_32;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(39, 110);
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.logoPictureBox, "program icon");
            this.logoPictureBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.logoPictureBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelProductName
            // 
            this.labelProductName.AccessibleDescription = "Show the product name";
            this.labelProductName.AccessibleName = "Product name";
            this.labelProductName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelProductName.AutoEllipsis = true;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelProductName.Location = new System.Drawing.Point(51, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(186, 11);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelProductName, "Product name");
            this.labelProductName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelProductName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelProductName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelProductName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelVersion
            // 
            this.labelVersion.AccessibleDescription = "Show the version";
            this.labelVersion.AccessibleName = "Version";
            this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelVersion.AutoEllipsis = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelVersion.Location = new System.Drawing.Point(51, 11);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(186, 11);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelVersion, "Version");
            this.labelVersion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelVersion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelVersion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelVersion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AccessibleDescription = "Show the copyright";
            this.labelCopyright.AccessibleName = "Copyright";
            this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelCopyright.AutoEllipsis = true;
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelCopyright.Location = new System.Drawing.Point(51, 22);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(186, 11);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelCopyright, "Copyright");
            this.labelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AccessibleDescription = "Show the company name";
            this.labelCompanyName.AccessibleName = "Company name";
            this.labelCompanyName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelCompanyName.AutoEllipsis = true;
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelCompanyName.Location = new System.Drawing.Point(51, 33);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(186, 11);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Company name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelCompanyName, "Copyright name");
            this.labelCompanyName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelCompanyName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelCompanyName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelCompanyName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = "Show the description";
            this.textBoxDescription.AccessibleName = "Description";
            this.textBoxDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(51, 47);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(186, 36);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            this.toolTip.SetToolTip(this.textBoxDescription, "Description");
            this.textBoxDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxDescription.MouseEnter += new System.EventHandler(this.AboutBoxForm_Load);
            this.textBoxDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // okButton
            // 
            this.okButton.AccessibleDescription = "Close the window";
            this.okButton.AccessibleName = "OK button";
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AutoEllipsis = true;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Image = global::DisksizeWatcher.Properties.Resources.fatcow_tick_octagon_16;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(162, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okButton.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.okButton.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.okButton.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.okButton.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
            this.statusStrip.Size = new System.Drawing.Size(240, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.TabStop = true;
            this.statusStrip.Text = "statusStrip";
            this.toolTip.SetToolTip(this.statusStrip, "Show the status bar");
            // 
            // labelInformation
            // 
            this.labelInformation.AccessibleDescription = "Show some information";
            this.labelInformation.AccessibleName = "some information";
            this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelInformation.AutoToolTip = true;
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(28, 17);
            this.labelInformation.Text = "info";
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.AccessibleDescription = "Just a tool bar";
            this.toolStripContainer.AccessibleName = "tool bar";
            this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(240, 116);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(9, 9);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(240, 163);
            this.toolStripContainer.TabIndex = 8;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // AboutBoxForm
            // 
            this.AcceptButton = this.okButton;
            this.AccessibleDescription = "This is the program information window.";
            this.AccessibleName = "Program information";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 181);
            this.Controls.Add(this.toolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBoxForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program information";
            this.Load += new System.EventHandler(this.AboutBoxForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelInformation;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
    }
}
