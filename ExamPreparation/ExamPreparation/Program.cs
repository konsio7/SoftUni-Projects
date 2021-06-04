using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            int countPoorGrades = 0;
            int sumGrades = 0;
            int countTasks = 0;
            string lastTask = string.Empty;

            while(task != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                countTasks++;
                if(grade <= 4)
                {
                    countPoorGrades++;
                }

                if(countPoorGrades == maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
                    break;
                }
                lastTask = task;
                task = Console.ReadLine();
            }

            double average = sumGrades * 1.0 / countTasks;

            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {countTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
