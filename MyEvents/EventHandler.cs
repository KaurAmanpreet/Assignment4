using System;
namespace MyEvents
{
	public class EventHandler
	{
		public void HandleMyEvent(object sender, MyEventArgs e)
		{
            Console.WriteLine($"Event handled: {e.Message}");
        }
	}
}

