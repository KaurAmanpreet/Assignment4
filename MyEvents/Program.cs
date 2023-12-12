namespace MyEvents;
class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventHandler eventHandler = new EventHandler();

        publisher.MyEvent += eventHandler.HandleMyEvent;

        publisher.RaiseEvent("event raised..");
    }
}

