using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTrees.Trees.Interfaces
{
    public interface IBinarySearchTree<T>
    {
        Node<T> Root {get;set;}

        void Insert(T value);
        void RecursiveInsert(T value);

        Node<T> Search(T value);

        void InOrder();
        void PreOrder();
        void PostOrder();
        void LevelOrder();
        void Display();
    }
}