using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        private static void Main()
        {
            Timer timer = new Timer();
            Subscriber1 subscriber1 = new Subscriber1(timer);
            Subscriber2 subscriber2 = new Subscriber2(timer);
            timer.SimulateNewTime(2);
            subscriber2.Unregister(timer);
            timer.SimulateNewTime(3);
            Console.ReadKey();
        }
    }
}
