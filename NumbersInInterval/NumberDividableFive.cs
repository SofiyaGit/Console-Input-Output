using System;

//Problem 11.* Numbers in Interval Dividable by Given Number
namespace NumbersInInterval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter start number : ");

            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end number : ");

            int endNumber = int.Parse(Console.ReadLine());

            int p = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                if ( i % 5 ==0)
                {
                    p++;
                    Console.Write("{0} ",i);
                }

                
            }
            Console.WriteLine();
            Console.WriteLine("p={0}", p);
        }
    }
}

