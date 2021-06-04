﻿using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int first = 1; first < 9; first++)
            {
                for (int second = 1; second < 9; second++)
                {
                    for (int third = 1; third < 9; third++)
                    {
                        for (int fourth = 1; fourth < 9; fourth++)
                        {
                            bool check1 = n % first == 0;
                            bool check2 = n % second == 0;
                            bool check3 = n % third == 0;
                            bool check4 = n % fourth == 0;

                            if(check1 && check2 && check3 && check4)
                            {
                                Console.Write($"{first}{second}{third}{fourth} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
