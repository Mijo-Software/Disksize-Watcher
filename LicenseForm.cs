using NLog;

namespace DisksizeWatcher
{
	/// <summary>
	/// Represents a form for managing license information.
	/// </summary>
	internal partial class LicenseForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public LicenseForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(LicenseForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			Logger.Info(message: "LicenseForm initialized.");
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LicenseForm"/> class.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LicenseForm_Load(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control { AccessibleDescription: { } } control)
			{
				SetStatusbarText(text: control.AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
			{
				SetStatusbarText(text: control2.AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
			{
				SetStatusbarText(text: control3.AccessibleDescription);
			}
		}

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Handles the KeyDown event of the LicenseForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}