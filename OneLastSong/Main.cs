using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using OneLastSong.Commands;

namespace OneLastSong
{
    public partial class Main : Form
    {
        private static readonly Dictionary<int, ICommand> CommandMap = new Dictionary<int, ICommand>
        {
            { 0, new Hibernate() },
            { 1, new Shutdown() },
            { 2, new Standby() },
            { 3, new Restart() },
        };

        //Time tracking vars
        private int minutes;
        private int seconds;

        public Main()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Time.Focus();
            cmbOption.SelectedIndex = 0;
        }

        private void OnGoClick(object sender, EventArgs e)
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

        private void OnFiveMoreMinutesClick(object sender, EventArgs e)
        {
            minutes += 5;
            SetLabel(minutes, seconds);
        }

        private void PerformTask()
        {
            if (DisableMonitor.Checked)
            {
                new PowerOffMonitor(Handle).Execute();
                Thread.Sleep(1000);
            }

            var command = CommandMap[cmbOption.SelectedIndex];
            command.Execute();
        }

        private void OnTimerTick(object sender, EventArgs e)
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