using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if(inputMetric == "mm")
            {
                value = value / 1000;
            }
            else if(inputMetric == "cm")
            {
                value = value / 100;
            }
            if(outputMetric == "mm")
            {
                value = value * 1000;
            }
            else if(outputMetric == "cm")
            {
                value = value * 100;
            }
            Console.WriteLine($"{value:F3}");
        }
    }
}
