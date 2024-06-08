using System;

namespace PositiveNegativeZeroSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            switch (Math.Sign(number))
            {
                case 1:
                    Console.WriteLine("Positive");
                    break;
                case -1:
                    Console.WriteLine("Negative");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
            }
        }
    }
}
