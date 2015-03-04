using System;

//Problem 6. Quadratic Equation
namespace QuadraticEquation
{
    class Roots
    {
        static void Main()
        {   
            double x1;

            double x2;


            Console.WriteLine("Enter a  : ");

            float numberA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");

            float numberB = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter c : ");

            float numberC = float.Parse(Console.ReadLine());

            double discriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;

            if (discriminant > 0)
            {
                 x1 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);

                 x2 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);

                Console.WriteLine("x1 = {0}", x1);

                Console.WriteLine("x2 = {0}", x2);  
            }

            else
            {
                if (discriminant == 0)
                {
                    x1 = -numberB / (2 * numberA);

                    Console.WriteLine("One real root x1=x2 ={0}", x1);
                }

                else
                {
                    Console.WriteLine("No real roots");
                }
            }

        }
    }
}
