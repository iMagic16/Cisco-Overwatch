using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSM.DotNetSSH;
using Org.Mentalis.Security;
using System.Text.RegularExpressions;


namespace CiscoOverwatch
{
    public partial class OverwatchEditVLANs : Form
    {
        public OverwatchEditVLANs()
        {
            InitializeComponent();
        }

        private void OverwatchEditVLANs_Load(object sender, EventArgs e)
        {


            Debug.ConOut("OverWatch Edit VLANs loaded");
        }
    }
}
