using System;
using System.Data;
using System.Globalization;
using System.Threading;

//Problem 5. Formatting Numbers
namespace FormattingNumbers
{
    class FormatNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter a 0<a<500 :");

            int a = int.Parse(Console.ReadLine());

            string HexA = a.ToString("X");

            string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("Enter b  : ");

            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c : ");

            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0,12}|{1,10}|{2,10}|","a","b","c"));

            Console.WriteLine(String.Format("{0,-2}|{1,-8}|{2,10:F2}|{2,-10:F3}|", HexA, binaryA, numberA, numberB));
        }
    }
}
