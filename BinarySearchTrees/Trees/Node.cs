using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTrees.Trees
{
    public class Node<T>
    {
        public T Value {get;set;}
        public Node<T> Left{get;set;}
        public Node<T> Right{get;set;}

        public Node(T value){
            this.Value = value;
            this.Left = this.Right = null;
        }

        public Node(T value, Node<T> left, Node<T> right){
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
}