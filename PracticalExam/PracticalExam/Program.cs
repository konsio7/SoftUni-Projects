using System;
using System.Linq;

namespace PracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] inputArray = input.Split()
                    .ToArray();

                string command = inputArray[0];

                if (command == "Change")
                {
                    string charReplace = inputArray[1];
                    string replacement = inputArray[2];

                    text = text.Replace(charReplace, replacement);

                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    Console.WriteLine(text.Contains(inputArray[1]));
                }
                else if (command == "End")
                {
                    string lastWord = text.Split()
                        .Last();

                    if (inputArray[1] == lastWord)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();

                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    Console.WriteLine(text.IndexOf(inputArray[1]));
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(inputArray[1]);
                    int length = int.Parse(inputArray[2]);

                    text = text.Substring(startIndex, length);

                    Console.WriteLine(text);
                }
            }
        }
    }
}
