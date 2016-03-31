using System;

namespace Task1
{
    public class NewTimeEventArgs : EventArgs
    {
        public NewTimeEventArgs(int seconds)
        {
            Seconds = seconds;
        }

        public int Seconds { get; }
    }
}