using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //double freeSpacePerc = (;
        progressBarPercentage.Value = (int)(100 - (driveC.AvailableFreeSpace / (float)driveC.TotalSize * 100));
        textBoxDisksizeCurrent.Text = driveC.TotalFreeSpace.ToString();
      }
    }
	}
}
