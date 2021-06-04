using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            if(month == "May" || month == "October")
            {
                studioPrice = days * 50;
                apartmentPrice = days * 65;
            }
            else if(month == "June" || month == "September")
            {
                studioPrice = days * 75.2;
                apartmentPrice = days * 68.7;
            }
            else if(month == "July" || month == "August")
            {
                studioPrice = days * 76;
                apartmentPrice = days * 77;
            }

            if(days > 14)
            {
                apartmentPrice = apartmentPrice - (0.1 * apartmentPrice);
            }

            if (month == "May" || month == "October")
            {
                if(days > 7 && days < 14)
                {
                    studioPrice = studioPrice - (0.05 * studioPrice);
                }
                else if(days > 14)
                {
                    studioPrice = studioPrice - (0.3 * studioPrice);
                }
            }
            else if(month == "June" || month == "Septmber")
            {
                if(days > 14)
                {
                    studioPrice = studioPrice - (0.2 * studioPrice);
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
