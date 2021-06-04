using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                string[] inputArray = input.Split()
                    .ToArray();

                if (inputArray[0] == "Add")
                {
                    if (contacts.Contains(inputArray[1]))
                    {
                        int index = int.Parse(inputArray[2]);
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, inputArray[1]);
                        }
                    }
                    else
                    {
                        contacts.Add(inputArray[1]);
                    }
                }
                else if (inputArray[0] == "Remove")
                {
                    int index = int.Parse(inputArray[1]);
                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (inputArray[0] == "Export")
                {
                    int startingIndex = int.Parse(inputArray[1]);
                    int count = int.Parse(inputArray[2]);

                    Console.WriteLine();

                    for (int i = 0; i < count; i++)
                    {
                        if (count - startingIndex >= 0 && startingIndex >= 0 && startingIndex < contacts.Count)
                        {
                            Console.Write($"{contacts[startingIndex]}");
                            if (i < count - 1)
                            {
                                Console.Write(" ");
                            }
                            startingIndex += 1;
                        }
                    }
                    Console.WriteLine();
                }
                else if (input == "Print Normal")
                {
                    Console.WriteLine("Contacts: " + string.Join(" ", contacts));
                    break;
                }
                else if (input == "Print Reversed")
                {
                    contacts.Reverse();
                    Console.WriteLine("Contacts: " + string.Join(" ", contacts));
                    break;
                }
            }
        }
    }
}
