using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.ExecutingTimer
{
    public delegate void TimerCallback();

    /// <summary>
    /// Class that can execute a method every t seconds
    /// </summary>
    public class Timer
    {
        private TimerCallback callback;
        private int interval;
        private System.Threading.Timer internalTimer;

        public Timer(TimerCallback method, int t)
        {
            // initialize with method and internval
            this.callback += method;
            this.interval = t;
        }

        public void Start()
        {
            // starting the internal Timer
            this.internalTimer = new System.Threading.Timer(e => this.callback(),
                new object(), TimeSpan.Zero, TimeSpan.FromSeconds(this.interval));
        }

        public void Stop()
        {
            // stopping the internal Timer
            this.internalTimer.Dispose();
        }
    }
}
