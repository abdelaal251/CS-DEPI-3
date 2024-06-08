using System;

namespace GradeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            string[] subjects = { "Physics", "Chemistry", "Biology", "Mathematics", "Computer" };

            Console.WriteLine("Enter marks for the following subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{subjects[i]}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }

            double percentage = (total / 500.0) * 100;

            // Validate percentage
            if (percentage > 100 || percentage < 0)
            {
                Console.WriteLine("Error: Percentage cannot be greater than 100 or less than 0.");
                Console.WriteLine("Please recheck your entered values and try again!");
                return;
            }

            string grade;

            if (percentage >= 90) grade = "A";
            else if (percentage >= 80) grade = "B";
            else if (percentage >= 70) grade = "C";
            else if (percentage >= 60) grade = "D";
            else if (percentage >= 40) grade = "E";
            else grade = "F";

            Console.WriteLine($"Percentage = {percentage}%");
            Console.WriteLine($"Grade = {grade}");
        }
    }
}
