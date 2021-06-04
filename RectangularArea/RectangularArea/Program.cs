using System;

namespace RectangularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            /// read from console
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            /// calculate
            int area = a * b;

            /// write to console
            Console.WriteLine(area);
        }
    }
}
