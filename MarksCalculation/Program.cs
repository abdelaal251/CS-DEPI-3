using System;

namespace MarksCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter marks of five subjects:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average marks = {average}");
            Console.WriteLine($"Percentage = {percentage}");
        }
    }
}
