// See https://aka.ms/new-console-template for more information
using DoublyLinkedListLearning;



public class Program
{
    public static void Main()
    {
        var myList = new DoublyLinkedList<int>();

        myList.Append(15);
        myList.Append(20);
        myList.Append(25);
        myList.DeleteAtIndex(1);
        myList.InsertAtIndex(0, 41);
        myList.Prepend(90);
        myList.Shift();
        myList.Display();

        // Console.WriteLine($"{myList.FindAtIndex(2).Data}");
    }
}