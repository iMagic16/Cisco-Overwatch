namespace CiscoOverwatch
{
    partial class OverwatchManualSSH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverwatchManualSSH));
            this.BtnSSHConnect = new System.Windows.Forms.Button();
            this.SSHHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SSHUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SSHPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SSHCommand = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SSHOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SSHPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSSHConnect
            // 
            this.BtnSSHConnect.Location = new System.Drawing.Point(13, 253);
            this.BtnSSHConnect.Name = "BtnSSHConnect";
            this.BtnSSHConnect.Size = new System.Drawing.Size(126, 23);
            this.BtnSSHConnect.TabIndex = 7;
            this.BtnSSHConnect.Text = "Connect and Run";
            this.BtnSSHConnect.UseVisualStyleBackColor = true;
            this.BtnSSHConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // SSHHost
            // 
            this.SSHHost.Location = new System.Drawing.Point(48, 9);
            this.SSHHost.Name = "SSHHost";
            this.SSHHost.Size = new System.Drawing.Size(150, 20);
            this.SSHHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // SSHUsername
            // 
            this.SSHUsername.Location = new System.Drawing.Point(48, 35);
            this.SSHUsername.Name = "SSHUsername";
            this.SSHUsername.Size = new System.Drawing.Size(150, 20);
            this.SSHUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pwd:";
            // 
            // SSHPwd
            // 
            this.SSHPwd.Location = new System.Drawing.Point(48, 61);
            this.SSHPwd.Name = "SSHPwd";
            this.SSHPwd.Size = new System.Drawing.Size(150, 20);
            this.SSHPwd.TabIndex = 3;
            this.SSHPwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CMD: ";
            // 
            // SSHCommand
            // 
            this.SSHCommand.Location = new System.Drawing.Point(48, 113);
            this.SSHCommand.Name = "SSHCommand";
            this.SSHCommand.Size = new System.Drawing.Size(150, 20);
            this.SSHCommand.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(145, 253);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(53, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CiscoOverwatch.Properties.Resources.ciscologo;
            this.pictureBox1.Location = new System.Drawing.Point(220, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SSHOutput
            // 
            this.SSHOutput.BackColor = System.Drawing.Color.Black;
            this.SSHOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSHOutput.ForeColor = System.Drawing.Color.White;
            this.SSHOutput.Location = new System.Drawing.Point(12, 146);
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.ReadOnly = true;
            this.SSHOutput.Size = new System.Drawing.Size(410, 96);
            this.SSHOutput.TabIndex = 6;
            this.SSHOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Port:";
            // 
            // SSHPort
            // 
            this.SSHPort.Location = new System.Drawing.Point(48, 87);
            this.SSHPort.Name = "SSHPort";
            this.SSHPort.Size = new System.Drawing.Size(150, 20);
            this.SSHPort.TabIndex = 4;
            // 
            // OverwatchMain
            // 
            this.AcceptButton = this.BtnSSHConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 283);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SSHPort);
            this.Controls.Add(this.SSHOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SSHCommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SSHPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SSHUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSHHost);
            this.Controls.Add(this.BtnSSHConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OverwatchMain";
            this.Text = "Cisco Overwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSSHConnect;
        private System.Windows.Forms.TextBox SSHHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SSHUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SSHPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SSHCommand;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox SSHOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SSHPort;
    }
}

