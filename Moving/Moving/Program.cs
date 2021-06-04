using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * length * height;
            int totalSpace = 0;
            int spaceDiff = 0;

            string command = Console.ReadLine();
            while(command != "Done")
            {
                int CartoonSpace = int.Parse(command);

                totalSpace += CartoonSpace;
                spaceDiff = Math.Abs(totalSpace - freeSpace);

                if(totalSpace >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceDiff} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if(command == "Done")
            {
                Console.WriteLine($"{spaceDiff} Cubic meters left.");
            }
        }
    }
}
