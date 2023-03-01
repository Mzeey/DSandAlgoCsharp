using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    public interface IDEQueue<T>
    {
        void AddFirst(T value);
        void AddLast(T value);
        void Display();
        T RemoveFirst();
        T RemoveLast();
        T First();
        T Last();
        int GetLength();

        bool IsEmpty();
        
    }
}