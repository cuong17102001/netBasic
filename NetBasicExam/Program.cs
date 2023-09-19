// See https://aka.ms/new-console-template for more information
using NetBasicExam;

NotificationCenter notificationCenter = new NotificationCenter();

notificationCenter.SendMessage("Hello World!");

notificationCenter.MessageReceived += HandleMessage;

notificationCenter.SendMessage("Hello World2!");

void HandleMessage(string message)
{
    Console.WriteLine("Received message: " + message);
}