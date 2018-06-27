//Matthew Wells
//CSConfig Changer 2.0
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace CSConfigChanger2._0
{
  public partial class Form1 : Form
  {
    //Location of CSGO cfg folder
    const string CSCFGFile = @"B:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\cfg\config.cfg";
    const string CSCrossFile1 = @"B:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\cfg\CSCrosshair1.cfg";
    const string CSCrossFile2 = @"B:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\cfg\CSCrosshair1.cfg";
    const string CSCrossFile3 = @"B:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\cfg\CSCrosshair1.cfg";

    //Location of external drive incase original cfg file is lost
    const string ExternalCFGFile = @"F:\Not School Stuff\CS Stuff\config.cfg";
    const string ExternalCrossFile1 = @"F:\Not School Stuff\CS Stuff\CSCrosshair1.cfg";
    const string ExternalCrossFile2 = @"F:\Not School Stuff\CS Stuff\CSCrosshair2.cfg";
    const string ExternalCrossFile3 = @"F:\Not School Stuff\CS Stuff\CSCrosshair3.cfg";

    public Form1()
    {
      InitializeComponent();
    }

  
    private void SaveFiles(String cSFile, String externalFile)
    {
      this.Visible = false;
      var process = Process.Start("notepad.exe", cSFile);
      process.WaitForExit();
      File.Copy(cSFile, externalFile, true);
      this.Visible = true;
    }

    private void cfgButton_Click(object sender, EventArgs e)
    {
      SaveFiles(CSCFGFile, ExternalCFGFile);
    }

    private void crossHair1_Click(object sender, EventArgs e)
    {
      SaveFiles(CSCrossFile1, ExternalCrossFile1);
    }

    private void crossHair2_Click(object sender, EventArgs e)
    {
      SaveFiles(CSCrossFile2, ExternalCrossFile2);
    }

    private void crossHair3_Click(object sender, EventArgs e)
    {
      SaveFiles(CSCrossFile3, ExternalCrossFile3);
    }

    private void exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
