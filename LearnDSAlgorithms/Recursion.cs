using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class Recursion
    {
        public void CalculateIterative(int n){
            while(n > 0){// n+1
                int k = n* n;//n
                Console.WriteLine(k);//1
                n = n-1; //1

                //time complexity is o(n+1)
                //which is o(n)
            }
        }

        public void CalculateRecursive(int n){
            if(n > 0){// this is the base condition that will terminate the recursive calls;
                int k = n*n;
                Console.WriteLine(k);
                CalculateRecursive(n-1);
            }
        }
    }
}