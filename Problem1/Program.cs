using System;
using EulerProblemsNS;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            EulerProblemsNS.Problem1 problem1 = new EulerProblemsNS.Problem1();
            int actualValueBelow10 = problem1.sumOfNumbersBelowValue(10);
            Console.WriteLine("Sum of numbers below 10: " + actualValueBelow10);
            int actualValueBelow1000 = problem1.sumOfNumbersBelowValue(1000);
            Console.WriteLine("Sum of numbers below 1000: " + actualValueBelow1000);

        }
    }
}
