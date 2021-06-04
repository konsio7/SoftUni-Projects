using System;

namespace SquareAreaDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /// get square side size
            double squareSide = double.Parse(Console.ReadLine());
            /// 10 => 10.0

            /// calculate area
            double squareArea = squareSide * squareSide;
            /// 10.0 =>10
            /// 10.3 => 10

            /// write to console
            Console.WriteLine(squareArea);
        }
    }
}
