using MijoSoftware.AssemblyInformation;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace DisksizeWatcher
{
    partial class AboutBoxForm : Form
    {
        /// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

        /// <summary>
        /// Set a specific text to the status bar
        /// </summary>
        /// <param name="text">text with some information</param>
        private void SetStatusbarText(string text)
        {
            labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
            labelInformation.Text = text;
        }

        public AboutBoxForm()
        {
            InitializeComponent();
            Text = string.Format(provider: culture, format: "Info about {0}", args: AssemblyInfo.AssemblyTitle);
            labelProductName.Text = AssemblyInfo.AssemblyProduct;
            labelVersion.Text = AssemblyInfo.AssemblyVersion;
            labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
            labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
            textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
        }

        /// <summary>
        /// Load the form
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void AboutBoxForm_Load(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

        /// <summary>
        /// Detect the accessibility description to set as information text in the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void SetStatusbar_Enter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox _:
                    SetStatusbarText(text: ((TextBox)sender).AccessibleDescription);
                    break;
                case Button _:
                    SetStatusbarText(text: ((Button)sender).AccessibleDescription);
                    break;
                case RadioButton _:
                    SetStatusbarText(text: ((RadioButton)sender).AccessibleDescription);
                    break;
                case CheckBox _:
                    SetStatusbarText(text: ((CheckBox)sender).AccessibleDescription);
                    break;
                case DateTimePicker _:
                    SetStatusbarText(text: ((DateTimePicker)sender).AccessibleDescription);
                    break;
                case Label _:
                    SetStatusbarText(text: ((Label)sender).AccessibleDescription);
                    break;
                case PictureBox _:
                    SetStatusbarText(text: ((PictureBox)sender).AccessibleDescription);
                    break;
                case ToolStripButton _:
                    SetStatusbarText(text: ((ToolStripButton)sender).AccessibleDescription);
                    break;
                case ToolStripMenuItem _:
                    SetStatusbarText(text: ((ToolStripMenuItem)sender).AccessibleDescription);
                    break;
                case ToolStripLabel _:
                    SetStatusbarText(text: ((ToolStripLabel)sender).AccessibleDescription);
                    break;
                case ToolStripComboBox _:
                    SetStatusbarText(text: ((ToolStripComboBox)sender).AccessibleDescription);
                    break;
                case ToolStripDropDown _:
                    SetStatusbarText(text: ((ToolStripDropDown)sender).AccessibleDescription);
                    break;
                case ToolStripDropDownButton _:
                    SetStatusbarText(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
                    break;
                case ToolStripDropDownItem _:
                    SetStatusbarText(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
                    break;
                /*case ToolStripDropDownMenu _:
                    SetStatusbarText(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
                    break;*/
                case ToolStripProgressBar _:
                    SetStatusbarText(text: ((ToolStripProgressBar)sender).AccessibleDescription);
                    break;
                /*case ToolStripSplitButton _:
                    SetStatusbarText(text: ((ToolStripSplitButton)sender).AccessibleDescription);
                    break;*/
                case ToolStripSeparator _:
                    SetStatusbarText(text: ((ToolStripSeparator)sender).AccessibleDescription);
                    break;
                /*case ToolStripStatusLabel _:
                    SetStatusbarText(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
                    break;*/
                case ToolStripTextBox _:
                    SetStatusbarText(text: ((ToolStripTextBox)sender).AccessibleDescription);
                    break;
            }
        }

        /// <summary>
        /// Clear the information text of the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);
    }
}
