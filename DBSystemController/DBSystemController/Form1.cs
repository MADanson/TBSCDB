using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DBSystemController
{
    public partial class Form1 : Form
    {


        PerformanceCounter PercentBytesUsed = new System.Diagnostics.PerformanceCounter();
        PerformanceCounter TotalCPUUsage = new System.Diagnostics.PerformanceCounter();
        Timer Updater = new Timer();

        public Form1()
        {
            InitializeComponent();
            //Creates Performance Counters
            PercentBytesUsed.CategoryName = "Memory";
            PercentBytesUsed.CounterName = "%Committed Bytes In Use";
            TotalCPUUsage.CategoryName = "ProcessorInformation";
            TotalCPUUsage.CounterName = "%Privileged Time";

            //adding 1 Second Updater
            Updater.Interval = 1000;
            TotalCPUUsage.MachineName = System.Environment.MachineName;
            PercentBytesUsed.MachineName = System.Environment.MachineName;
            Updater.Tick += new EventHandler(Updater_Tick);
            Updater.Enabled = true;
            Updater.Start();

            FormBorderStyle = FormBorderStyle.Fixed3D;
            ModifyProgressBarColor.SetState(ActivityBar, 2);
        }



        bool SystemRunning = false; //this will have protection later I promise!

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (SystemRunning == false)
            {
                buttonStart.Text = "Server Running";
                SystemRunning = true;
                ModifyProgressBarColor.SetState(ActivityBar, 1);
            }
            else if (SystemRunning == true)
            {
                buttonStart.Text = "Server Stopped";
                SystemRunning = false;
                ModifyProgressBarColor.SetState(ActivityBar, 2);
            }
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            RamLabel.Text = "RAM Usage: " + Math.Round(PercentBytesUsed.NextValue(), 0) + "%";
            CPUUsage.Text = "CPU Usage: " + Math.Round(TotalCPUUsage.NextValue(), 0) + "%";
        }
    }

    //progress bar, that's right we need all this to change the colour
    //call this with values: 1 = green, 2 = red, 3 = yellow
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
