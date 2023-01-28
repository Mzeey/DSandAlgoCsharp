using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    public class Factorial
    {

        public int NFactorialIterative(int n){
            int factorial = 1;
            for(int i =1; i <= n; i++){
                factorial = factorial * i;
            }
            return factorial;
        }   

        public int NFactorialRecursion(int n){
            if(n == 1){
                return n;
            }
            return NFactorialRecursion(n-1) * n;
        }
    }
}