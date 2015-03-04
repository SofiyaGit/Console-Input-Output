using System;

//Problem 8. Numbers from 1 to n
namespace NumbersFromOneToN
{
    class Numbers
    {
        static void Main(string[] args)
        {

            Console.Write("Enter n  : ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
