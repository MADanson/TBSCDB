using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DBSystemController
{
    public partial class Form1 : Form
    {
        
        bool SystemRunning = false; //this will have protection later I promise!

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ActivityBar.Value = 100;
            ModifyProgressBarColor.SetState(ActivityBar, 2);
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (SystemRunning == false)
            {
                buttonStart.Text = "Start Server";
                SystemRunning = true;
                ModifyProgressBarColor.SetState(ActivityBar, 2);

            } else if (SystemRunning == true)
            {
                buttonStart.Text = "Stop Server";
                SystemRunning = false;
                ModifyProgressBarColor.SetState(ActivityBar, 1);

            }
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
