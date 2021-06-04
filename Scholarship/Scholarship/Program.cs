using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrades = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            if(minimalSalary > income && averageGrades >= 4.50)
            {
                double scholarship = Math.Floor(0.35 * minimalSalary);
                Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
            }
            else if(averageGrades >= 5.50)
            {
                double scholarship = Math.Floor(averageGrades * 25);
                Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
