using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoublyLinkedListLearning;

namespace DoublyLinkedListLearning.Repositories
{
    public interface IDoublyLinkedList<T>
    {
        public Node<T> Head {get;set;}
        public Node<T> Tail {get;set;}
        public int Size {get;set;}
        public void Append(T value);
        public void Prepend(T value);
        public Node<T> Shift();
        public Node<T> Pop();
        public Node<T> DeleteAtIndex(int index);
        public void InsertAtIndex(int index, T value);

        public Node<T> Find(T value);
        public Node<T> FindAtIndex(int index);
        public void Display();
    }
}