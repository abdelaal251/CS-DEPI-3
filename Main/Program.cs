using System;
using System.Diagnostics;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run:");
                Console.WriteLine("1. Print Number");
                Console.WriteLine("2. Check Divisibility");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunProject("PrintNumber");
                        break;
                    case "2":
                        RunProject("CheckDivisibility");
                        break;
                    // Add more cases for other programs
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void RunProject(string projectName)
        {
            string projectPath = $@"..\..\..\{projectName}\bin\Debug\net5.0\{projectName}.exe";
            Process.Start(projectPath);
        }
    }
}
