using System;

namespace TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int firstSymbol = 'B'; firstSymbol <= 'L'; firstSymbol += 2)
            {
                for(int secondSymbol = 'f'; secondSymbol >= 'a'; secondSymbol--)
                {
                    for(int thirdSymbol = 'A'; thirdSymbol <= 'C'; thirdSymbol++)
                    {
                        for(int fourthSymbol = 1; fourthSymbol <= 10; fourthSymbol++)
                        {
                            for(int fifthSymbol = 10; fifthSymbol >= 1; fifthSymbol--)
                            {
                                counter++;
                                if(counter == n)
                                {
                                    Console.WriteLine($"Ticket combination: {(char)firstSymbol}{(char)secondSymbol}{(char)thirdSymbol}{fourthSymbol}{fifthSymbol}");
                                    int prize = firstSymbol + secondSymbol + thirdSymbol + fourthSymbol + fifthSymbol;
                                    Console.WriteLine($"Prize: {prize} lv.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
