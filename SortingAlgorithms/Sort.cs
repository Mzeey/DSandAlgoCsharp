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