using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHometown = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - weekendsInHometown;
            double saturdayGamesInSofia = weekendsInSofia * (3.0 / 4);

            double gamesDuringHolidays = holidays * (2.0 / 3);

            double totalGames = saturdayGamesInSofia + gamesDuringHolidays + weekendsInHometown;

            if(yearType == "leap")
            {
                totalGames = Math.Floor(totalGames + (0.15 * totalGames));
            }

            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
