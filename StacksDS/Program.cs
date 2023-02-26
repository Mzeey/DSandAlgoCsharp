// See https://aka.ms/new-console-template for more information
using StacksDS;

StacksDS.Stack<int> stack = new StacksDS.Stack<int>(10);
stack.Push(5);
stack.Push(3);
stack.Display();
Console.WriteLine("Size: "+ stack.GetLength());
Console.WriteLine("Element Popped: "+ stack.Pop());
Console.WriteLine("IsEmpty: "+ stack.IsEmpty());
Console.WriteLine("Element Popped: "+ stack.Pop());
Console.WriteLine("IsEmpty: "+ stack.IsEmpty());
stack.Push(7);
stack.Push(9);
Console.WriteLine("Element Top: "+ stack.Peek());
stack.Display();
Console.WriteLine("Hello, World!");
