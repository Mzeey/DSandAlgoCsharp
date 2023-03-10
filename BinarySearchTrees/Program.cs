// See https://aka.ms/new-console-template for more information
using BinarySearchTrees.Trees;

BinarySearchTree<int> B = new BinarySearchTree<int>();
B.RecursiveInsert(50);
B.RecursiveInsert(30);
B.Insert(80);
B.Insert(10);
B.Insert(40);
B.Insert(60);
B.Insert(90);
B.InOrder();
B.Display();
B.PreOrder();
B.Display();
B.PostOrder();
B.Display();
B.LevelOrder();
B.Display();
var result = B.Search(66);
if(result is not null)
    Console.WriteLine($"Found: {result.Value}");
else
    Console.WriteLine("Not found");

Console.WriteLine("Hello, World!");
