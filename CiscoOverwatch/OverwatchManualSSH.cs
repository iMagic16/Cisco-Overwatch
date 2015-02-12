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
    public partial class OverwatchManualSSH : Form
    {

        public OverwatchManualSSH()
        {
            InitializeComponent();
        }

        //Init my.settings saving
        Properties.Settings Setting = new Properties.Settings();


        private void SaveSettings()
        {
            //Save Settings
            Setting.SSHHost = SSHHost.Text;
            Setting.SSHUsername = SSHUsername.Text;
            Setting.SSHPassword = SSHPwd.Text;
            Setting.SSHPort = Convert.ToInt32(SSHPort.Text);
            Setting.SSHLastCMD = SSHCommand.Text;
            Setting.Save();
            //Call subroutine to add datetime to then output message to console
            Debug.ConOut("Settings Saved");
        }

        private void LoadSettings()
        {
            //Load Settings
            SSHHost.Text = Setting.SSHHost;
            SSHUsername.Text = Setting.SSHUsername;
            SSHPwd.Text = Setting.SSHPassword;
            SSHPort.Text = Convert.ToString(Setting.SSHPort);
            SSHCommand.Text = Setting.SSHLastCMD;
            //Call subroutine to add datetime to then output message to console
            Debug.ConOut("Settings loaded on OverwatchManualSSH");
        }

        bool AlreadyConnected;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Checks if already connected to prevent trying to connect while connecting and crashing the connect by trying to connect while it's connecting 
            AlreadyConnected = false;

            //Show the other form 
            OverwatchMainForm MainFrm = new OverwatchMainForm();
            //   MainFrm.Show();

            LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Values needed to connect ssh
            string strHost, strUsername, strPasswd, strOutput, strCmd;
            int intPort;

            strHost = SSHHost.Text;
            strUsername = SSHUsername.Text;
            strPasswd = SSHPwd.Text;
            strCmd = SSHCommand.Text;
            intPort = Convert.ToInt32(SSHPort.Text);

            //
            SshExec exec = new SshExec(strHost, strUsername, strPasswd);

            if (AlreadyConnected)
            {
                try
                {
                    strOutput = exec.RunCommand(strCmd);
                    SSHOutput.Text = SSHOutput.Text + strOutput;
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                }
            }
            else
            {
                try
                {
                    //Connect on port intPort
                    exec.Connect(intPort);
                    //Output the ssh output to strOutput
                    strOutput = exec.RunCommand(strCmd);
                    //Go line by line and add into the array lines while removing empty entries 
                    string[] lines = strOutput.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                    SSHOutput.Text = "";

                    //loop through each string in lines 
                    foreach (string s in lines)
                    {
                        SSHOutput.Text += s + Environment.NewLine;
                    }

                    //This checks for a mac address within the IFCONFIG command and outputs it to console 
                    for (int i = 0; i < lines.Length - 1; i++)
                    {

                        if (lines[i].Length >= 6 && lines[i].Substring(0, 6) == "HWaddr")
                        {
                            string macAddr = "";
                            macAddr = lines[i].Substring(7, 17);
                            Debug.ConOut("Mac Address of " + SSHHost.Text + ": " + macAddr);
                        }
                    }
                    //This closes the command from the runtime (DotNetSSH)
                    exec.Close();
                }

                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                }


            }
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}
