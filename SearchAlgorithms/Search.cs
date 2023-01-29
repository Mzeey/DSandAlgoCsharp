using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Search
    {
        //O(n) time for computation
        public int LinearSearch(int[] array, int n, int key){
            int index = 0; //1
            while (index < n){ //n+1
                if(array[index] == key){ //n
                    return index; //1
                }
                index++;//n
            }
            return -1; //1
        }

        //O(log(n))
        public int BinaryIterative(int[] array, int n, int key){
            int left = 0; // 1
            int right = n-1; // 1
            while (left <= right){ // n/2 = log(n)
                int mid = (left + right) /2;
                if(key == array[mid]){
                    return mid;
                }else if(key < array[mid]){
                    right = mid -1;
                }else{
                    left = mid + 1;
                }
            }
            return -1; //1
        }

        public int BinaryRecursive(int[] array, int key, int left, int right){
            if(left > right){
                return -1;
            }
            int mid = (left + right)/2;
            if(array[mid] == key){
                return mid;
            }else if(key < array[mid]){
                return BinaryRecursive(array, key, left, mid-1);
            }else{
                return BinaryRecursive(array, key, mid+1, right);
            }
            
        }
    }
}