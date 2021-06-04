﻿using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for(int thousands = a; thousands <= b; thousands++)
            {
                for (int hundreds = a; hundreds <= b; hundreds++)
                {
                    for (int tens = c; tens <= d; tens++)
                    {
                        for (int units = c; units <= d; units++)
                        {
                            bool equalSum = thousands + units == hundreds + tens;
                            bool thNotEqualToHun = thousands != hundreds;
                            bool tensNotEqualToUnits = tens != units;

                            if(equalSum && thNotEqualToHun && tensNotEqualToUnits)
                            {
                                Console.WriteLine($"{thousands}{hundreds}");
                                Console.WriteLine($"{tens}{units}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
