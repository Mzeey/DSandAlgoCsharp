using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StacksDS
{
    public class Stack<T>
    {
        T[] Data {get;set;}
        private int _topIndex;

        public Stack(int size){
            this.Data = new T[size];
            this._topIndex = 0;
        }

        public int GetLength(){
            return _topIndex;
        }

        public bool IsEmpty(){
            return this._topIndex ==0;
        }

        public bool IsFull(){
            return _topIndex == this.Data.Length;
        }

        public void Push(T value){
            if(this.IsFull()){
                throw new StackOverflowException("The Stack is full");
            }

            this.Data[_topIndex] =  value;
            _topIndex++;
        }

        public T Pop(){
            if(this.IsEmpty()){
                throw new Exception("Stack is empty");
            }

            T poppedValue = this.Data[this._topIndex -1];
            this._topIndex--;
            return poppedValue;
        }

        public T Peek(){
            if(this.IsEmpty()){
                throw new Exception("Stack is empty");
            }
            return this.Data[this._topIndex -1];
        }

        public void Display(){
            for(int i=0; i < _topIndex; i++){
                Console.Write(this.Data[i] + "--");
            }
            Console.WriteLine();
        }
    }
}