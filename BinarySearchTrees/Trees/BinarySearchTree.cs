using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinarySearchTrees.Trees.Interfaces;

namespace BinarySearchTrees.Trees
{
    public class BinarySearchTree<T> : IBinarySearchTree<T> where T:IComparable
    {
        public Node<T> Root { get; set; }
        private List<T> _treeValues = new List<T>();

        public BinarySearchTree(){
            this.Root = null;
        }

        public void Insert(T value)
        {
            insert(this.Root, value);
        }
        
        private void insert(Node<T> TempRoot, T value){
            Node<T> temp = null;
            while(TempRoot is not null){
                temp = TempRoot;
                if(temp.Value.Equals(value)){
                    throw new Exception("BinarySearch Tree Does not contain Duplicates");
                }else if(temp.Value.CompareTo(value) > 0){
                    TempRoot = TempRoot.Left;
                }else if(temp.Value.CompareTo(value) < 0){
                    TempRoot = TempRoot.Right;
                }
            }

            Node<T> newNode = new Node<T>(value);
            if(this.Root is not null){
                if(temp.Value.CompareTo(value) > 0){
                    temp.Left = newNode;
                }else{
                    temp.Right = newNode;
                }
            }else{
                this.Root = newNode;
            }
        }

        public void InOrder()
        {
            Console.WriteLine("Inorder Traversal:");
            this._treeValues = new List<T>();
            inOrder(this.Root);
        }

        private void inOrder(Node<T> tempRoot){
            if(tempRoot is not null){
                inOrder(tempRoot.Left);
                _treeValues.Add(tempRoot.Value);
                inOrder(tempRoot.Right);
            }
        }

        public void Display()
        {
            Console.WriteLine(string.Join(", ", _treeValues));
        }

        public void RecursiveInsert(T value)
        {
            if(this.Root is null){
                this.Root =  recursiveInsert(this.Root, value);
            }else{
                recursiveInsert(this.Root, value);
            }
            
        }

        private Node<T> recursiveInsert(Node<T> tempRoot, T value){
            if(tempRoot is not null){
                if(tempRoot.Value.CompareTo(value) > 0){ //if element at node is greater than new value
                    tempRoot.Left = recursiveInsert(tempRoot.Left, value);
                }else if(tempRoot.Value.CompareTo(value)<0){
                    tempRoot.Right = recursiveInsert(tempRoot.Right, value);
                }
            }else{
                Node<T> newNode = new Node<T>(value);
                tempRoot = newNode;
            }

            return tempRoot;
        }
    }
}