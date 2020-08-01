using System;
using System.IO;
using System.Windows.Forms;

namespace DisksizeWatcher
{
  public partial class MainForm : Form
  {
    private DriveInfo driveC = new DriveInfo("C");

    public MainForm()
    {
      InitializeComponent();
    }

		private void MainForm_Load(object sender, EventArgs e)
		{
      if (driveC.IsReady)
      {
        textBoxDisksizeTotal.Text = driveC.TotalSize.ToString();
      }
      timer.Start();
    }

		private void Timer_Tick(object sender, EventArgs e)
		{
      if (driveC.IsReady)
      {
        double freeSpacePerc = driveC.AvailableFreeSpace / (float)driveC.TotalSize * 100;
        double SpacePerc = 100 - freeSpacePerc;
        progressBarPercentage.Value = (int)(SpacePerc);
        labelSpacePercentageValue.Text = SpacePerc.ToString("G6") + " %";
        textBoxDisksizeCurrent.Text = driveC.TotalFreeSpace.ToString();
      }
    }
	}
}
