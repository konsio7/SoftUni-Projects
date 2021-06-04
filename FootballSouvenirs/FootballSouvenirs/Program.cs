using System;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int souvenirsBought = int.Parse(Console.ReadLine());
            double souvenirPrice = 0;

            switch(team)
            {
                case "Argentina":
                    switch(souvenir)
                    {
                        case "flags":
                            souvenirPrice = 3.25;
                            break;
                        case "caps":
                            souvenirPrice = 7.20;
                            break;
                        case "posters":
                            souvenirPrice = 5.10;
                            break;
                        case "stickers":
                            souvenirPrice = 1.25;
                            break;
                    }
                    break;
                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 4.20;
                            break;
                        case "caps":
                            souvenirPrice = 8.50;
                            break;
                        case "posters":
                            souvenirPrice = 5.35;
                            break;
                        case "stickers":
                            souvenirPrice = 1.20;
                            break;
                    }
                    break;
                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 2.75;
                            break;
                        case "caps":
                            souvenirPrice = 6.90;
                            break;
                        case "posters":
                            souvenirPrice = 4.95;
                            break;
                        case "stickers":
                            souvenirPrice = 1.10;
                            break;
                    }
                    break;
                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags":
                            souvenirPrice = 3.10;
                            break;
                        case "caps":
                            souvenirPrice = 6.50;
                            break;
                        case "posters":
                            souvenirPrice = 4.80;
                            break;
                        case "stickers":
                            souvenirPrice = 0.90;
                            break;
                    }
                    break;
            }

            double totalPrice = souvenirsBought * souvenirPrice;

            if(team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                if(souvenir == "flags" || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
                {
                    Console.WriteLine($"Pepi bought {souvenirsBought} {souvenir} of {team} for {totalPrice:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
