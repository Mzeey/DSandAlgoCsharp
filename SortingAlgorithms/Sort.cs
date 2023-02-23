using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Sort
    {
        public void SelectionSort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position])
                    {
                        position = j;
                    }
                }
                swap(A, i, position);
            }
        }

        // n(o^2)
        public void InsersionSort(int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int currentValue = A[i];
                int position = i;
                while (position > 0 && A[position - 1] > currentValue)
                {
                    swap(A, position, position - 1);
                    position = position - 1;
                }
            }
        }

        public void BubbleSort(int[] A, int n)
        {
            int i = 1;
            while (n > 0)
            {
                for (i = 0; i < n - 1; i++)
                {
                    if (A[i + 1] < A[i])
                    {
                        swap(A, i, i + 1);
                    }
                }
                n = n - 1;
            }
        }

        public void ShellSort(int[] A, int n)
        {
            int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i];
                    int j = i - gap;
                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp;
                    i = i + 1;
                }

                gap = gap / 2;
            }
        }

        public void MergeSort(int[] A, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                MergeSort(A, leftIndex, midIndex); //Splitting of the left halves of the array till it's lowest from
                MergeSort(A, midIndex + 1, rightIndex); //Splitting of the right halves of the array till it's lowest from
                merge(A, leftIndex, midIndex, rightIndex);
            }
        }

        public void QuickSort(int[] A, int lowIndex, int highIndex){
            if(lowIndex < highIndex){
                int partionIndex = partition(A, lowIndex, highIndex);
                QuickSort(A, lowIndex, partionIndex - 1);
                QuickSort(A, partionIndex+1, highIndex);
            }
        }

        private int partition(int[] A,int lowIndex, int highIndex){
            int pivoteValue = A[lowIndex];
            int i = lowIndex+1;
            int j = highIndex;
            do{
                while(i <=j && A[i] <= pivoteValue){
                    i = i+1;
                }
                while(i<=j && A[j]> pivoteValue){
                    j=j - 1;
                }
                if(i <=j){
                    swap(A, i, j);
                }
            }while(i<j);
            swap(A, lowIndex, j);
            return j;
        }

        private void merge(int[] A, int leftIndex, int midIndex, int rightIndex)
        {
            int leftArrayIndex = leftIndex;
            int rightArrayIndex = midIndex + 1;
            int currentIndex = leftIndex;
            int[] MergedArray = new int[rightIndex + 1];
            while (leftArrayIndex <= midIndex && rightArrayIndex <= rightIndex)
            {
                if (A[leftArrayIndex] < A[rightArrayIndex])
                {
                    MergedArray[currentIndex] = A[leftArrayIndex];
                    leftArrayIndex++;
                }
                else
                {
                    MergedArray[currentIndex] = A[rightArrayIndex];
                    rightArrayIndex++;
                }
                currentIndex++;
            }

            while (leftArrayIndex <= midIndex)
            {
                MergedArray[currentIndex] = A[leftArrayIndex];
                leftArrayIndex++;
                currentIndex++;
            }

            while (rightArrayIndex <= rightIndex)
            {
                MergedArray[currentIndex] = A[rightArrayIndex];
                rightArrayIndex++;
                currentIndex++;
            }

            for(int x = leftIndex; x <= rightIndex; x++){
                A[x] = MergedArray[x];
            }
        }

        private void swap(int[] A, int i, int position)
        {
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        }

        public void Display(int[] A)
        {
            string result = String.Join(' ', A);
            Console.WriteLine(result);
        }
    }
}