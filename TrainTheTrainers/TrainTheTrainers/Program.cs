using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJury = int.Parse(Console.ReadLine());

            string presentation = Console.ReadLine();
            double sumAllGrades = 0;
            int countAllGrades = 0;

            while(presentation != "Finish")
            {
                double sum = 0;
                for (int i = 1; 1 <= countJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;

                    sumAllGrades += grade;
                    countAllGrades++;
                }
                double average = sum / countJury;
                Console.WriteLine($"{presentation} - {average:F2}.");


                presentation = Console.ReadLine();
            }
            double averageAllGrades = sumAllGrades / countAllGrades;
            Console.WriteLine($"Student's final assessmet is {averageAllGrades:F2}.");
        }
    }
}
