using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class SumOfNumbers
    {
        public int SumN(int n){

            return n* (n + 1) /2;
        }

        public int SumNIteration(int n){
            int total = 0;
            int i =1;
            while (i <= n){
                total = total + i;
                i = i+ 1;
            }
            return total;
        }

        public int SumNRecursion(int n){
            if(n == 0){
                return n;
            }
            return SumNRecursion(n -1) + n;
        }
    }
}