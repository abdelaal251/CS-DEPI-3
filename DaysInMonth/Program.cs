using System;

namespace DaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month number: ");
            int month = int.Parse(Console.ReadLine());

            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28; // if you want to get number of days in case of leap year you can ask the developer for the year first
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    return;
            }

            Console.WriteLine($"Days in month: {days}");
        }
    }
}
