using System;
using static MyEvents.MyEventArgs;

namespace MyEvents
{
	public class EventPublisher
	{
        public event MyEventHandler MyEvent;

        public void RaiseEvent(string message)
        {
            
        }
    }
}

