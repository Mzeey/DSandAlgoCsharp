using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    public class Queue<T> : IQueue<T>
    {
        private T[] _data;
        private int _front;
        private int _rear;
        
        private int _length;

        public Queue(int length){
            _data = new T[length];
            _length = _front = _rear = 0;
        }

        public T Dequeue()
        {
            if(IsEmpty()){
                throw new Exception("The Queue is empty");
            }
            _length--;
            T value = _data[_front];
            _front++;
            return value;
        }

        public void Enqueue(T value)
        {
            if (IsFull()){
                throw new Exception("The Queue is full");
            }
            _data[_rear] = value;
            _rear++;
            _length++;

        }

        public T First()
        {
            throw new NotImplementedException();
        }

        public int getLength()
        {
            return _length;
        }

        public bool IsEmpty()
        {
            return (_length == 0)? true: false;
        }

        public bool IsFull(){
            return (_length == _data.Length)? true : false;
        }

        public void Display(){
            string result = "";
            for(int i = 0; i < _length; i++){
                result += $"{_data[i]} --";
            }
            Console.WriteLine(result);
        }
    }
}