using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysCounter = 0;

            while(ownedMoney < neededMoney && spendCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if(command == "spend")
                {
                    ownedMoney -= money;
                    if(ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                    spendCounter++;
                }
                else if(command == "save")
                {
                    ownedMoney += money;
                }

                if (spendCounter == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(daysCounter);
                }
            }            

            if(ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
