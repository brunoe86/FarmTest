using System;

namespace FarmSystem.Test1
{
    public delegate void MyEventHandler(object source, MyEvents e);

    public class MyEvents : EventArgs
    {
        private string EventInfo;
        public MyEvents(string t)
        {
            EventInfo = t;
        }

        public string GetInfo()
        {
            return EventInfo;
        }
    }
}
