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
			this.fileSystemWatcher = new System.IO.FileSystemWatcher();
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
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
			this.SuspendLayout();
			// 
			// fileSystemWatcher
			// 
			this.fileSystemWatcher.EnableRaisingEvents = true;
			this.fileSystemWatcher.SynchronizingObject = this;
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// labelSpaceFree
			// 
			this.labelSpaceFree.AutoSize = true;
			this.labelSpaceFree.Location = new System.Drawing.Point(11, 41);
			this.labelSpaceFree.Name = "labelSpaceFree";
			this.labelSpaceFree.Size = new System.Drawing.Size(63, 13);
			this.labelSpaceFree.TabIndex = 3;
			this.labelSpaceFree.Text = "&Free space:";
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "notify";
			this.notifyIcon.Visible = true;
			// 
			// textBoxSpaceFree
			// 
			this.textBoxSpaceFree.Location = new System.Drawing.Point(82, 38);
			this.textBoxSpaceFree.Name = "textBoxSpaceFree";
			this.textBoxSpaceFree.ReadOnly = true;
			this.textBoxSpaceFree.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceFree.TabIndex = 4;
			this.textBoxSpaceFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxSpaceTotal
			// 
			this.textBoxSpaceTotal.Location = new System.Drawing.Point(82, 64);
			this.textBoxSpaceTotal.Name = "textBoxSpaceTotal";
			this.textBoxSpaceTotal.ReadOnly = true;
			this.textBoxSpaceTotal.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceTotal.TabIndex = 7;
			this.textBoxSpaceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelSpaceTotal
			// 
			this.labelSpaceTotal.AutoSize = true;
			this.labelSpaceTotal.Location = new System.Drawing.Point(11, 67);
			this.labelSpaceTotal.Name = "labelSpaceTotal";
			this.labelSpaceTotal.Size = new System.Drawing.Size(66, 13);
			this.labelSpaceTotal.TabIndex = 6;
			this.labelSpaceTotal.Text = "&Total space:";
			// 
			// labelSpaceFreeUnit
			// 
			this.labelSpaceFreeUnit.AutoSize = true;
			this.labelSpaceFreeUnit.Location = new System.Drawing.Point(199, 41);
			this.labelSpaceFreeUnit.Name = "labelSpaceFreeUnit";
			this.labelSpaceFreeUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceFreeUnit.TabIndex = 5;
			this.labelSpaceFreeUnit.Text = "bytes";
			// 
			// labelSpaceTotalUnit
			// 
			this.labelSpaceTotalUnit.AutoSize = true;
			this.labelSpaceTotalUnit.Location = new System.Drawing.Point(199, 67);
			this.labelSpaceTotalUnit.Name = "labelSpaceTotalUnit";
			this.labelSpaceTotalUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceTotalUnit.TabIndex = 8;
			this.labelSpaceTotalUnit.Text = "bytes";
			// 
			// labelSpacePercentage
			// 
			this.labelSpacePercentage.AutoSize = true;
			this.labelSpacePercentage.Location = new System.Drawing.Point(11, 90);
			this.labelSpacePercentage.Name = "labelSpacePercentage";
			this.labelSpacePercentage.Size = new System.Drawing.Size(65, 13);
			this.labelSpacePercentage.TabIndex = 9;
			this.labelSpacePercentage.Text = "Percentage:";
			// 
			// progressBarPercentage
			// 
			this.progressBarPercentage.Location = new System.Drawing.Point(82, 90);
			this.progressBarPercentage.Name = "progressBarPercentage";
			this.progressBarPercentage.Size = new System.Drawing.Size(111, 13);
			this.progressBarPercentage.Step = 1;
			this.progressBarPercentage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarPercentage.TabIndex = 10;
			// 
			// labelSpacePercentageValue
			// 
			this.labelSpacePercentageValue.AutoSize = true;
			this.labelSpacePercentageValue.Location = new System.Drawing.Point(199, 90);
			this.labelSpacePercentageValue.Name = "labelSpacePercentageValue";
			this.labelSpacePercentageValue.Size = new System.Drawing.Size(15, 13);
			this.labelSpacePercentageValue.TabIndex = 11;
			this.labelSpacePercentageValue.Text = "%";
			// 
			// labelSpaceUsedUnit
			// 
			this.labelSpaceUsedUnit.AutoSize = true;
			this.labelSpaceUsedUnit.Location = new System.Drawing.Point(199, 15);
			this.labelSpaceUsedUnit.Name = "labelSpaceUsedUnit";
			this.labelSpaceUsedUnit.Size = new System.Drawing.Size(32, 13);
			this.labelSpaceUsedUnit.TabIndex = 2;
			this.labelSpaceUsedUnit.Text = "bytes";
			// 
			// textBoxSpaceUsed
			// 
			this.textBoxSpaceUsed.Location = new System.Drawing.Point(82, 12);
			this.textBoxSpaceUsed.Name = "textBoxSpaceUsed";
			this.textBoxSpaceUsed.ReadOnly = true;
			this.textBoxSpaceUsed.Size = new System.Drawing.Size(111, 20);
			this.textBoxSpaceUsed.TabIndex = 1;
			this.textBoxSpaceUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelSpaceUsed
			// 
			this.labelSpaceUsed.AutoSize = true;
			this.labelSpaceUsed.Location = new System.Drawing.Point(11, 15);
			this.labelSpaceUsed.Name = "labelSpaceUsed";
			this.labelSpaceUsed.Size = new System.Drawing.Size(67, 13);
			this.labelSpaceUsed.TabIndex = 0;
			this.labelSpaceUsed.Text = "&Used space:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 116);
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
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Disksize Watcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.IO.FileSystemWatcher fileSystemWatcher;
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
	}
}

