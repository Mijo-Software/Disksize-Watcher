namespace DisksizeWatcher
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.checkBoxStayOnTop = new System.Windows.Forms.CheckBox();
			this.checkBoxMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelRefreshRate = new System.Windows.Forms.Label();
			this.numericUpDownRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxStayOnTop
			// 
			this.checkBoxStayOnTop.AutoSize = true;
			this.checkBoxStayOnTop.Location = new System.Drawing.Point(13, 12);
			this.checkBoxStayOnTop.Name = "checkBoxStayOnTop";
			this.checkBoxStayOnTop.Size = new System.Drawing.Size(80, 17);
			this.checkBoxStayOnTop.TabIndex = 0;
			this.checkBoxStayOnTop.Text = "Stay on &top";
			this.checkBoxStayOnTop.UseVisualStyleBackColor = true;
			// 
			// checkBoxMinimizeToSystemTray
			// 
			this.checkBoxMinimizeToSystemTray.AutoSize = true;
			this.checkBoxMinimizeToSystemTray.Location = new System.Drawing.Point(13, 36);
			this.checkBoxMinimizeToSystemTray.Name = "checkBoxMinimizeToSystemTray";
			this.checkBoxMinimizeToSystemTray.Size = new System.Drawing.Size(133, 17);
			this.checkBoxMinimizeToSystemTray.TabIndex = 1;
			this.checkBoxMinimizeToSystemTray.Text = "&Minimize to system tray";
			this.checkBoxMinimizeToSystemTray.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.AutoEllipsis = true;
			this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonApply.Location = new System.Drawing.Point(12, 88);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 4;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.AutoEllipsis = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(93, 88);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelRefreshRate
			// 
			this.labelRefreshRate.AccessibleDescription = "Change the refresh rate";
			this.labelRefreshRate.AutoSize = true;
			this.labelRefreshRate.Location = new System.Drawing.Point(13, 60);
			this.labelRefreshRate.Name = "labelRefreshRate";
			this.labelRefreshRate.Size = new System.Drawing.Size(92, 13);
			this.labelRefreshRate.TabIndex = 2;
			this.labelRefreshRate.Text = "&Refresh rate in ms";
			// 
			// numericUpDownRefreshRate
			// 
			this.numericUpDownRefreshRate.AccessibleDescription = "Change the value of  the refresh rate";
			this.numericUpDownRefreshRate.Location = new System.Drawing.Point(111, 58);
			this.numericUpDownRefreshRate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDownRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRefreshRate.Name = "numericUpDownRefreshRate";
			this.numericUpDownRefreshRate.Size = new System.Drawing.Size(54, 20);
			this.numericUpDownRefreshRate.TabIndex = 3;
			this.numericUpDownRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownRefreshRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// statusStrip
			// 
			this.statusStrip.AllowItemReorder = true;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 120);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(181, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 6;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(28, 17);
			this.labelInformation.Text = "info";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(181, 142);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.numericUpDownRefreshRate);
			this.Controls.Add(this.labelRefreshRate);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.checkBoxMinimizeToSystemTray);
			this.Controls.Add(this.checkBoxStayOnTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshRate)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxStayOnTop;
		private System.Windows.Forms.CheckBox checkBoxMinimizeToSystemTray;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelRefreshRate;
		private System.Windows.Forms.NumericUpDown numericUpDownRefreshRate;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
	}
}