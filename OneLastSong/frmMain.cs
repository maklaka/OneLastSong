using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace OneLastSong
{
    public partial class frmMain : Form
    {
        const int optHibernate = 0, optShutdown = 1, optStandby = 2, optRestart = 3;
        const uint WM_SYSCOMMAND = 0x0112;
        //IntPtrs can't be consts...but the API accepts only IntPtr. Hmm
        IntPtr SC_MONITORPOWER = (IntPtr)0xF170;  
        IntPtr MONITOR_OFF = (IntPtr)2;
        IntPtr MONITOR_STANBY = (IntPtr)1;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg,IntPtr wParam, IntPtr lParam);

        //Time tracking vars
        int seconds = 0, minutes = 0;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtTime.Focus();
            cmbOption.SelectedIndex = 0;
            this.Icon = OneLastSong.Properties.Resources.clef;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtTime.Text == "" || !IsNumeric(txtTime.Text))
                MessageBox.Show("No deal, enter a number of minutes please.","Try again.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                timTimer.Stop();
                double temp = Convert.ToDouble(txtTime.Text);
                minutes = seconds = 0;
                minutes = (int)temp;
                seconds = (int)(60.0 * (temp - minutes));
                SetLabel(minutes, seconds);
                btnFiveMore.Enabled = true;
                timTimer.Start();
            }
        }
        private void btnFiveMore_Click(object sender, EventArgs e)
        {
            minutes += 5;
            SetLabel(minutes, seconds);
        }
        private void PerformTask()
        {
            if (chkMonitor.Checked)
            {
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
                System.Threading.Thread.Sleep(1000);
            }

            if (cmbOption.SelectedIndex == optHibernate)
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            else if (cmbOption.SelectedIndex == optShutdown)
                Process.Start("shutdown", "/s /t 0");
            else if (cmbOption.SelectedIndex == optStandby)
                Application.SetSuspendState(PowerState.Suspend, true, true);
            else if (cmbOption.SelectedIndex == optRestart)
                Process.Start("ShutDown", "/r");
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                minutes--;
                seconds = 60;
                if (minutes < 0)
                {
                    timTimer.Stop();
                    PerformTask();
                    return;
                }
            }

            seconds--;
            SetLabel(minutes, seconds);
        }
        private void SetLabel(int mins, int secs)
        {
            string ss = "";
            string ms = "";
            if(secs < 10)
                ss = "0";
            if (mins < 10)
                ms = "0";

            lblCountDown.Text = ms + minutes + ":" + ss + secs;
        }
        private bool IsNumeric(string test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                //if not 0-9 or decimal point. Not numeric
                if (test[i] < 46 || test[i] > 57 || test[i] == 47)
                    return false;
            }
            return true;
        }
    }
}
