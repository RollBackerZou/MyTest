using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ontime
{
    public class OnTimeService
    {
        readonly Timer timer;

        public OnTimeService()
        {
            timer.Interval = 6000;
            timer.AutoReset = true;
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Serena");
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }


    }
}
