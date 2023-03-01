using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedListLearning;

namespace StacksDS
{
    public class StackLinkedList<T>
    {
        Node<T> Top {get; set;}
        private int _size;
        

        public StackLinkedList(){
            this.Top = null;
            _size = 0;
        }

        public int GetLength(){
            return this._size;
        }

        public bool IsEmpty(){
            return this._size == 0;
        }

        public void Push(T value){
            Node<T> newNode = new Node<T>(value);
            if(this.IsEmpty()){
                Top = newNode;
            }else{
                newNode.Next = Top;
                this.Top = newNode;
            }
            this._size++;
        }

        public T Pop(){
            
            if(this.IsEmpty()){
                throw new Exception("Stack is Empty");
            }
            Node<T> poppedNode = this.Top;
            this.Top = this.Top.Next;
            this._size--;
            return poppedNode.Data;
        }

        public T Peek(){
            if(this.IsEmpty()){
                throw new Exception("Stack is Empty");
            }
            Node<T> requiredNode = this.Top;
            return requiredNode.Data;
        }

        public void Display(){
            if(IsEmpty()){
                Console.WriteLine("The Stack is Empty");
                return;
            }
            var currentNode = Top;
            for(int i = 0; i < this._size; i++){
                Console.Write(currentNode.Data + "-->");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}