namespace CiscoOverwatch
{
    partial class OverwatchEditVLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverwatchEditVLAN));
            this.BtnApplyNExit = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VLANSelector = new System.Windows.Forms.NumericUpDown();
            this.LstInterfaces = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VLANSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnApplyNExit
            // 
            this.BtnApplyNExit.Location = new System.Drawing.Point(345, 245);
            this.BtnApplyNExit.Name = "BtnApplyNExit";
            this.BtnApplyNExit.Size = new System.Drawing.Size(266, 72);
            this.BtnApplyNExit.TabIndex = 0;
            this.BtnApplyNExit.Text = "PERMANENTLY APPLY AND EXIT\r\n\r\n\r\nThis will save and overwrite the previous config!" +
    "";
            this.BtnApplyNExit.UseVisualStyleBackColor = true;
            this.BtnApplyNExit.Click += new System.EventHandler(this.BtnApplyNExit_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(12, 245);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(327, 72);
            this.BtnApply.TabIndex = 1;
            this.BtnApply.Text = "TEST APPLY TO RUNNING-CONFIG\r\n\r\nOnly affects this iteration of the switch\r\nOnce r" +
    "eboot it will be reset back to what it was";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an interface to change the VLAN on: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter what you want to change the VLAN to:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(345, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tips";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manual SSH\r\nRecommended for Advanced Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "? : If a VLAN does not exist it will be created\r\n\r\n? : Refer to the console to se" +
    "e what\'s going on\r\n\r\n? : if you wish, you can manually ssh below\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VLANSelector);
            this.groupBox2.Controls.Add(this.LstInterfaces);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VLAN Control";
            // 
            // VLANSelector
            // 
            this.VLANSelector.Hexadecimal = true;
            this.VLANSelector.Location = new System.Drawing.Point(9, 117);
            this.VLANSelector.Name = "VLANSelector";
            this.VLANSelector.Size = new System.Drawing.Size(220, 20);
            this.VLANSelector.TabIndex = 5;
            this.VLANSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LstInterfaces
            // 
            this.LstInterfaces.FormattingEnabled = true;
            this.LstInterfaces.Items.AddRange(new object[] {
            "null"});
            this.LstInterfaces.Location = new System.Drawing.Point(9, 53);
            this.LstInterfaces.Name = "LstInterfaces";
            this.LstInterfaces.Size = new System.Drawing.Size(220, 43);
            this.LstInterfaces.TabIndex = 4;
            // 
            // OverwatchEditVLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnApplyNExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OverwatchEditVLAN";
            this.Text = "Cisco Overwatch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VLANSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnApplyNExit;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LstInterfaces;
        private System.Windows.Forms.NumericUpDown VLANSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}