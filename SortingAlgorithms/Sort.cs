using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Sort
    {
        public void SelectionSort(int[] A, int n){
            for(int i = 0; i < n-1; i++){
                int position = i;
                for(int j = i+1; j< n; j++){
                    if(A[j] < A[position]){
                        position = j;
                    }
                }
                swap(A, i, position);
            }
        }

        // n(o^2)
        public void InsersionSort(int[] A, int n){
            for (int i = 1; i < n; i++){ 
                int currentValue = A[i];
                int position = i;
                while( position > 0 && A[position-1] > currentValue){
                    swap(A, position, position-1);
                    position = position -1;
                }
            }
        }

        public void BubbleSort(int[] A, int n){
            int i = 1;
            while(n > 0){
                for(i =0; i < n -1; i++ ){
                    if(A[i+1] < A[i]){
                        swap(A,i, i+1);
                    }
                }
                n = n-1;
            }
        }

        private void swap(int[] A, int i, int position){
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        }

        public void Display(int[] A){
            string result = "";
            foreach(var item in A){
                result += (item  + " ");
            }
            Console.WriteLine(result);
        }
    }
}