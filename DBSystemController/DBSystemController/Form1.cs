using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSystemController
{
    public partial class Form1 : Form
    {
        
        bool SystemRunning = false; //this will have protection later I promise!

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void ServerStart_Click(object sender, EventArgs e)
        {
            if (SystemRunning == true)
            {
                SystemRunning = true;
                ServerStart.Text = "Server Running";
            }
            else if (SystemRunning == false)
            {
                //ServerStart.Text = "Start Server";
            }
        }
    }

}
