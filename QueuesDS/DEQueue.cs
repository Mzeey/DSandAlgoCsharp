using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    public class DEQueue<T> : IDEQueue<T>
    {
        private int _length;
        private T[] _data;
        private T _first;
        private T _rear;
        public void AddFirst(T value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(T value)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public T First()
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T Last()
        {
            throw new NotImplementedException();
        }

        public T RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public T RemoveLast()
        {
            throw new NotImplementedException();
        }
    }
}