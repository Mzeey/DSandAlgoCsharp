using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularLinkedListLearning
{
    public class CircularLinkedList<T>
    {
        public Node<T> Head { get; set; } = null;
        public Node<T> Tail { get; set; } = null;
        public int Size { get; set; } = 0;

        public CircularLinkedList() { }


        public void Append(T value)
        {
            Node<T> newestNode = new Node<T>(value);
            if (Head == null)
            {
                newestNode.Next = newestNode;
                Head = newestNode;
                Tail = newestNode;
            }
            else
            {
                newestNode.Next = Head;
                Tail.Next = newestNode;
                Tail = Tail.Next;
            }
            Size++;
        }

        public void Prepend(T value)
        {
            Node<T> newestNode = new Node<T>(value);
            if (Head == null)
            {
                Append(value);
            }
            else
            {
                newestNode.Next = Head;
                Head = newestNode;
                Tail.Next = newestNode;
                Size++;
            }
        }

        public void InsertAtIndex(int index, T value)
        {
            if (index > Size)
            {
                throw new IndexOutOfRangeException("The index is out of range");
            }
            if (index == 0)
            {
                Append(value);
                return;
            }

            Node<T> prevNode = Head;
            Node<T> currentNode = Head;
            Node<T> newestNode = new Node<T>(value);
            int i = 0;
            while (i < Size)
            {
                if (i == index)
                {
                    newestNode.Next = currentNode;
                    prevNode.Next = newestNode;
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                i++;
            }
            Size++;
        }

        public void Display()
        {
            Node<T> currentNode = Head;
            string output = "";
            int i = 0;
            while (i < Size)
            {
                output += $"{currentNode.Data} --> ";
                currentNode = currentNode.Next;
                i++;
            }

            Console.WriteLine(output);
        }

        public Node<T> Shift()
        {
            if (Size < 1)
            {
                throw new Exception("This List is Empty");
            }

            Node<T> deletedNode = Head;
            Head = Head.Next;
            Tail.Next = Head;
            Size--;

            return deletedNode;
        }

        public Node<T> Pop()
        {
            if (Size < 1)
            {
                throw new Exception("This List is Empty");
            }

            Node<T> prevNode = Head;
            Node<T> currentNode = Head;
            int i = 0;
            while (i < Size)
            {
                if (i == Size - 1)
                {
                    prevNode.Next = Head;
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                i++;
            }
            Size--;

            return currentNode;
        }

        public Node<T> DeleteAtIndex(int index)
        {
            if (index > Size)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            Node<T> deletedNode = null;
            Node<T> prevNode = Head;
            int i = 1;
            while (i < Size)
            {
                if (i == index)
                {
                    deletedNode = prevNode.Next;
                    prevNode.Next = prevNode.Next.Next;
                    break;
                }
                prevNode = prevNode.Next;
                i++;
            }
            Size--;

            return deletedNode;
        }
    }
}