// See https://aka.ms/new-console-template for more information
using LinkedListLearning;


LList<int> MyLinkedList = new LList<int>(78);
Console.Write("Linked List Values: ");
MyLinkedList.InsertSorted(7);
MyLinkedList.InsertSorted(4);
MyLinkedList.InsertSorted(50);
MyLinkedList.InsertSorted(12);

MyLinkedList.Display();
Console.WriteLine("Size: " + MyLinkedList.Size);
Console.WriteLine("Found at last Index --> " + MyLinkedList.FindAtIndex(MyLinkedList.Size-1));
