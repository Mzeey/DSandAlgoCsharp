using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuesDS
{
    //Must Have Head
    //Must have Next
    public class Node<T>
    {
        private T _data;
        
        public T Data{
            get{ return _data;}
            set{_data = value;}
        }
        public Node<T> Next {get;set;}

        public Node(T value, Node<T> next){
            _data = value;
            Next = next;
        }

        public Node(T value){
            _data = value;
            Next = null;
        }
    }
}