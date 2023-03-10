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
            Console.WriteLine("In-Order Traversal:");
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
            Console.WriteLine($"[{string.Join(", ", _treeValues)}]");
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

        public void PreOrder()
        {
            Console.WriteLine("Pre-Order Traversal");
            _treeValues = new List<T>();
            preOrder(this.Root);
        }

        private void preOrder(Node<T> tempRoot){
            if(tempRoot is not null){
                _treeValues.Add(tempRoot.Value);
                preOrder(tempRoot.Left);
                preOrder(tempRoot.Right);
            }
        }

        public void PostOrder()
        {
            Console.WriteLine("Post-Order Traversal: ");
            _treeValues= new List<T>();
            postOrder(this.Root);
        }

        private void postOrder(Node<T> tempRoot){
            if(tempRoot is not null){
                postOrder(tempRoot.Left);
                postOrder(tempRoot.Right);
                _treeValues.Add(tempRoot.Value);
            }
        }

        public void LevelOrder()
        {
            Console.WriteLine("Level-Order Traversal");
            _treeValues = new List<T>();
            Queue<Node<T>> nodes = new Queue<Node<T>>();
            Node<T> tempNode = this.Root;
            _treeValues.Add(tempNode.Value);
            nodes.Enqueue(tempNode);
            while (!(nodes.Count == 0)){
                tempNode = nodes.Dequeue();
                if(tempNode.Left is not null){
                    _treeValues.Add(tempNode.Left.Value);
                    nodes.Enqueue(tempNode.Left);
                }
                if(tempNode.Right is not null){
                    _treeValues.Add(tempNode.Right.Value);
                    nodes.Enqueue(tempNode.Right);
                }
            }
        }


        public Node<T> Search(T value)
        {
            Node<T> tempRoot = this.Root;
            while(tempRoot is not null){
                if(value.Equals(tempRoot.Value)){
                    return tempRoot;
                }else if(value.CompareTo(tempRoot.Value) < 0){
                    tempRoot = tempRoot.Left;
                }else if(value.CompareTo(tempRoot.Value) > 0){
                    tempRoot =tempRoot.Right;
                }
            }

            return null;
        }
    }
}