using System;

namespace NameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); /// Pesho
            string catNameOne = Console.ReadLine();
            string catNameTwo = Console.ReadLine();
            string dogNameOne = Console.ReadLine();
            string dogNameTwo = Console.ReadLine();
            Console.WriteLine("My name is " + name);
            Console.WriteLine("2 My name is {0} {1} {2}", name, catNameOne, dogNameOne);
            Console.WriteLine($"3 My name is {name} {catNameOne} {dogNameOne}");
            Console.WriteLine($"My name is {name} and I have cats and dogs, their names are: cat one - {catNameOne}, cat name two - {catNameTwo} and dog name one - {dogNameOne}, dog name two - {dogNameTwo}", name, catNameOne, catNameTwo, dogNameOne, dogNameTwo);
        }
    }
}
