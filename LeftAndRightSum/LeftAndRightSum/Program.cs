﻿using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int i = 0;

            for(i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }

            for(i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }

            int diff = Math.Abs(leftSum - rightSum);
            if(diff == 0)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
