using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    //create head node
    //create tail node
    //create size
    public class LList<T> where T: IComparable
    {
        public int Size {get;set;} = 0;
        public Node<T> Head {get;set;} = null;
        public Node<T> Tail {get;set;} = null;

        public LList() {}
        public LList(T value){
            insertAddBeginning(value);
        }

        //if head is empty add to head 
        //if head has value add to current tail.next, and set tail to the new node
        //incerement size value
        public void Append(T value){
            Node<T> CurrentNode = new Node<T>(value);
            if(Head == null){
                Head = CurrentNode;
                Tail = CurrentNode;
            }else{
                Tail.Next = CurrentNode;
            }
            Tail = CurrentNode;
            Size++;
        }

        public T[] ToArray(){
            T[] values = new T[Size];
            Node<T> currentNode = Head;
            int index = 0;
            while(currentNode != null){
                values[index] = currentNode.Data;
                currentNode = currentNode.Next;
                index++;
            }
            return values;
        }

        public void Display(){
            T[] values = ToArray();
            Console.WriteLine(String.Join(" ", values));
        }

        public void Prepend(T value){
            insertAddBeginning(value);
        }

        private void insertAddBeginning(T value){
            Node<T> currentNode = new Node<T>(value); 
            if(Head == null){
                Head = currentNode;
                Tail = currentNode;
            }else{
                currentNode.Next = Head;
                Head = currentNode;
            }
            Size++;
        }

        // get to the index;
        //save previous index; 
        // save current index;
        
        public void InsertAtIndex(int index, T value){
            if(index > Size){
                throw new IndexOutOfRangeException("Index Out of Range");
            }

            if(index == 0){
                insertAddBeginning(value);
                return;
            }

            Node<T> newestNode = new Node<T>(value);
            Node<T> prevNode = Head;
            Node<T> currentNode = Head.Next;

            for(int i = 1; i < Size; i++){
                if(i == index){
                    prevNode.Next = newestNode;
                    newestNode.Next = currentNode;
                    Size++;
                    break;
                }else{
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }

        }

        public void DeleteAtIndex(int index){
            if(index == 0){
                Head = Head.Next;
                Size--;
                return;
            }
            var Values = findAtIndex(index);
            Values.PreviousNode.Next = Values.CurrentNode.Next;
            Size--;
        }
        /// <summary>
        /// Searches the Linked list and returns the node that matches the value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Node<T></returns>
        public Node<T> Find(T value){
            Node<T> currentNode = Head;
            while(currentNode != null){
                if(value.Equals(currentNode.Data)){
                    break;
                }
                currentNode= currentNode.Next;
            }

            if(currentNode == null){
                throw new Exception("Node Not Found");
            }

            return currentNode;
        }

        public void InsertSorted(T value) {
            Node<T> NewestNode = new Node<T>(value);
            if(Head == null){
                insertAddBeginning(value);
            }else{
                Node<T> currentNode =Head;
                Node<T> prevNode =Head;
                while(currentNode != null && (currentNode.Data.CompareTo(value) < 0)){ // if currentNode is not null and the value is less than the newly added value
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                }

                if(currentNode==Head){
                    NewestNode.Next = Head;
                    Head = NewestNode;
                }else{
                    NewestNode.Next = prevNode.Next;
                    prevNode.Next = NewestNode;
                }

                Size++;
            }
        }

        public T FindAtIndex(int index= 0){
            if(index > Size){
                throw new IndexOutOfRangeException("Index out of Bounds");
            }
            var result = findAtIndex(index);
            return result.CurrentNode.Data;
        }

        private (Node<T> CurrentNode, Node<T> PreviousNode) findAtIndex(int index){
            Node<T> prevNode = Head;
            Node<T> currentNode = Head;
            int i = 0;
            do{
                if(i == index){
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                i++;
            }while (i < index);
            var result = (CurrentNode: currentNode, PreviousNode: prevNode);

            return result;
        }
    }
}