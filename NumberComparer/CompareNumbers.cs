using System;

//Problem 4. Number Comparer
namespace NumberComparer
{
    class CompareNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a  : ");

            float numberA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");

            float numberB = float.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                Console.WriteLine("The greater is : {0}", numberA);
            }
            else
            {
                Console.WriteLine("The greater is : {0}", numberB);
            }
        }
    }
}
