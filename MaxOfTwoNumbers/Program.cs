using System;

namespace MaxOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int max = (num1 > num2) ? num1 : num2;

            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}
