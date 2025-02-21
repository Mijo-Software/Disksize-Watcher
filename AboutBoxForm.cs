using System.Diagnostics;
using System.Globalization;
using NLog;

namespace DisksizeWatcher
{
	/// <summary>
	/// Provides information about the culture used by the current thread
	/// </summary>
	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Handles exceptions by logging the error and showing a message box.
		/// </summary>
		/// <param name="ex">The exception that occurred.</param>
		/// <param name="message">The message to log and display.</param>
		/// <param name="sender">The source of the event that caused the exception.</param>
		/// <param name="e">The event data associated with the exception.</param>
		private static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
		{
			// Implement logging logic here (e.g., log to a file or monitoring system)
			string msg = $"Error: {ex}\nMessage: {ex.Message}\nStackTrack: {ex.StackTrace}\nSender: {sender}, EventArgs: {e}";
			Debug.WriteLine(value: msg);
			Console.WriteLine(value: msg);
			Logger.Error(exception: ex, message: msg);
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

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
		/// Constructor
		/// </summary>
		public AboutBoxForm()
		{
			try
			{
				InitializeComponent();
				// Replace the incorrect event handler assignment with the correct method name
				this.KeyDown += new KeyEventHandler(AboutBoxForm_KeyDown);
				this.KeyPreview = true; // Ensures the form receives key events before the controls
				Logger.Info(message: "LicenseForm initialized");
				CultureInfo culture = CultureInfo.CurrentCulture;
				Text = string.Format(provider: culture, format: "Info about {0}", args: AssemblyInfo.AssemblyTitle);
				labelProductName.Text = AssemblyInfo.AssemblyProduct;
				labelVersion.Text = AssemblyInfo.AssemblyVersion;
				labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
				labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
				textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while initializing the AboutBoxForm.");
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
			try
			{
				SetStatusbarText(text: string.Empty);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while loading the AboutBoxForm.");
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
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
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
		private void AboutBoxForm_KeyDown(object? sender, KeyEventArgs e)
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
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
			}
		}
	}
}


