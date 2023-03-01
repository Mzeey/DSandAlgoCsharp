using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        void Display();
        T Dequeue();
        T First();
        int getLength();
        bool IsEmpty();
        bool IsFull();
        
    }
}