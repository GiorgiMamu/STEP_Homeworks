using System;
using System.Collections.Generic;

namespace hw_15
{
    internal class Program
    {
        static List<string> studentNames = new List<string>();

        static Dictionary<string, int> studentScores = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine(" STUDENT SCORE MANAGER");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Search student");
                Console.WriteLine("3. Update score");
                Console.WriteLine("4. Show all students");
                Console.WriteLine("5. Exit");
                Console.Write("\nYour choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddStudent(); break;
                    case "2": SearchStudent(); break;
                    case "3": UpdateScore(); break;
                    case "4": ShowAll(); break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice. Enter a number from 1 to 5");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("\nEnter student name: ");
            string name = Console.ReadLine().Trim();

            //ContainsKey checks if this name already exists in the Dictionary
            if (studentScores.ContainsKey(name))
            {
                Console.WriteLine($"{name} already exists.");
                return; 
            }

            Console.Write("Enter score: ");

            
            if (!int.TryParse(Console.ReadLine(), out int score))
            {
                Console.WriteLine("Invalid score. please enter a whole number");
                return;
            }

            studentNames.Add(name);
            studentScores[name] = score;

            Console.WriteLine($"'{name}' added with score {score}");
        }

        static void SearchStudent()
        {
            Console.Write("\nEnter student name to search: ");
            string name = Console.ReadLine().Trim();

            if (studentScores.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s score: {studentScores[name]}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        static void UpdateScore()
        {
            Console.Write("\nEnter student name to update: ");
            string name = Console.ReadLine().Trim();

            if (!studentScores.ContainsKey(name))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter new score: ");

            if (!int.TryParse(Console.ReadLine(), out int newScore))
            {
                Console.WriteLine("Invalid score. Please enter a whole number");
                return;
            }

       
            studentScores[name] = newScore;

            Console.WriteLine($"{name}'s score updated to {newScore}");
        }

        static void ShowAll()
        {
            if (studentNames.Count == 0)
            {
                Console.WriteLine("\nNo students in the system");
                return;
            }

            Console.WriteLine($"\nALL STUDENTS ({studentNames.Count} total)");

            foreach (string name in studentNames)
            {
                Console.WriteLine($"  {name}: {studentScores[name]}");
            }
        }
    }
}