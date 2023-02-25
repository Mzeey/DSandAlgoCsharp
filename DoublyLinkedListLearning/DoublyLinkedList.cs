using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoublyLinkedListLearning.Repositories;

namespace DoublyLinkedListLearning
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        public Node<T> Head { get; set; } = null;
        public Node<T> Tail { get; set; } = null;
        public int Size { get; set; }

        public DoublyLinkedList(){}

        public DoublyLinkedList(T value){
            this.Head.Data = value;
            Tail = Head;
            this.Head.Next = Tail;
            this.Tail.Prev = Head;
            
            Size++;
        }

        public void Append(T value)
        {
            Node<T> newestNode = new Node<T>(value);
            if(Head == null){
                Head = newestNode;
                Tail = Head;
                Head.Next = Tail;
                Tail.Prev = Head;
            }else{
                newestNode.Prev = Tail;
                Tail.Next = newestNode;
                Tail = newestNode;
            }

            Size++;
        }

        public Node<T> DeleteAtIndex(int index)
        {
            if(index > Size){
                throw new IndexOutOfRangeException("Index is out of range");
            }
            int i = 0;
            Node<T> currentNode = Head;
            while(i < Size){
                if(i == index){
                    currentNode.Prev = currentNode.Next;
                    break;
                }
                currentNode = currentNode.Next;
                i++;
            }
            return currentNode;
        }

        public void Display()
        {
            string result = "";
            Node<T> currentNode = Head;
            for(int i = 0; i < Size; i++){
                result+= $"{currentNode.Data} -->";
                currentNode = currentNode.Next;
            }

            Console.WriteLine(result);
        }

        public Node<T> Find(T value)
        {
            throw new NotImplementedException();
        }

        public Node<T> FindAtIndex(int index, T value)
        {
            throw new NotImplementedException();
        }

        public void InsertAtIndex(int index, T value)
        {
            throw new NotImplementedException();
        }

        public Node<T> Pop()
        {
            throw new NotImplementedException();
        }

        public void Prepend(T value)
        {
            throw new NotImplementedException();
        }

        public Node<T> Shift()
        {
            throw new NotImplementedException();
        }
    }
}