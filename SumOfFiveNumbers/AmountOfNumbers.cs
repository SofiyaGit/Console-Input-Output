using System;
using System.Globalization;
using System.Threading;

//Problem 7. Sum of 5 Numbers
namespace SumOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter numbers  : ");

            string input = Console.ReadLine();

            float sum = 0;

            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += float.Parse(numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
