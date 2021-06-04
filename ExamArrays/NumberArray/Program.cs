using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            int sum = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArray = input.Split()
                    .ToArray();

                if (inputArray[0] == "Switch")
                {
                    if (int.Parse(inputArray[1]) <= numbers.Count && int.Parse(inputArray[1]) >= 0)
                    {
                        int index = int.Parse(inputArray[1]);
                        numbers[index] *= -1;
                    }
                }
                else if (inputArray[0] == "Change")
                {
                    if (int.Parse(inputArray[1]) <= numbers.Count && int.Parse(inputArray[1]) >= 0)
                    {
                        int index = int.Parse(inputArray[1]);
                        numbers[index] = int.Parse(inputArray[2]);
                    }
                }
                else if (input == "Sum Negative")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < 0)
                        {
                            sum += numbers[i];
                        }
                    }
                    Console.WriteLine(sum);
                }
                else if (input == "Sum Positive")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > 0)
                        {
                            sum += numbers[i];
                        }
                    }
                    Console.WriteLine(sum);
                }
                else if (input == "Sum All")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
            }

            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
    }
}
