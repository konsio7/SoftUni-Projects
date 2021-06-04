using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = (hallLength * 100) * (hallWidth * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchArea = hallArea / 10;

            double freespace = hallArea - (wardrobeArea + benchArea);

            double dancersCount = Math.Floor(freespace / (40 + 7000));

            Console.WriteLine(dancersCount);
        }
    }
}
