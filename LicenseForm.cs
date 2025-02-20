using System.Diagnostics;
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
			try
			{
				labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
				labelInformation.Text = text;
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.");
			}
		}

		/// <summary>
		/// Handles exceptions by logging the error and showing a message box.
		/// </summary>
		/// <param name="ex">The exception that occurred.</param>
		/// <param name="message">The message to log and display.</param>
		private static void HandleException(Exception ex, string message)
		{
			Debug.WriteLine(value: ex);
			Logger.Error(exception: ex, message: message);
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public LicenseForm()
		{
			try
			{
				InitializeComponent();
				this.KeyDown += new KeyEventHandler(LicenseForm_KeyDown);
				this.KeyPreview = true; // Ensures the form receives key events before the controls
				Logger.Info(message: "LicenseForm initialized.");
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while initializing the LicenseForm.");
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LicenseForm"/> class.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LicenseForm_Load(object sender, EventArgs e)
		{
			try
			{
				SetStatusbarText(text: string.Empty);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while loading the LicenseForm.");
			}
		}

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
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
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbarText(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control5)
				{
					SetStatusbarText(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control6)
				{
					SetStatusbarText(text: control6.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.");
			}
		}

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e)
		{
			try
			{
				SetStatusbarText(text: string.Empty);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while clearing the status bar text.");
			}
		}

		/// <summary>
		/// Handles the KeyDown event of the LicenseForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_KeyDown(object? sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while handling the KeyDown event.");
			}
		}
	}
}