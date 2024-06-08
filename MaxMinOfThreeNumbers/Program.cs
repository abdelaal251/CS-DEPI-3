using System;

namespace MaxMinOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            // assign the maximum number to max, start with number 1 assuming it is the maximum
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            // assign the minimum number to min, start with number 1 assuming it is the minimum
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"The maximum number is: {max}");
            Console.WriteLine($"The minimum number is: {min}");
        }
    }
}
