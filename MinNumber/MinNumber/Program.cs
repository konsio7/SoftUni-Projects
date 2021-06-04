using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int i = 0;

            for(i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
