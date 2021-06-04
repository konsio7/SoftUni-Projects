using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            var regex = new Regex(@"(?<tag>\*|\@)([A-Z][a-z]{2,})(\k<tag>): \[[A-Za-z]\]\|\[[A-Za-z]\]\|\[[A-Za-z]\]\|$");

            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    input = regex.Match(input).ToString();

                    string[] inputArray = input.Split()
                        .ToArray();

                    string word = inputArray[0];

                    string letters = inputArray[1];

                    if (word.Contains('*'))
                    {
                        word = word.Replace("*", "");
                    }
                    else if (word.Contains('@'))
                    {
                        word = word.Replace("@", "");
                    }

                    var lettersChar = new List<char>();

                    for (int j = 0; j < letters.Length; j++)
                    {
                        if ((letters[j] >= 'a' && letters[j] <= 'z') || (letters[j] >= 'A' && letters[j] <= 'Z'))
                        {
                            lettersChar.Add(letters[j]);
                        }
                    }

                    Console.WriteLine($"{word} {(int)lettersChar[0]} {(int)lettersChar[1]} {(int)lettersChar[2]}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
