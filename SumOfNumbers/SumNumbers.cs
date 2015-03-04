using System;
using System.Globalization;
using System.Threading;

//Problem 9. Sum of n Numbers
namespace SumOfNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int sum = 0;

            Console.WriteLine("Enter n numbers : ");

            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            Console.WriteLine("Enter a numbers: ");

            for (int i = 0; i < length; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                sum += numbers[i];

                Console.WriteLine("The amount is : {0}", sum);
            }


        }
    }
}
