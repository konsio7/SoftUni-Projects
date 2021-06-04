using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int odd = 0;
            int even = 0;

            for(i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }

            }
            int diff = Math.Abs(odd - even);
            if(diff == 0)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
