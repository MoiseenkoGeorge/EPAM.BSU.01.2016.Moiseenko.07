using System;

namespace Task1
{
    public class Subscriber2
    {
        public Subscriber2(Timer timer)
        {
            timer.NewTime += TimeOut;
        }

        private void TimeOut(Object sender, NewTimeEventArgs e)
        {
            Console.WriteLine("Subscriber2 has been notified about the event, EventInfo: seconds - {0}", e.Seconds);
        }
        public void Unregister(Timer timer)
        {
            timer.NewTime -= TimeOut;
        }
    }
}