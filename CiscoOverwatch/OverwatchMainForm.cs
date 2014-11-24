using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.NetworkInformation;

namespace CiscoOverwatch
{
    public partial class OverwatchMainForm : Form
    {
        public OverwatchMainForm()
        {
            InitializeComponent();
        }

        private void OverwatchMainForm_Load(object sender, EventArgs e)
        {
            Debug.ConOut("Form Loaded");
            LoadSettings();

            OverwatchAbout Open = new OverwatchAbout();
            Open.Show();
        }


        //Init My.Setting saving
        Properties.Settings Setting = new Properties.Settings();



        private void SaveSettings()
        {
            try
            {
                //Save Settings
                Setting.Save();

                //Call subroutine to add date-time to then output message to console
                Debug.ConOut("Settings Saved");
            }
            catch (Exception ex)
            {
                Debug.ConOut("Unable to save settings...");
                Debug.ConOut(ex.Message);
            }
        }

        private void LoadSettings()
        {
            try
            {
                //Load Settings for switches 1-5, need to see if this is actually possible
                //   for (int i = 0; i < 4; i++)
                //       {
                // Switch[i]Name.Text = Setting.Switch[i]Name;
                //      }

                //1 by 1
                if (Setting.Switch1Exists)
                {
                    //SWITCH1
                    Switch1Name.Text = Setting.Switch1Name;
                    Switch1IP.Text = Setting.Switch1IP;
                    Switch1VLANID.Text = Convert.ToString(Setting.Switch1VLANID);
                    Switch1Room.Text = Setting.Switch1Room;
                    Switch1Rack.Text = Setting.Switch1Rack;

                    Debug.ConOut("Loading switch 1...");
                }
                if (Setting.Switch2Exists)
                {
                    //SWITCH2
                    Switch2Name.Text = Setting.Switch2Name;
                    Switch2IP.Text = Setting.Switch2IP;
                    Switch2VLANID.Text = Convert.ToString(Setting.Switch2VLANID);
                    Switch2Room.Text = Setting.Switch2Room;
                    Switch2Rack.Text = Setting.Switch2Rack;

                    Debug.ConOut("Loading switch 2...");
                }
                if (Setting.Switch3Exists)
                {
                    //SWITCH3
                    Switch3Name.Text = Setting.Switch3Name;
                    Switch3IP.Text = Setting.Switch3IP;
                    Switch3VLANID.Text = Convert.ToString(Setting.Switch3VLANID);
                    Switch3Room.Text = Setting.Switch3Room;
                    Switch3Rack.Text = Setting.Switch3Rack;

                    Debug.ConOut("Loading switch 3...");
                }
                if (Setting.Switch4Exists)
                {
                    //SWITCH4
                    Switch4Name.Text = Setting.Switch4Name;
                    Switch4IP.Text = Setting.Switch4IP;
                    Switch4VLANID.Text = Convert.ToString(Setting.Switch4VLANID);
                    Switch4Room.Text = Setting.Switch4Room;
                    Switch4Rack.Text = Setting.Switch4Rack;

                    Debug.ConOut("Loading switch 4...");
                }
                if (Setting.Switch5Exists)
                {
                    //SWITCH5
                    Switch5Name.Text = Setting.Switch5Name;
                    Switch5IP.Text = Setting.Switch5IP;
                    Switch5VLANID.Text = Convert.ToString(Setting.Switch5VLANID);
                    Switch5Room.Text = Setting.Switch5Room;
                    Switch5Rack.Text = Setting.Switch5Rack;

                    Debug.ConOut("Loading switch 5...");
                }
                Setting.Reload();
                //Call subroutine to add date-time to then output message to console
                Debug.ConOut("Settings loaded on OverwatchMainForm");
            }
            catch (Exception ex)
            {
                Debug.ConOut("Unable to load settings...");
                Debug.ConOut(ex.Message);
            }
        }

        //unfinished subroutine to check switches status
        public void RefreshSwitchStatus(bool AutoRefresh = false, int SwitchToRefresh = 1)
        {
            //      if (AutoRefresh)
            //      {
            //           Debug.ConOut("Refreshing from timer... Delay of " + TxtRefreshDelay.Text);

            //        }
            // else if (Refresh)
            //    {
            #region MightBeUsefulLater
            //  Refresh = false;
            /*
                       bool Switch1Added, Switch2Added, Switch3Added, Switch4Added, Switch5Added;

                       string[] Switch;
                       Switch = new string[10];

                       Switch1Added = false;
                       Switch2Added = false;
                       Switch3Added = false;
                       Switch4Added = false;
                       Switch5Added = false; 




                       for (int i = 0; i < 9; i += 2)
                       {
                           if (Switch1Added == false)
                           {
                               Switch[i] = Setting.Switch1Name;
                               Switch[i + 1] = Setting.Switch1IP;
                               Switch1Added = true;
                           }
                           else if (Switch2Added == false)
                           {
                               Switch[i] = Setting.Switch2Name;
                               Switch[i + 1] = Setting.Switch2IP;
                               Switch2Added = true;
                           }
                           else if (Switch3Added == false)
                           {
                               Switch[i] = Setting.Switch3Name;
                               Switch[i + 1] = Setting.Switch3IP;
                               Switch3Added = true;
                           }
                           else if (Switch4Added == false)
                           {
                               Switch[i] = Setting.Switch4Name;
                               Switch[i + 1] = Setting.Switch4IP;
                               Switch4Added = true;
                           }
                           else if (Switch5Added == false)
                           {
                               Switch[i] = Setting.Switch5Name;
                               Switch[i + 1] = Setting.Switch5IP;
                               Switch5Added = true;
                           }

                       }
                       */

            #endregion
            try
            {
                if (SwitchToRefresh == 1)
                {
                    Switch1Pinging.Visible = true;
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(Setting.Switch1IP, 1000);
                    Switch1Pinging.Visible = false;

                    if (reply.Status == IPStatus.Success)
                    {
                        Debug.ConOut("Address: " + reply.Address.ToString());
                        Debug.ConOut("RoundTrip time: " + reply.RoundtripTime + "ms");
                        PingManager(Convert.ToInt32(reply.RoundtripTime), SwitchToRefresh);
                    }
                    else
                    {
                        Switch1PingTime.Text = "Offline";
                        Debug.ConOut(reply.Status.ToString());
                    }
                }
                else if (SwitchToRefresh == 2)
                {
                    Switch2Pinging.Visible = true;
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(Setting.Switch2IP, 1000);
                    Switch2Pinging.Visible = false;

                    if (reply.Status == IPStatus.Success)
                    {
                        Debug.ConOut("Address: " + reply.Address.ToString());
                        Debug.ConOut("RoundTrip time: " + reply.RoundtripTime + "ms");
                        PingManager(Convert.ToInt32(reply.RoundtripTime), SwitchToRefresh);
                    }
                    else
                    {
                        Switch2PingTime.Text = "Offline";
                        Debug.ConOut(reply.Status.ToString());
                    }
                }
                else if (SwitchToRefresh == 3)
                {
                    Switch3Pinging.Visible = true;
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(Setting.Switch3IP, 1000);
                    Switch3Pinging.Visible = false;

                    if (reply.Status == IPStatus.Success)
                    {
                        Debug.ConOut("Address: " + reply.Address.ToString());
                        Debug.ConOut("RoundTrip time: " + reply.RoundtripTime + "ms");
                        PingManager(Convert.ToInt32(reply.RoundtripTime), SwitchToRefresh);
                    }
                    else
                    {
                        Switch3PingTime.Text = "Offline";
                        Debug.ConOut(reply.Status.ToString());
                    }
                }
                else if (SwitchToRefresh == 4)
                {
                    Switch4Pinging.Visible = true;
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(Setting.Switch4IP, 1000);
                    Switch4Pinging.Visible = false;

                    if (reply.Status == IPStatus.Success)
                    {
                        Debug.ConOut("Address: " + reply.Address.ToString());
                        Debug.ConOut("RoundTrip time: " + reply.RoundtripTime + "ms");
                        PingManager(Convert.ToInt32(reply.RoundtripTime), SwitchToRefresh);
                    }
                    else
                    {
                        Switch4PingTime.Text = "Offline";
                        Debug.ConOut(reply.Status.ToString());
                    }
                }
                else if (SwitchToRefresh == 5)
                {
                    Switch5Pinging.Visible = true;
                    Ping pingSender = new Ping();
                    PingReply reply = pingSender.Send(Setting.Switch5IP, 1000);
                    Switch5Pinging.Visible = false;
                    if (reply.Status == IPStatus.Success)
                    {
                        Debug.ConOut("Address: " + reply.Address.ToString());
                        Debug.ConOut("RoundTrip time: " + reply.RoundtripTime + "ms");
                        PingManager(Convert.ToInt32(reply.RoundtripTime), SwitchToRefresh);
                    }
                    else
                    {
                        Switch5PingTime.Text = "Offline";
                        Debug.ConOut(reply.Status.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.ConOut(ex.Message);
            }
        }


        public void PingManager(int Ping, int SwitchPingLblToChange = 1)
        {
            try
            {
                if (SwitchPingLblToChange == 1)
                {
                    Switch1PingTime.Text = Ping.ToString() + "ms";
                    Debug.ConOut("Pinging Switch 1");
                    if (Ping > -1 && Ping < 99)
                    {
                        Switch1PingTime.ForeColor = Color.Green;
                        Debug.ConOut("Connection Quality: Excellent");
                    }
                    else if (Ping > 100 && Ping < 199)
                    {
                        Switch1PingTime.ForeColor = Color.Orange;
                        Debug.ConOut("Connection Quality: OK");
                    }
                    else if (Ping > 200 && Ping < 10000)
                    {
                        Switch1PingTime.ForeColor = Color.Red;
                        Debug.ConOut("Connection Quality: Poor");
                    }
                    else
                    {
                        Debug.ConOut("Connection Quality: Abysmal");
                    }
                }
                else if (SwitchPingLblToChange == 2)
                {
                    Switch2PingTime.Text = Ping.ToString() + "ms";
                    Debug.ConOut("Pinging Switch 2");
                    if (Ping > -1 && Ping < 99)
                    {
                        Switch2PingTime.ForeColor = Color.Green;
                        Debug.ConOut("Connection Quality: Excellent");
                    }
                    else if (Ping > 100 && Ping < 199)
                    {
                        Switch2PingTime.ForeColor = Color.Orange;
                        Debug.ConOut("Connection Quality: OK");
                    }
                    else if (Ping > 200 && Ping < 10000)
                    {
                        Switch2PingTime.ForeColor = Color.Red;
                    }
                    else
                    {
                        Debug.ConOut("Connection Quality: Abysmal");
                    }
                }
                else if (SwitchPingLblToChange == 3)
                {
                    Switch3PingTime.Text = Ping.ToString() + "ms";
                    Debug.ConOut("Pinging Switch 3");
                    if (Ping > -1 && Ping < 99)
                    {
                        Switch3PingTime.ForeColor = Color.Green;
                        Debug.ConOut("Connection Quality: Excellent");
                    }
                    else if (Ping > 100 && Ping < 199)
                    {
                        Switch3PingTime.ForeColor = Color.Orange;
                        Debug.ConOut("Connection Quality: OK");
                    }
                    else if (Ping > 200 && Ping < 10000)
                    {
                        Switch3PingTime.ForeColor = Color.Red;
                        Debug.ConOut("Connection Quality: Poor");
                    }
                    else
                    {
                        Debug.ConOut("Connection Quality: Abysmal");
                    }
                }
                else if (SwitchPingLblToChange == 4)
                {
                    Switch4PingTime.Text = Ping.ToString() + "ms";
                    Debug.ConOut("Pinging Switch 4");
                    if (Ping > -1 && Ping < 99)
                    {
                        Switch4PingTime.ForeColor = Color.Green;
                        Debug.ConOut("Connection Quality: Excellent");
                    }
                    else if (Ping > 100 && Ping < 199)
                    {
                        Switch4PingTime.ForeColor = Color.Orange;
                        Debug.ConOut("Connection Quality: OK");
                    }
                    else if (Ping > 200 && Ping < 10000)
                    {
                        Switch4PingTime.ForeColor = Color.Red;
                        Debug.ConOut("Connection Quality: Poor");
                    }
                    else
                    {
                        Debug.ConOut("Connection Quality: Abysmal");
                    }
                }
                else if (SwitchPingLblToChange == 5)
                {
                    Switch5PingTime.Text = Ping.ToString() + "ms";
                    Debug.ConOut("Pinging Switch 5");
                    if (Ping > -1 && Ping < 99)
                    {
                        Switch5PingTime.ForeColor = Color.Green;
                        Debug.ConOut("Connection Quality: Excellent");
                    }
                    else if (Ping > 100 && Ping < 199)
                    {
                        Switch5PingTime.ForeColor = Color.Orange;
                        Debug.ConOut("Connection Quality: OK");
                    }
                    else if (Ping > 200 && Ping < 10000)
                    {
                        Switch5PingTime.ForeColor = Color.Red;
                        Debug.ConOut("Connection Quality: Poor");
                    }
                    else
                    {
                        Debug.ConOut("Connection Quality: Abysmal");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.ConOut(ex.Message);
            }


            //




        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void BtnAddSw_Click(object sender, EventArgs e)
        {
            AddNewSwitch AddSW = new AddNewSwitch();
            AddSW.Show();
            this.Hide();
        }

        private void BtnEditSw_Click(object sender, EventArgs e)
        {
            OverwatchMain Main = new OverwatchMain();
            Main.Show();
        }

        private void BtnLoadConfig_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkRefresh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ChkRefresh.Checked)
                {
                    Debug.ConOut("Auto-refresh checked");
                    PingTimer.Interval = Convert.ToInt32(TxtRefreshDelay.Text) * 1000;
                    Debug.ConOut("Timer interval set as: " + Convert.ToInt32(TxtRefreshDelay.Text) * 1000);
                    PingTimer.Enabled = true;
                    TxtRefreshDelay.Enabled = false;
                    BtnRefresh.Enabled = false;
                }
                else
                {
                    Debug.ConOut("Auto-refresh unchecked");
                    PingTimer.Enabled = false;
                    TxtRefreshDelay.Enabled = true;
                    BtnRefresh.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Debug.ConOut(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 1);
            RefreshSwitchStatus(false, 2);
            RefreshSwitchStatus(false, 3);
            RefreshSwitchStatus(false, 4);
            RefreshSwitchStatus(false, 5);
        }

        private void Switch1Pinging_Click(object sender, EventArgs e)
        {

        }

        private void Switch1IP_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 1);
        }

        private void Switch2IP_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 2);
        }

        private void Switch3IP_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 3);
        }

        private void Switch4IP_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 4);
        }

        private void Switch5IP_Click(object sender, EventArgs e)
        {
            RefreshSwitchStatus(false, 5);
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {

            Debug.ConOut("TIMER TICKING");
            RefreshSwitchStatus(true, 1);
            RefreshSwitchStatus(true, 2);
            RefreshSwitchStatus(true, 3);
            RefreshSwitchStatus(true, 4);
            RefreshSwitchStatus(true, 5);


        }

    }
}
