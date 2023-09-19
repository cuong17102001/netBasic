// See https://aka.ms/new-console-template for more information
using exc3;

EventPublisher eventPublisher = new EventPublisher();

eventPublisher.EventOccurred += SubscriberMethod1;
eventPublisher.EventOccurred += SubscriberMethod2;

eventPublisher.SimulateEvent("Event 1 has occurred!");

eventPublisher.EventOccurred -= SubscriberMethod1;

eventPublisher.SimulateEvent("Event 2 has occurred!");

static void SubscriberMethod1(string message)
{
    Console.WriteLine("Subscriber 1 received the message: " + message);
}

static void SubscriberMethod2(string message)
{
    Console.WriteLine("Subscriber 2 received the message: " + message);
}