using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int countPoor = 0;
            int countGood = 0;
            int countVeryGood = 0;
            int countExcellent = 0;

            double sum = 0;

            for(int i = 1; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;

                if(grade < 3)
                {
                    countPoor++;
                }
                else if(grade >= 3 && grade < 4)
                {
                    countGood++;
                }
                else if(grade >= 4 && grade < 5)
                {
                    countVeryGood++;
                }
                else if(grade >= 5)
                {
                    countExcellent++;
                }
            }
            double percentPoor = (countPoor * 1.0 / students) * 100;
            double percentGood = (countGood * 1.0 / students) * 100;
            double percentVeryGood = (countVeryGood * 1.0 / students) * 100;
            double percentExcellent = (countExcellent * 1.0 / students) * 100;
            double average = sum / students;

            Console.WriteLine($"Top students: {percentExcellent:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentVeryGood:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentGood:F2}%");
            Console.WriteLine($"Fail: {percentPoor:F2}%");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}
