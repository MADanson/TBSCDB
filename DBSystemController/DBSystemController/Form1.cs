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
        //Defining counters
        PerformanceCounter PercentBytesUsed = new System.Diagnostics.PerformanceCounter();
        PerformanceCounter TotalCPUUsage = new System.Diagnostics.PerformanceCounter();
        Timer Updater = new Timer();

        public Form1()
        {
            InitializeComponent();
            //Creates Performance Counters
            PercentBytesUsed = new PerformanceCounter("Memory", "Available MBytes", String.Empty, System.Environment.MachineName);
            TotalCPUUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total", System.Environment.MachineName);

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

        string DebugConsoleText;
        bool SystemRunning = false; //this will have protection later I promise!

        private void StartStop_Click(object sender, EventArgs e)
        {
            //<<<<<<<<<< THIS STARTS THE SERVER
            if (SystemRunning == false)
            {
                buttonStart.Text = "Server Running";
                SystemRunning = true;
                ModifyProgressBarColor.SetState(ActivityBar, 1);
                //creates a new instance of the class StartupProcess
                OpenConnections();
                SettingsPanel.Visible = false;

            }
            //<<<<<<<<<< THIS STOPS THE SERVER
            else if (SystemRunning == true)
            {
                buttonStart.Text = "Server Stopped";
                SystemRunning = false;
                ModifyProgressBarColor.SetState(ActivityBar, 2);
                SettingsPanel.Visible = true;
                CloseConnections();
            }
        }

        //Runs every second that the updater ticks
        private void Updater_Tick(object sender, EventArgs e)
        {
            double RamRound = (PercentBytesUsed.NextValue()) / 100;
            RamLabel.Text = "RAM Usage: " + Math.Round(RamRound, 0,MidpointRounding.AwayFromZero) + "%";
            CPUUsage.Text = "CPU Usage: " + Math.Round(TotalCPUUsage.NextValue(), 0, MidpointRounding.AwayFromZero) + "%";
        }

        //Method for setting DebugConsole Text from outside classes
        public void SetConsoleText(ref string text)
        {
            //TIL Using AppendText is more data efficient as it only renders visable text
            DebugConsole.AppendText(text);
            DebugConsole.AppendText(Environment.NewLine);
        }

        //this process is called when the server is started
        //<<<<<<<<<< THIS SHOULD OPEN ALL OF THE CONNECTIONS
        public void OpenConnections()
        {
            DebugConsoleText = "Establishing Connections";
            //use this 
            SetConsoleText(ref DebugConsoleText);
        }

        //<<<<<<<<<< THIS SHOULD CLOSE ALL OF THE CONNECTIONS WHEN THE SERVER IS TURNED OFF
        public void CloseConnections()
        {
            DebugConsoleText = "Closing Connections";
            SetConsoleText(ref DebugConsoleText);
        }

        //this is the start of the elemtns need for backup settings
        private void SetBackupTimer_Click(object sender, EventArgs e)
        {
            //will become enabled whenever an element is changed
            SetBackupTimer.Enabled = false;
            //Then sets the new backup elements
            //such as changing the timer
        }

        private void BackUpTime_Changed(object sender, EventArgs e)
        {
            SetBackupTimer.Enabled = true;
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
