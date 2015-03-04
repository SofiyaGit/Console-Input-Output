using System;

//Problem 1. Sum of 3 Numbers
namespace SumOfThreeNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a  : ");

            float numberA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");

            float numberB = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter c : ");

            float numberC = float.Parse(Console.ReadLine());

            float amount = numberA + numberB + numberC;

            Console.WriteLine(amount);
        }
    }
}
