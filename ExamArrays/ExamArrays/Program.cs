using System;

namespace ExamArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double stepInCentimeters = double.Parse(Console.ReadLine());
            int totalDistance = int.Parse(Console.ReadLine());

            int distanceInCentimeters = totalDistance * 100;

            double fifthStep = stepInCentimeters - (stepInCentimeters * 0.3);

            double distanceTravelled = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    distanceTravelled += fifthStep;
                }
                if (i % 5 != 0)
                {
                    distanceTravelled += stepInCentimeters;
                }
            }

            double finalDistance = distanceTravelled / 100;

            double distancePercentage = ((distanceTravelled * 1.00) / (totalDistance * 1.00));

            Console.WriteLine($"You travelled {distancePercentage:F2}% of the distance!");
        }
    }
}
