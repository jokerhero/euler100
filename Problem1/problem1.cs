/*
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
*/
using System;

namespace EulerProblemsNS
{
    class Problem1
    {
        public int sumOfNumbersThatAreDivisibleBy3Or5BelowValueBruteForce(int MaxValue)
        {
            int numberToReturn = 0;
            for(int i=1; i<MaxValue; i++){
                if((i%3 == 0) || (i%5 == 0)){
                    numberToReturn += i;
                }
            }
            return numberToReturn;
        }
    }
}