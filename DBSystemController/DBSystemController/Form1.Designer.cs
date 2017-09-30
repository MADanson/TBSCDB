namespace DBSystemController
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
            this.PercentBytesUsed = new System.Diagnostics.PerformanceCounter();
            this.TotalCPUUsage = new System.Diagnostics.PerformanceCounter();
            this.RamLabel = new System.Windows.Forms.Label();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PercentBytesUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPUUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
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
            this.ActivityBar.Size = new System.Drawing.Size(670, 31);
            this.ActivityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ActivityBar.TabIndex = 2;
            this.ActivityBar.Value = 100;
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.White;
            this.StartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartStop.FlatAppearance.BorderSize = 0;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartStop.Location = new System.Drawing.Point(680, 12);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(134, 31);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start Server";
            this.StartStop.UseMnemonic = false;
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // PercentBytesUsed
            // 
            this.PercentBytesUsed.CategoryName = "Memory";
            this.PercentBytesUsed.CounterName = "% Committed Bytes In Use";
            this.PercentBytesUsed.MachineName = "-";
            // 
            // TotalCPUUsage
            // 
            this.TotalCPUUsage.CategoryName = "Processor Information";
            this.TotalCPUUsage.CounterName = "% Privileged Time";
            this.TotalCPUUsage.InstanceName = "_Total";
            this.TotalCPUUsage.MachineName = "-";
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
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 1000;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(826, 495);
            this.Controls.Add(this.RamLabel);
            this.Controls.Add(this.CPUUsage);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ActivityBar);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DBServer Controller";
            ((System.ComponentModel.ISupportInitialize)(this.PercentBytesUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPUUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar ActivityBar;
        private System.Windows.Forms.Button StartStop;
        private System.Diagnostics.PerformanceCounter PercentBytesUsed;
        private System.Diagnostics.PerformanceCounter TotalCPUUsage;
        private System.Windows.Forms.Label CPUUsage;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Timer Updater;
    }
}

