using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;

            for(i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);

        }
    }
}
