using System;

namespace ConvertInchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            /// read inches from console
            double inches = double.Parse(Console.ReadLine());

            double convertRatio = 2.54;

            /// convert to cm
            double centimeters = inches * convertRatio;

            /// write to console
            Console.WriteLine("{0:F2}",centimeters);
        }
    }
}
