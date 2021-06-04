using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string winner = string.Empty;

            while (true)
            {
                string name = Console.ReadLine();
                if(name == "STOP")
                {
                    Console.WriteLine($"Winner is {winner} - {max}!");
                    break;
                }
                int sum = 0;
                for(int i = 0; i < name.Length; i++)
                {
                    int letter = name[i];
                    sum += letter;
                }
                if(sum > max)
                {
                    max = sum;
                    winner = name;
                }
            }
        }
    }
}
