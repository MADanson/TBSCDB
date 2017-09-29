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
            System.Windows.Forms.Button ServerStart;
            ServerStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerStart
            // 
            ServerStart.Location = new System.Drawing.Point(12, 12);
            ServerStart.Name = "ServerStart";
            ServerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ServerStart.Size = new System.Drawing.Size(85, 40);
            ServerStart.TabIndex = 0;
            ServerStart.Text = "Start Server";
            ServerStart.UseVisualStyleBackColor = true;
            ServerStart.Click += new System.EventHandler(this.ServerStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(826, 495);
            this.ControlBox = false;
            this.Controls.Add(ServerStart);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DBServer Controller";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

