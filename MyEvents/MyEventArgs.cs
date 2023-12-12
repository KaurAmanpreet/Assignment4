using System;
namespace MyEvents
{
	public class MyEventArgs : EventArgs
	{
        public string Message { get; }

        public MyEventArgs(string message)
        {
            Message = message;
        }

        public delegate void MyEventHandler(object sender, MyEventArgs e);
    }
}

