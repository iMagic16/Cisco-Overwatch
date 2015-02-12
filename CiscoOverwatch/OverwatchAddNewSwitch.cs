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
    public partial class OverwatchAddNewSwitch : Form
    {
        public OverwatchAddNewSwitch()
        {
            InitializeComponent();
        }

        //Init my.settings saving
        Properties.Settings Setting = new Properties.Settings();
        int SwitchID;

        //Make sure there is text in the box before saving it
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtSwitchName.Text.Length > 1 & TxtSwitchIP.Text.Length > 1 & TxtSwitchRack.Text.Length >1 & TxtSwitchRoom.Text.Length > 1)
            {
                if (TxtSwitchIP.Text.Contains(".") | TxtSwitchIP.Text.Contains("192.") | TxtSwitchIP.Text.Contains("10."))
                {
                AddSwAndSave(SwitchID);

                OverwatchMainForm OvrWthMn = new OverwatchMainForm();
                OvrWthMn.Show();
                this.Close();
                }
                else
                {
                    MessageBox.Show("Please use the correct ip format (*.*.*.*) and make sure your IP is valid (10.x.x.x or 192.x.x.x)");
                };
            }
            else
            {
                Debug.ConOut("Textbox [txtSwitchName] empty");
                MessageBox.Show("Textboxes cannot be empty!");
            }

        }

        //Loads existing switch data into the dropdown box
        private void LoadSettingsToDropDown()
        {
            lstSwitchSelector.Items[0] = "1 | " + Setting.Switch1Name + " | " + Setting.Switch1IP + " | " + Setting.Switch1Room + " | " + Setting.Switch1Rack;
            lstSwitchSelector.Items[1] = "2 | " + Setting.Switch2Name + " | " + Setting.Switch2IP + " | " + Setting.Switch2Room + " | " + Setting.Switch2Rack;
            lstSwitchSelector.Items[2] = "3 | " + Setting.Switch3Name + " | " + Setting.Switch3IP + " | " + Setting.Switch3Room + " | " + Setting.Switch3Rack;
            lstSwitchSelector.Items[3] = "4 | " + Setting.Switch4Name + " | " + Setting.Switch4IP + " | " + Setting.Switch4Room + " | " + Setting.Switch4Rack;
            lstSwitchSelector.Items[4] = "5 | " + Setting.Switch5Name + " | " + Setting.Switch5IP + " | " + Setting.Switch5Room + " | " + Setting.Switch5Rack;
        }

        //Add switch data to the selected switch slot, and saves it
        private void AddSwAndSave(int SwitchToAdd)
        {
            Debug.ConOut("Switch added");
            Debug.ConOut("ID: " + SwitchToAdd);
            Debug.ConOut("NAME: " + TxtSwitchName.Text);
            Debug.ConOut("IP: " + TxtSwitchIP.Text);
            Debug.ConOut("ROOM: " + TxtSwitchRoom.Text);
            Debug.ConOut("RACK: " + TxtSwitchRack.Text);

            Debug.ConOut("Saving to My.Settings...");


            if (SwitchToAdd == 1)
            {
                Debug.ConOut(SwitchToAdd.ToString());
                //Start to save the stuffs
                try
                {
                    Setting.Switch1Exists = true;
                    Setting.Switch1Name = TxtSwitchName.Text;
                    Setting.Switch1IP = TxtSwitchIP.Text;
                    Setting.Switch1Room = TxtSwitchRoom.Text;
                    Setting.Switch1Rack = TxtSwitchRack.Text;
                    Setting.Save();
                    Debug.ConOut("Save Successful...");
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                    Debug.ConOut("SAVE FAILED");
                }

            }
            else if (SwitchToAdd == 2)
            {
                Debug.ConOut(SwitchToAdd.ToString());
                //
                try
                {
                    Setting.Switch2Exists = true;
                    Setting.Switch2Name = TxtSwitchName.Text;
                    Setting.Switch2IP = TxtSwitchIP.Text;
                    Setting.Switch2Room = TxtSwitchRoom.Text;
                    Setting.Switch2Rack = TxtSwitchRack.Text;
                    Setting.Save();
                    Debug.ConOut("Save Successful...");
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                    Debug.ConOut("SAVE FAILED");
                }
            }
            else if (SwitchToAdd == 3)
            {
                Debug.ConOut(SwitchToAdd.ToString());
                try
                {
                    Setting.Switch3Exists = true;
                    Setting.Switch3Name = TxtSwitchName.Text;
                    Setting.Switch3IP = TxtSwitchIP.Text;
                    Setting.Switch3Room = TxtSwitchRoom.Text;
                    Setting.Switch3Rack = TxtSwitchRack.Text;
                    Setting.Save();
                    Debug.ConOut("Save Successful...");
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                    Debug.ConOut("SAVE FAILED");
                }
            }
            else if (SwitchToAdd == 4)
            {
                Debug.ConOut(SwitchToAdd.ToString());

                try
                {
                    Setting.Switch4Exists = true;
                    Setting.Switch4Name = TxtSwitchName.Text;
                    Setting.Switch4IP = TxtSwitchIP.Text;
                    Setting.Switch4Room = TxtSwitchRoom.Text;
                    Setting.Switch4Rack = TxtSwitchRack.Text;
                    Setting.Save();
                    Debug.ConOut("Save Successful...");
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                    Debug.ConOut("SAVE FAILED");
                }
            }
            else if (SwitchToAdd == 5)
            {
                Debug.ConOut(SwitchToAdd.ToString());

                try
                {
                    Setting.Switch5Exists = true;
                    Setting.Switch5Name = TxtSwitchName.Text;
                    Setting.Switch5IP = TxtSwitchIP.Text;
                    Setting.Switch5Room = TxtSwitchRoom.Text;
                    Setting.Switch5Rack = TxtSwitchRack.Text;
                    Setting.Save();
                    Debug.ConOut("Save Successful...");
                }
                catch (Exception ex)
                {
                    Debug.ConOut(ex.Message);
                    Debug.ConOut("SAVE FAILED");
                }
            }


        }

        //Exit back to the main form
        private void BtnExit_Click(object sender, EventArgs e)
        {
            OverwatchMainForm OvrWthMn = new OverwatchMainForm();
            OvrWthMn.Show();
            this.Close();
        }

        //On Form load, load the settings
        private void AddNewSwitch_Load(object sender, EventArgs e)
        {
            LoadSettingsToDropDown();
        }

        //When a different dropdown index is selected, change the ticker to that. This enables us to save to the selected index. 
        private void lstSwitchSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Only enable changing of text boxes once they select an index
            TxtSwitchIP.Enabled = true;
            TxtSwitchName.Enabled = true;
            TxtSwitchRoom.Enabled = true;
            TxtSwitchRack.Enabled = true;
            BtnSave.Enabled = true;

            //We add +1 here because the selectedIndex starts at 0, and our switches data start at 1.
            SwitchID = lstSwitchSelector.SelectedIndex + 1;
            Debug.ConOut("Switch ID #" + SwitchID.ToString() + " selected.");
        }


    }
}
