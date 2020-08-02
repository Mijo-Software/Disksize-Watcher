﻿namespace DisksizeWatcher
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
			this.checkBoxStayOnTop = new System.Windows.Forms.CheckBox();
			this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
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
			// checkBoxMinimizeToTray
			// 
			this.checkBoxMinimizeToTray.AutoSize = true;
			this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(13, 36);
			this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
			this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(98, 17);
			this.checkBoxMinimizeToTray.TabIndex = 1;
			this.checkBoxMinimizeToTray.Text = "&Minimize to tray";
			this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(13, 70);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 2;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(94, 70);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(187, 107);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.checkBoxMinimizeToTray);
			this.Controls.Add(this.checkBoxStayOnTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxStayOnTop;
		private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonCancel;
	}
}