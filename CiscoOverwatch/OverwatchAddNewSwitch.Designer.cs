namespace CiscoOverwatch
{
    partial class OverwatchAddNewSwitch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverwatchAddNewSwitch));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSwitchName = new System.Windows.Forms.TextBox();
            this.TxtSwitchIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSwitchRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSwitchRack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSwitchSelector = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Switch Name:";
            // 
            // TxtSwitchName
            // 
            this.TxtSwitchName.Enabled = false;
            this.TxtSwitchName.Location = new System.Drawing.Point(92, 62);
            this.TxtSwitchName.Name = "TxtSwitchName";
            this.TxtSwitchName.Size = new System.Drawing.Size(416, 20);
            this.TxtSwitchName.TabIndex = 1;
            // 
            // TxtSwitchIP
            // 
            this.TxtSwitchIP.Enabled = false;
            this.TxtSwitchIP.Location = new System.Drawing.Point(92, 88);
            this.TxtSwitchIP.Name = "TxtSwitchIP";
            this.TxtSwitchIP.Size = new System.Drawing.Size(416, 20);
            this.TxtSwitchIP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Switch IP:";
            // 
            // TxtSwitchRoom
            // 
            this.TxtSwitchRoom.Enabled = false;
            this.TxtSwitchRoom.Location = new System.Drawing.Point(92, 114);
            this.TxtSwitchRoom.Name = "TxtSwitchRoom";
            this.TxtSwitchRoom.Size = new System.Drawing.Size(416, 20);
            this.TxtSwitchRoom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Switch Room:";
            // 
            // TxtSwitchRack
            // 
            this.TxtSwitchRack.Enabled = false;
            this.TxtSwitchRack.Location = new System.Drawing.Point(92, 140);
            this.TxtSwitchRack.Name = "TxtSwitchRack";
            this.TxtSwitchRack.Size = new System.Drawing.Size(416, 20);
            this.TxtSwitchRack.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Switch Rack:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CiscoOverwatch.Properties.Resources.ciscologo;
            this.pictureBox1.Location = new System.Drawing.Point(514, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(514, 119);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(124, 44);
            this.BtnSave.TabIndex = 41;
            this.BtnSave.Text = "Add to Configuration";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(644, 119);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(74, 44);
            this.BtnExit.TabIndex = 42;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Select the switch to edit";
            // 
            // lstSwitchSelector
            // 
            this.lstSwitchSelector.FormattingEnabled = true;
            this.lstSwitchSelector.Items.AddRange(new object[] {
            "1   | NAME | IP | ROOM | RACK",
            "2   | NAME | IP | ROOM | RACK",
            "3   | NAME | IP | ROOM | RACK",
            "4   | NAME | IP | ROOM | RACK",
            "5   | NAME | IP | ROOM | RACK"});
            this.lstSwitchSelector.Location = new System.Drawing.Point(16, 23);
            this.lstSwitchSelector.Name = "lstSwitchSelector";
            this.lstSwitchSelector.Size = new System.Drawing.Size(492, 30);
            this.lstSwitchSelector.TabIndex = 44;
            this.lstSwitchSelector.SelectedIndexChanged += new System.EventHandler(this.lstSwitchSelector_SelectedIndexChanged);
            // 
            // AddNewSwitch
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(730, 173);
            this.Controls.Add(this.lstSwitchSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSwitchRack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSwitchRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSwitchIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSwitchName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewSwitch";
            this.Text = "Add a new switch...";
            this.Load += new System.EventHandler(this.AddNewSwitch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSwitchName;
        private System.Windows.Forms.TextBox TxtSwitchIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSwitchRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSwitchRack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSwitchSelector;
    }
}