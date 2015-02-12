using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoOverwatch
{
    public partial class OverwatchEditVLAN : Form
    {
        public OverwatchEditVLAN()
        {
            InitializeComponent();
        }

        public string SwitchName, SwitchIP, SwitchVLANid;

        private void asdf(string eSwitchName, string eSwitchIP, int eSwitchOldVlanID, int eSwitchNewVlanID)
        {
            Debug.ConOut("[curVlan: "  + eSwitchOldVlanID + "] [newVlan: " +eSwitchNewVlanID + "]", false, true, eSwitchName, eSwitchIP);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            Debug.ConOut("OK", false, true, "SW1");
            Debug.Restart();
            asdf("router 2", "10.10.0.2", 16, 32);
        }

        private void BtnApplyNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverwatchManualSSH ManualSSH = new OverwatchManualSSH();
            ManualSSH.Show();
        }





    }
}
