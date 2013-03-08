using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.TimerWithEvents
{
    public delegate void TimerCallback(EventArgs e);
    public delegate void TimerStarted(EventArgs e);
    public delegate void TimerStopped(EventArgs e);

    /// <summary>
    /// Class that can execute a method every t seconds and 
    /// has events
    /// </summary>
    public class Timer
    {
        private TimerCallback callback;
        private int interval;
        private System.Threading.Timer internalTimer;

        // events
        public event TimerStarted Started;
        public event TimerCallback Executed;
        public event TimerStopped Stopped;

        // helper method that raises the Started event
        private void OnStarted(EventArgs e)
        {
            if(this.Started != null)
            {
                this.Started(e);
            }
        }

        // helper method that raises the Executed event
        private void OnExecuted(EventArgs e)
        {
            if (this.Executed != null)
            {
                this.Executed(e);
            }
        }

        // helper method that raises the Stopped event
        private void OnStopped(EventArgs e)
        {
            if(this.Stopped != null)
            {
                this.Stopped(e);
            }
        }

        public Timer(int t)
        {
            // initialize internval
            this.interval = t;
        }

        public void Start()
        {
            this.OnStarted(EventArgs.Empty);

            // starting the internal Timer
            this.internalTimer = new System.Threading.Timer(e => OnExecuted(EventArgs.Empty),
                new object(), TimeSpan.Zero, TimeSpan.FromSeconds(this.interval));
        }

        public void Stop()
        {
            // stopping the internal Timer
            this.internalTimer.Dispose();
            OnStopped(EventArgs.Empty);
        }
    }
}
