/*
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
*/
using System;
using System.Collections.Generic;

namespace EulerProblemsNS
{
    class Problem1
    {
        public int sumOfNumbersBelowValue(int MaxValue)
        {
            return addNumbersInSet(numbersToSum(MaxValue));
        }
        private int addNumbersInSet(HashSet<int> numbersToSum)
        {
            // Im assuming that we should return 0 if there are no values that are multiples of 3 or 5
            int valueToReturn = 0;
            foreach (int i in numbersToSum)
            {
                valueToReturn += i;
            }
            return valueToReturn;
        }
        private HashSet<int> numbersToSum(int MaxValue)
        {
            HashSet<int> numberSetToReturn = new HashSet<int>();
            // We care about numbers below the maxValue given per the problem description.
            if (MaxValue < 3)
            {
                return numberSetToReturn;
            }
            for (int i = 1; i < MaxValue; i++)
            {
                if (isMultipleOf3Or5(i))
                {
                    numberSetToReturn.Add(i);
                }
            }
            return numberSetToReturn;
        }
        private Boolean isMultipleOf3Or5(int numberToCheck)
        {
            if (numberToCheck % 3 == 0)
            {
                return true;
            }

            if (numberToCheck % 5 == 0)
            {
                return true;
            }

            return false;
        }
    }
}