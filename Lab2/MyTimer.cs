using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    class MyTimer
    {
        private Timer timer;
        private EventHandler now;

        public MyTimer()
        {
            timer = new Timer();
            now = null;
        }
        public void SetInterval(int newInterval)
        {
            timer.Interval = newInterval;
        }
        public void AddEventHandler(EventHandler newEvent)
        {
            timer.Tick += newEvent;
            now = newEvent;
        }
        public void ChangeTick(EventHandler newEvent)
        {
            if (now != null) timer.Tick -= now;
            timer.Tick += newEvent;
            now = newEvent;
        }
        public void StartTimer(int interval, EventHandler newEvent)
        {
            if (now != null) timer.Tick -= now;
            timer.Tick += newEvent;
            now = newEvent;
            timer.Interval = interval;
            timer.Start();
        }
        public void StartTimer()
        {
            timer.Start();
        }
        public void StopTimer()
        {
            timer.Stop();
            if (now != null) timer.Tick -= now;
        }
    }
}
