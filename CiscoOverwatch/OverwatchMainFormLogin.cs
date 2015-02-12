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
    public partial class OverwatchMainFormLogin : Form
    {
        public OverwatchMainFormLogin()
        {
            InitializeComponent();
        }

        //Init My.Setting saving
        Properties.Settings Setting = new Properties.Settings();

        private void Login(string Username, string Passwd)
        {
            if (Username == "admin")
            {
                Debug.ConOut("GB");
            }


        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            ChkAutoLogin.Enabled = ChkRememberMe.Checked;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login(TxtUsername.Text, TxtPassword.Text);
        }
    }
}
