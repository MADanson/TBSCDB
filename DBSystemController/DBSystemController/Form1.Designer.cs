﻿namespace DBSystemController
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ActivityBar = new System.Windows.Forms.ProgressBar();
            this.StartStop = new System.Windows.Forms.Button();
            this.RamLabel = new System.Windows.Forms.Label();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.BackUpTime = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DebugConsole = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackupLocationBar = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SetBackupTimer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BackUpTime)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // buttonStart
            //
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(6, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(134, 31);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Server Inactive";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.UseMnemonic = false;
            this.buttonStart.UseVisualStyleBackColor = false;
            //
            // ActivityBar
            //
            this.ActivityBar.ForeColor = System.Drawing.Color.Red;
            this.ActivityBar.Location = new System.Drawing.Point(12, 12);
            this.ActivityBar.MarqueeAnimationSpeed = 10;
            this.ActivityBar.Name = "ActivityBar";
            this.ActivityBar.Size = new System.Drawing.Size(673, 31);
            this.ActivityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ActivityBar.TabIndex = 2;
            this.ActivityBar.Value = 100;
            //
            // StartStop
            //
            this.StartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.StartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartStop.FlatAppearance.BorderSize = 0;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.ForeColor = System.Drawing.Color.White;
            this.StartStop.Location = new System.Drawing.Point(685, 12);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(134, 31);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start Server";
            this.StartStop.UseMnemonic = false;
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            //
            // RamLabel
            //
            this.RamLabel.AutoSize = true;
            this.RamLabel.BackColor = System.Drawing.Color.White;
            this.RamLabel.Location = new System.Drawing.Point(239, 30);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(66, 13);
            this.RamLabel.TabIndex = 0;
            this.RamLabel.Text = "Ram Usage:";
            //
            // CPUUsage
            //
            this.CPUUsage.AutoSize = true;
            this.CPUUsage.BackColor = System.Drawing.Color.White;
            this.CPUUsage.Location = new System.Drawing.Point(152, 30);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(66, 13);
            this.CPUUsage.TabIndex = 0;
            this.CPUUsage.Text = "CPU Usage:";
            //
            // BackUpTime
            //
            this.BackUpTime.Location = new System.Drawing.Point(3, 23);
            this.BackUpTime.Maximum = 60;
            this.BackUpTime.Name = "BackUpTime";
            this.BackUpTime.Size = new System.Drawing.Size(249, 45);
            this.BackUpTime.SmallChange = 5;
            this.BackUpTime.TabIndex = 3;
            this.BackUpTime.TickFrequency = 5;
            this.BackUpTime.Scroll += new System.EventHandler(this.BackUpTime_Changed);
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(3, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 443);
            this.tabControl1.TabIndex = 5;
            //
            // tabPage1
            //
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DebugConsole);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Temp Debug Console";
            //
            // DebugConsole
            //
            this.DebugConsole.Enabled = false;
            this.DebugConsole.Location = new System.Drawing.Point(3, 315);
            this.DebugConsole.Multiline = true;
            this.DebugConsole.Name = "DebugConsole";
            this.DebugConsole.ReadOnly = true;
            this.DebugConsole.Size = new System.Drawing.Size(807, 96);
            this.DebugConsole.TabIndex = 0;
            //
            // tabPage2
            //
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.tabPage2.Controls.Add(this.SettingsPanel);
            this.tabPage2.Controls.Add(this.SettingsLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            //
            // SettingsPanel
            //
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.SettingsPanel.Controls.Add(this.panel1);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(813, 417);
            this.SettingsPanel.TabIndex = 6;
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SetBackupTimer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BackupLocationBar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackUpTime);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 117);
            this.panel1.TabIndex = 4;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "10 Minutes";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Backup Location:";
            //
            // BackupLocationBar
            //
            this.BackupLocationBar.Location = new System.Drawing.Point(103, 61);
            this.BackupLocationBar.Name = "BackupLocationBar";
            this.BackupLocationBar.Size = new System.Drawing.Size(149, 20);
            this.BackupLocationBar.TabIndex = 5;
            this.BackupLocationBar.Text = "Backup Location";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Backup interval:";
            //
            // SettingsLabel
            //
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsLabel.Location = new System.Drawing.Point(6, 3);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(534, 25);
            this.SettingsLabel.TabIndex = 7;
            this.SettingsLabel.Text = "You cannot modify settings whilst the server is running";
            //
            // SetBackupTimer
            //
            this.SetBackupTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.SetBackupTimer.Enabled = false;
            this.SetBackupTimer.FlatAppearance.BorderSize = 0;
            this.SetBackupTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBackupTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBackupTimer.ForeColor = System.Drawing.Color.White;
            this.SetBackupTimer.Location = new System.Drawing.Point(177, 87);
            this.SetBackupTimer.Name = "SetBackupTimer";
            this.SetBackupTimer.Size = new System.Drawing.Size(75, 23);
            this.SetBackupTimer.TabIndex = 8;
            this.SetBackupTimer.Text = "Save";
            this.SetBackupTimer.UseVisualStyleBackColor = false;
            this.SetBackupTimer.Click += new System.EventHandler(this.SetBackupTimer_Click);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Every";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RamLabel);
            this.Controls.Add(this.CPUUsage);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ActivityBar);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DBServer Controller";
            ((System.ComponentModel.ISupportInitialize)(this.BackUpTime)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar ActivityBar;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.TrackBar BackUpTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown BackupLocationBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DebugConsole;
        private System.Windows.Forms.Button SetBackupTimer;
        private System.Windows.Forms.Label label5;
        //new timer after not fucking with this one
        private System.Windows.Forms.Timer BackupTimer;
    }
}
