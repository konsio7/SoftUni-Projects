using System;

namespace IsGradeExcellent
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            double lowestExcellentGradevalue = 5.5;
            bool isGradeExcellent = grade >= lowestExcellentGradevalue;

            if (isGradeExcellent)
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}
