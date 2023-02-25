using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoublyLinkedListLearning
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node<T> Prev { get; set; } = null;

        public Node(T value){
            this.Data = value;
            this.Next = null;
            this.Prev =  null;
        }

        public Node(T value, Node<T> next){
            this.Data = value;
            this.Next = next;
            this.Prev =  null;
        }
        public Node(T value, Node<T> next, Node<T> prev){
            this.Data = value;
            this.Next = next;
            this.Prev =  prev;
        }
    }
}