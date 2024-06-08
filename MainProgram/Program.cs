using System;
using System.Diagnostics;
using System.IO;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run:");
                Console.WriteLine("1. Print Number");
                Console.WriteLine("2. Check Divisibility");
                Console.WriteLine("3. Max of Two Numbers");
                Console.WriteLine("4. Positive or Negative");
                Console.WriteLine("5. Max and Min of Three Numbers");
                Console.WriteLine("6. Even or Odd");
                Console.WriteLine("7. Vowel or Consonant");
                Console.WriteLine("8. Marks Calculation");
                Console.WriteLine("9. Days in Month");
                Console.WriteLine("10. Grade Calculation");
                Console.WriteLine("11. Positive, Negative, or Zero using Switch");
                Console.WriteLine("12. Simple Calculator using Switch");
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
                    case "3":
                        RunProject("MaxOfTwoNumbers");
                        break;
                    case "4":
                        RunProject("PositiveNegativeCheck");
                        break;
                    case "5":
                        RunProject("MaxMinOfThreeNumbers");
                        break;
                    case "6":
                        RunProject("EvenOddCheck");
                        break;
                    case "7":
                        RunProject("VowelConsonantCheck");
                        break;
                    case "8":
                        RunProject("MarksCalculation");
                        break;
                    case "9":
                        RunProject("DaysInMonth");
                        break;
                    case "10":
                        RunProject("GradeCalculation");
                        break;
                    case "11":
                        RunProject("PositiveNegativeZeroSwitch");
                        break;
                    case "12":
                        RunProject("SimpleCalculator");
                        break;
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
            string solutionDirectory = GetSolutionDirectory();
            string projectPath = Path.Combine(solutionDirectory, projectName, "bin", "Debug", "net5.0", $"{projectName}.exe");

            if (File.Exists(projectPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(projectPath)
                {
                    UseShellExecute = true,
                };
                Process.Start(startInfo);
            }
            else
            {
                Console.WriteLine($"Executable for project {projectName} not found at path: {projectPath}");
            }
        }

        static string GetSolutionDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);

            while (directoryInfo != null && !File.Exists(Path.Combine(directoryInfo.FullName, "AssignmentSolution.sln")))
            {
                directoryInfo = directoryInfo.Parent;
            }

            return directoryInfo?.FullName;
        }
    }
}
