using System;
using System.Windows.Forms;

namespace OneLastSong
{
    // TODO: Can we be more explicit that this countdown resolution is seconds? The IsExpired getter is a workaround.
    public class Countdown
    {
        public static Countdown FromMinutes(double minutes)
        {
            return new Countdown(TimeSpan.FromMinutes(minutes));
        }

        /// <summary>
        /// The countdown ticks down every second.
        /// </summary>
        public event Action Tick;

        /// <summary>
        /// The countdown expires after the specified duration.
        /// </summary>
        public event Action Expired;
        
        public TimeSpan TimeRemaining { get; private set; }

        public bool IsExpired
        {
            get { return TimeRemaining.TotalSeconds <= 0; }
        }

        private readonly Timer timer;
        private readonly TimeSpan interval = TimeSpan.FromSeconds(1);

        /// <summary>
        /// Wrap up a Windows forms timer as a Countdown. Provide access to the ticking and the expired event.
        /// </summary>
        private Countdown(TimeSpan duration)
        {
            TimeRemaining = duration;
            timer = new Timer { Interval = (int)interval.TotalMilliseconds };
            timer.Tick += OnTimerTick;
        }

        private void OnTimerTick(object sender, EventArgs eventArgs)
        {
            if (IsExpired)
            {
                timer.Stop();
                Expired.SafeInvoke();
                return;
            }

            TimeRemaining -= interval;
            Tick.SafeInvoke();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void IncreaseDuration(TimeSpan increment)
        {
            TimeRemaining += increment;
        }
    }
}