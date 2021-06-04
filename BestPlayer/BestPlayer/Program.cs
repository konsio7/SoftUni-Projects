using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxGoals = 0;
            int goalsScored = 0;
            string bestPlayer = string.Empty;

            while(name != "END")
            {
                goalsScored = int.Parse(Console.ReadLine());
                
                if(goalsScored > maxGoals)
                {
                    maxGoals = goalsScored;
                    bestPlayer = name;
                }
                if(goalsScored >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            if(maxGoals >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!"); 
            }
            else if(maxGoals < 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
            
        }
    }
}
