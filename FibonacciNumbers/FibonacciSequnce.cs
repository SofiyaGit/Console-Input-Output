using System;
using System.Globalization;
using System.Threading;

//Problem 10. Fibonacci Numbers
namespace FibonacciNumbers
{
    class FibonacciSequnce
    {
        static void Main(string[] args)
        {

            int firstNumber = 0;

            int secondNumber = 1;

            int amount = 0;

            Console.WriteLine("Enter n numbers : ");

            int length = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(firstNumber);

            Console.WriteLine(secondNumber);


            for (int i = 0; i < length-2; i++)
            {
                amount = firstNumber + secondNumber;

                Console.WriteLine(amount);

                firstNumber = secondNumber;

                secondNumber = amount;
            }

           
        }
    }
}
