using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class Timer
    {
        public event EventHandler<NewTimeEventArgs> NewTime;

        protected virtual void OnNewTime(NewTimeEventArgs e)
        {
            EventHandler<NewTimeEventArgs> temp = Volatile.Read(ref NewTime);
            temp?.Invoke(this, e);
        }

        public void SimulateNewTime(int seconds)
        {
            NewTimeEventArgs e =new NewTimeEventArgs(seconds);
            Thread.Sleep(seconds * 1000);
            OnNewTime(e);
        }
    }
}
