namespace CiscoOverwatch
{
    partial class OverwatchMain
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
            this.BtnSSHConnect = new System.Windows.Forms.Button();
            this.SSHHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SSHUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SSHPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SSHCommand = new System.Windows.Forms.TextBox();
            this.SSHOutput = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSSHConnect
            // 
            this.BtnSSHConnect.Location = new System.Drawing.Point(16, 226);
            this.BtnSSHConnect.Name = "BtnSSHConnect";
            this.BtnSSHConnect.Size = new System.Drawing.Size(126, 23);
            this.BtnSSHConnect.TabIndex = 0;
            this.BtnSSHConnect.Text = "Connect and Run";
            this.BtnSSHConnect.UseVisualStyleBackColor = true;
            this.BtnSSHConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // SSHHost
            // 
            this.SSHHost.Location = new System.Drawing.Point(53, 9);
            this.SSHHost.Name = "SSHHost";
            this.SSHHost.Size = new System.Drawing.Size(148, 20);
            this.SSHHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // SSHUsername
            // 
            this.SSHUsername.Location = new System.Drawing.Point(53, 35);
            this.SSHUsername.Name = "SSHUsername";
            this.SSHUsername.Size = new System.Drawing.Size(148, 20);
            this.SSHUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pwd:";
            // 
            // SSHPwd
            // 
            this.SSHPwd.Location = new System.Drawing.Point(53, 61);
            this.SSHPwd.Name = "SSHPwd";
            this.SSHPwd.Size = new System.Drawing.Size(148, 20);
            this.SSHPwd.TabIndex = 5;
            this.SSHPwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CMD: ";
            // 
            // SSHCommand
            // 
            this.SSHCommand.Location = new System.Drawing.Point(53, 87);
            this.SSHCommand.Name = "SSHCommand";
            this.SSHCommand.Size = new System.Drawing.Size(147, 20);
            this.SSHCommand.TabIndex = 7;
            // 
            // SSHOutput
            // 
            this.SSHOutput.Location = new System.Drawing.Point(12, 117);
            this.SSHOutput.Multiline = true;
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.Size = new System.Drawing.Size(413, 103);
            this.SSHOutput.TabIndex = 9;
            this.SSHOutput.WordWrap = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(148, 226);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(53, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CiscoOverwatch.Properties.Resources._500px_Cisco_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(220, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // OverwatchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.SSHOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SSHCommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SSHPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SSHUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSHHost);
            this.Controls.Add(this.BtnSSHConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.TextBox SSHOutput;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

