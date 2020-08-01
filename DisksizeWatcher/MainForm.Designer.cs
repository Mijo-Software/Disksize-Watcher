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
			this.labelDisksizeCurrent = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.textBoxDisksizeCurrent = new System.Windows.Forms.TextBox();
			this.textBoxDisksizeTotal = new System.Windows.Forms.TextBox();
			this.labelDisksizeTotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelPercentage = new System.Windows.Forms.Label();
			this.progressBarPercentage = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
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
			// labelDisksizeCurrent
			// 
			this.labelDisksizeCurrent.AutoSize = true;
			this.labelDisksizeCurrent.Location = new System.Drawing.Point(12, 9);
			this.labelDisksizeCurrent.Name = "labelDisksizeCurrent";
			this.labelDisksizeCurrent.Size = new System.Drawing.Size(84, 13);
			this.labelDisksizeCurrent.TabIndex = 0;
			this.labelDisksizeCurrent.Text = "Current disksize:";
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "notify";
			this.notifyIcon.Visible = true;
			// 
			// textBoxDisksizeCurrent
			// 
			this.textBoxDisksizeCurrent.Enabled = false;
			this.textBoxDisksizeCurrent.Location = new System.Drawing.Point(102, 6);
			this.textBoxDisksizeCurrent.Name = "textBoxDisksizeCurrent";
			this.textBoxDisksizeCurrent.Size = new System.Drawing.Size(149, 20);
			this.textBoxDisksizeCurrent.TabIndex = 1;
			this.textBoxDisksizeCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxDisksizeTotal
			// 
			this.textBoxDisksizeTotal.Enabled = false;
			this.textBoxDisksizeTotal.Location = new System.Drawing.Point(102, 32);
			this.textBoxDisksizeTotal.Name = "textBoxDisksizeTotal";
			this.textBoxDisksizeTotal.Size = new System.Drawing.Size(149, 20);
			this.textBoxDisksizeTotal.TabIndex = 3;
			this.textBoxDisksizeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// labelDisksizeTotal
			// 
			this.labelDisksizeTotal.AutoSize = true;
			this.labelDisksizeTotal.Location = new System.Drawing.Point(12, 35);
			this.labelDisksizeTotal.Name = "labelDisksizeTotal";
			this.labelDisksizeTotal.Size = new System.Drawing.Size(74, 13);
			this.labelDisksizeTotal.TabIndex = 2;
			this.labelDisksizeTotal.Text = "Total disksize:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(257, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "bytes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "bytes";
			// 
			// labelPercentage
			// 
			this.labelPercentage.AutoSize = true;
			this.labelPercentage.Location = new System.Drawing.Point(12, 58);
			this.labelPercentage.Name = "labelPercentage";
			this.labelPercentage.Size = new System.Drawing.Size(65, 13);
			this.labelPercentage.TabIndex = 6;
			this.labelPercentage.Text = "Percentage:";
			// 
			// progressBarPercentage
			// 
			this.progressBarPercentage.Location = new System.Drawing.Point(102, 58);
			this.progressBarPercentage.Name = "progressBarPercentage";
			this.progressBarPercentage.Size = new System.Drawing.Size(149, 13);
			this.progressBarPercentage.Step = 1;
			this.progressBarPercentage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarPercentage.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "%";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 85);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBarPercentage);
			this.Controls.Add(this.labelPercentage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDisksizeTotal);
			this.Controls.Add(this.labelDisksizeTotal);
			this.Controls.Add(this.textBoxDisksizeCurrent);
			this.Controls.Add(this.labelDisksizeCurrent);
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
		private System.Windows.Forms.TextBox textBoxDisksizeTotal;
		private System.Windows.Forms.Label labelDisksizeTotal;
		private System.Windows.Forms.TextBox textBoxDisksizeCurrent;
		private System.Windows.Forms.Label labelDisksizeCurrent;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBarPercentage;
		private System.Windows.Forms.Label labelPercentage;
	}
}

