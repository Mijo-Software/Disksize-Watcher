
namespace DisksizeWatcher
{
	partial class LicenseForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
			toolTip = new ToolTip(components);
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			textBoxLicense = new TextBox();
			toolStripContainer = new ToolStripContainer();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
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
			statusStrip.Size = new Size(281, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			toolTip.SetToolTip(statusStrip, "Show the status bar");
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(28, 17);
			labelInformation.Text = "info";
			// 
			// textBoxLicense
			// 
			textBoxLicense.AccessibleDescription = "Show the license";
			textBoxLicense.AccessibleName = "License";
			textBoxLicense.AccessibleRole = AccessibleRole.Text;
			textBoxLicense.Dock = DockStyle.Fill;
			textBoxLicense.Location = new Point(0, 0);
			textBoxLicense.Margin = new Padding(7, 3, 4, 3);
			textBoxLicense.MaxLength = 9999999;
			textBoxLicense.Multiline = true;
			textBoxLicense.Name = "textBoxLicense";
			textBoxLicense.PlaceholderText = "license here... 😉";
			textBoxLicense.ReadOnly = true;
			textBoxLicense.ScrollBars = ScrollBars.Both;
			textBoxLicense.Size = new Size(281, 142);
			textBoxLicense.TabIndex = 6;
			textBoxLicense.Text = resources.GetString("textBoxLicense.Text");
			toolTip.SetToolTip(textBoxLicense, "License");
			textBoxLicense.Enter += SetStatusbar_Enter;
			textBoxLicense.Leave += ClearStatusbar_Leave;
			textBoxLicense.MouseEnter += SetStatusbar_Enter;
			textBoxLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Just a tool bar";
			toolStripContainer.AccessibleName = "tool bar";
			toolStripContainer.AccessibleRole = AccessibleRole.ToolBar;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(textBoxLicense);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(281, 142);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(10, 10);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(281, 189);
			toolStripContainer.TabIndex = 8;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// LicenseForm
			// 
			AccessibleDescription = "This is the license information window.";
			AccessibleName = "License information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(301, 209);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "LicenseForm";
			Padding = new Padding(10);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "License information";
			Load += LicenseForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ContentPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private ToolTip toolTip;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolStripContainer toolStripContainer;
		private TextBox textBoxLicense;
	}
}
