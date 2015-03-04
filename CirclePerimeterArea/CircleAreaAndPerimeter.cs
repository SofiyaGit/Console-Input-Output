using System;

//Problem 3. Circle Perimeter and Area
namespace CirclePerimeterArea
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter r  : ");

            double radius = double.Parse(Console.ReadLine());

            double area = 3.14 * Math.Pow(radius, 2);

            double perimeter = 2 * 3.14 * radius;

            Console.WriteLine("The area is : {0}", area);

            Console.WriteLine("The perimeter is : {0}", perimeter);
        }
    }
}
