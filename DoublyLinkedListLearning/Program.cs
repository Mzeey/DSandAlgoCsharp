// See https://aka.ms/new-console-template for more information
using DoublyLinkedListLearning;

var myList = new DoublyLinkedList<int>();

myList.Append(15);
myList.Append(20);
myList.Append(25);
myList.DeleteAtIndex(1);
myList.Display();
var message = "not found";

Console.WriteLine($"{myList.FindAtIndex(2).Data}");