using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int startingHeight = goal - 30;
            int currentJump = int.Parse(Console.ReadLine());
            int failedJumpsCounter = 0;
            int jumpsCounter = 1;


            while(currentJump <= goal)
            {
                if(currentJump > startingHeight)
                {
                    startingHeight += 5;
                    failedJumpsCounter = 0;
                }
                else
                {
                    failedJumpsCounter++;
                    if(failedJumpsCounter == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startingHeight}cm after {jumpsCounter} jumps.");
                        break;
                    }
                }
                currentJump = int.Parse(Console.ReadLine());
                jumpsCounter++;
            }
            if(currentJump > goal)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {goal}cm after {jumpsCounter} jumps.");
            }

        }
    }
}
