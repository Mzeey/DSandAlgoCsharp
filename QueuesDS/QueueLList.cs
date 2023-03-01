using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    public class QueueLList<T> : IQueue<T>
    {
        private Node<T> _front;
        private Node<T> _rear;
        private int _length;
        public QueueLList(){
            _front = null;
            _rear = null;
            _length = 0;
        }
        public T Dequeue()
        {
            if(IsEmpty()){
                throw new Exception("The Queue is Empty");
            }
            Node<T> element = _front;
            _front = _front.Next;
            _length--;
            if(IsEmpty()){
                _rear = null;
            }

            return element.Data;
        }

        public void Display()
        {
            string result = "";
            Node<T> currentNode = _front;
            while(currentNode!= null){
                result += $"{currentNode.Data} -->";
                currentNode = currentNode.Next;
            }
            Console.WriteLine(result);
        }

        public void Enqueue(T value)
        {
            Node<T> newestNode = new Node<T>(value);
            if(IsEmpty()){
                _front = newestNode;
            }else{
                _rear.Next = newestNode;
            }
            _rear = newestNode;
            _length++;
        }

        public T First()
        {
            if(IsEmpty()){
                throw new Exception("The Queue is Empty");
            }
            return _front.Data;
        }

        public int getLength()
        {
            return _length;
        }

        public bool IsEmpty()
        {
            return (_length == 0)? true: false;
        }

        public bool IsFull()
        {
            return false;
        }
    }
}