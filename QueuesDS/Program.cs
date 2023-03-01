// See https://aka.ms/new-console-template for more information
using QueuesDS;

QueueLList<int> myQueue = new QueueLList<int>();
myQueue.Enqueue(5);
myQueue.Enqueue(3);
myQueue.Display();
Console.WriteLine($"Size: {myQueue.getLength()}");
Console.WriteLine($"Element Removed: {myQueue.Dequeue()}");
Console.WriteLine($"IsEmpty: {myQueue.IsEmpty()}");
Console.WriteLine($"Element Removed: {myQueue.Dequeue()}");
Console.WriteLine($"IsEmpty: {myQueue.IsEmpty()}");
