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
//using DiffieHelman;
using Org.Mentalis.Security;
namespace CiscoOverwatch
{
    public partial class OverwatchMain : Form
    {


        bool AlreadyConnected;
        public OverwatchMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings Setting = new Properties.Settings();
            SSHHost.Text = Setting.SSHHost;
            SSHUsername.Text = Setting.SSHUsername;
            SSHPwd.Text = Setting.SSHPassword;
     //       MessageBox.Show("Settings Loaded!");
            
            AlreadyConnected = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strHost, strUsername, strPasswd, strOutput, strCmd;
         //   strHost = "192.168.204.132";
           // strUsername = "james";
           // strPasswd = "5683";
            strHost = SSHHost.Text;
            strUsername = SSHUsername.Text;
            strPasswd = SSHPwd.Text;
            strCmd = SSHCommand.Text;

            SshExec exec = new SshExec(strHost, strUsername, strPasswd);

            if (AlreadyConnected) {
                try
                {
                    strOutput = exec.RunCommand(strCmd);
                    SSHOutput.Text = SSHOutput.Text + strOutput;
                }
                catch (Exception)
                {
                    //   label1.Text = System.Convert.ToString(Exception);
                    throw;
                }
            }
            else
            {
                try
                {
                    exec.Connect();
                    strOutput = exec.RunCommand(strCmd);
                    SSHOutput.Text = strOutput;
                    exec.Close();
                }
                catch (Exception)
                {
                    //   label1.Text = System.Convert.ToString(Exception);
                    throw;
                }
            }
            
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings Setting = new Properties.Settings();
            Setting.SSHHost = SSHHost.Text;
            Setting.SSHUsername = SSHUsername.Text;
            Setting.SSHPassword = SSHPwd.Text;
            Setting.Save();
      //      MessageBox.Show("Saved");
        }
    }
}
