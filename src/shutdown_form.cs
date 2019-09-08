using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownPC
{
    public partial class shutdown_form : Form
    {
        int sc;
        int scx;
        int scy;
        public shutdown_form()
        {
            InitializeComponent();
        }

        private void Shutdown_form_Load(object sender, EventArgs e)
        {
            curTimeTimer.Enabled = true;
            rpcText.Text = "";
        }

        private void CurTimeTimer_Tick(object sender, EventArgs e)
        {
            curTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void StartShutdown_Click(object sender, EventArgs e)
        {
            if(heuresBox.Text == "")
            {
                MessageBox.Show("Opération impossible.", "ShutdownPC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string combTime = shutdownTime.Text = heuresBox.Text + ":" + minutesBox.Text + ":" + secondesBox.Text;
                checkShutdown.Enabled = true;
                rpcText.Text = "Arrêt du PC : ";
            }
           
        }

        private void CheckShutdown_Tick(object sender, EventArgs e)
        {
            if(shutdownTime.Text == curTime.Text)
            {
                Process.Start("shutdown", "/s /t 0");
                checkShutdown.Enabled = false;
            }
        }

        private void Twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.twitter.com/spacework_brad");
        }

        private void Shutdown_form_MouseDown(object sender, MouseEventArgs e)
        {
            sc = 1;
            scx = e.X;
            scy = e.Y;
        }

        private void Shutdown_form_MouseMove(object sender, MouseEventArgs e)
        {
            if(sc == 1)
            {
                this.SetDesktopLocation(MousePosition.X - scx, MousePosition.Y -scy);
            }
        }

        private void Shutdown_form_MouseUp(object sender, MouseEventArgs e)
        {
            sc = 0;
        }

        private void Closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
