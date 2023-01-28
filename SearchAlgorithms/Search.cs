using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Search
    {
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

        //O(n) time for computation
    }
}