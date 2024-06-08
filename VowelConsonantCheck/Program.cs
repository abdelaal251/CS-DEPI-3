using System;

namespace VowelConsonantCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if ("aeiou".Contains(ch))  // contains is a method for the string to search inside their charachters
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
