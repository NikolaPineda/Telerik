using System;
using System.Threading;

namespace Events
{
    /// <summary>
    ///     Problem 8.* Events
    ///     Read in MSDN about the keyword event in C# and how to publish events.
    ///     Re-implement the above using .NET events and following the best practices.
    /// </summary>
    public class TimeElapsedEventArgs : EventArgs
    {
        public TimeElapsedEventArgs(int ticksCountX)
        {
            TicksCount = ticksCountX;
        }

        public int TicksCount { get; }
    }

    public delegate void TimeElapsedEventHandler(object sender, TimeElapsedEventArgs e);

    public class Timer
    {
        private int clicks;
        private int delay;

        public Timer(int delay, int clicks)
        {
            Delay = delay;
            Clicks = clicks;
        }

        public int Delay
        {
            get { return delay; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Delay must be non-negative number.");
                }

                delay = value;
            }
        }

        public int Clicks
        {
            get { return clicks; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Clicks must be non-negative number.");
                }

                clicks = value;
            }
        }

        public event TimeElapsedEventHandler TimeElapsed;

        protected internal void OnTimeElapsed(int tick)
        {
            if (TimeElapsed != null)
            {
                TimeElapsed(this, new TimeElapsedEventArgs(tick));
            }
        }

        public void Activate()
        {
            var tick = Clicks;

            var newThread = new Thread(() =>
            {
                Thread.Sleep(Delay*1000);
                tick--;
                OnTimeElapsed(tick);
            });
            newThread.Start();
        }
    }

    public class Events
    {
        public static void Timer_TimeChanged(object sender, TimeElapsedEventArgs e)
        {
            Console.WriteLine("Time elapsed {0}", e.TicksCount);
        }

        private static void Main()
        {
            var newTimer = new Timer(1, 20);
            newTimer.TimeElapsed += Timer_TimeChanged;
            newTimer.Activate();
        }
    }
}