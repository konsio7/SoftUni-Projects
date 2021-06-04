using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Goal 1 -> area
            /// Goal 2 -> perimeter
            
            /// from console -> radius
            /// area => Pi * r * r
            /// perimeter => 2 * Pi * r

            /// Pi -> 3.14
            double Pi = Math.PI;

            double r = double.Parse(Console.ReadLine());

            double area = Pi * r * r;

            double perimeter = 2 * Pi * r;

            Console.WriteLine("{0:F2}",area);
            Console.WriteLine("{0:F2}",perimeter);
        }
    }
}
