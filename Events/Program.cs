// Events
// An event is a special kind of delegate that provides a way for a class to notify clients of changes or actions. 
// Events are usually used to implement the observer pattern.
using System;

// Step 1: Define a delegate that matches the event handler method signature
public delegate void NotifyEventHandler(string message);

public class Publisher
{
    // Step 2: Declare an event based on the delegate
    public event NotifyEventHandler Notify;

    public void RaiseEvent(string message)
    {
        // Step 3: Raise the event (only if there are subscribers)
        Notify?.Invoke(message);
    }
}

public class Subscriber
{
    // This method will be called when the event is raised
    public void OnNotify(string message)
    {
        Console.WriteLine("Subscriber received: " + message);
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Publisher and Subscriber
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        
        // Step 4: Subscribe the OnNotify method to the Notify event
        publisher.Notify += subscriber.OnNotify;

        // Step 5: Raise the event
        publisher.RaiseEvent("Hello, Events!");
    }
}
