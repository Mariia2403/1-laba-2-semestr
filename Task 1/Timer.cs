using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Timer
    {
        public delegate void TimerDelegate();

        private readonly TimerDelegate _method;
        private readonly int _interval;
        private bool _running;

        public Timer(TimerDelegate method, int intervalInSeconds)
        {
            _method = method;
            _interval = intervalInSeconds * 1000;
        }

        public void StartAsync(int repetitions)
        {
            _running = true;
            Task.Run(() =>
            {
                for (int i = 0; i < repetitions && _running; i++)
                {
                    _method();
                    Thread.Sleep(_interval);
                }
            });
        }

        public void Stop()
        {
            _running = false;
        }
    }
}
