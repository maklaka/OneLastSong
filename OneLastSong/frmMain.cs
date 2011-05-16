using System;
using System.Windows.Forms;
using System.Diagnostics;
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
            Time.Focus();
            cmbOption.SelectedIndex = 0;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (Time.Text.IsEmpty() || !Time.Text.IsPositiveNumber())
            {
                MessageBox.Show("No deal, enter a number of minutes please.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            Timer.Stop();
            minutes = (int)double.Parse(Time.Text);
            seconds = (int)(60.0 * (double.Parse(Time.Text) - minutes));
            SetLabel(minutes, seconds);
            btnFiveMore.Enabled = true;
            Timer.Start();
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
                    Timer.Stop();
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
    }
}