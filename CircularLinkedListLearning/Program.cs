// See https://aka.ms/new-console-template for more information
using CircularLinkedListLearning;
Console.WriteLine("Hello, World!");

CircularLinkedList<int>  mylist = new CircularLinkedList<int>();

mylist.Append(1);
mylist.Append(7);
mylist.Append(21);
mylist.Display();
Console.WriteLine("Size: " + mylist.Size);

mylist.Append(66);
mylist.Append(40);
mylist.Prepend(77);

mylist.Display();
mylist.InsertAtIndex(5, 88);
Console.WriteLine($"Shifted: {mylist.Shift().Data}");
Console.WriteLine($"Popped: {mylist.Pop().Data}");
Console.WriteLine($"Removed at Index 3: {mylist.DeleteAtIndex(3).Data}");
mylist.Display();
Console.WriteLine("Size: " + mylist.Size);
