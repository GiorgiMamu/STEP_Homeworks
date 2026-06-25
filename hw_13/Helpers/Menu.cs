using System;
using System.Collections.Generic;
using hw_13.Models;

namespace hw_13.Helpers
{
    //menu handles everything the user sees and types
    //it uses StudentRepository for data and Logger to record actions
    public class Menu
    {
        private StudentRepository _repo;
        private Logger _logger;
        public Menu(StudentRepository repo, Logger logger)
        {
            _repo = repo;
            _logger = logger;
        }
        public void Run()
        {
            bool running = true;

            while (running) 
            {
                PrintMenuHeader();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ShowAll(); break;
                    case "2": ShowBest(); break;
                    case "3": ShowAverageGPA(); break;
                    case "4": SearchByLastName(); break;
                    case "5": SortAndShow(); break;
                    case "6": AddStudent(); break;
                    case "7": RemoveStudent(); break;
                    case "8":
                        Console.WriteLine("\nGoodbye!");
                        _logger.Log("User exited the program");
                        running = false; //this exits the while loop
                        break;
                    default:
                        Console.WriteLine("\ninvalid choice. Please enter a number from 1 to 8");
                        break;
                }

                //pause before clearing screen
                if (running)
                {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        //prints the menu options to the console
        private void PrintMenuHeader()
        {
            Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Find best student (highest GPA)");
            Console.WriteLine("3. Calculate average GPA");
            Console.WriteLine("4. Search student by last name");
            Console.WriteLine("5. Sort students by GPA (descending)");
            Console.WriteLine("6. Add new student");
            Console.WriteLine("7. Remove student by email");
            Console.WriteLine("8. Exit");
            Console.Write("\nYour choice: ");
        }

        //option 1: Display all students in compact format using foreach
        private void ShowAll()
        {
            _logger.Log("Displayed all students");
            List<Student> all = _repo.GetAll();

            if (all.Count == 0)
            {
                Console.WriteLine("\nNo students in the system");
                return; 
            }

            Console.WriteLine($"\n--- ALL STUDENTS ({all.Count} total) ---");
            foreach (Student s in all)
            {
                s.DisplayInfo(); 
            }
        }

        //option 2: Find and print the student with the highest GPA
        private void ShowBest()
        {
            _logger.Log("Found best student");
            Student best = _repo.GetBest();
            Console.WriteLine("\n--- BEST STUDENT ---");
            best.Print(); 
        }

        //option 3: Show the average GPA of all students
        private void ShowAverageGPA()
        {
            _logger.Log("Calculated average GPA");
            double avg = _repo.GetAverageGPA();
            Console.WriteLine($"\nAverage GPA of all students: {avg:F2}");
        }

        //option 4: Search students by partial last name
        private void SearchByLastName()
        {
            Console.Write("\nEnter last name to search: ");
            string input = Console.ReadLine();
            _logger.Log($"Searched for last name: '{input}'");

            List<Student> results = _repo.SearchByLastName(input);

            if (results.Count == 0)
            {
                Console.WriteLine($"\nNo student found with last name containing '{input}'");
            }
            else
            {
                Console.WriteLine($"\n--- RESULTS: {results.Count} student(s) found ---");
                foreach (Student s in results)
                {
                    s.Print(); 
                }
            }
        }

        //option 5: Sort the list and display it
        private void SortAndShow()
        {
            _logger.Log("Sorted students by GPA descending");
            _repo.SortByGPADescending(); 

            Console.WriteLine("\n--- STUDENTS SORTED BY GPA (High -> Low) ---");
            foreach (Student s in _repo.GetAll())
            {
                s.DisplayInfo();
            }
        }

        //option 6: Read input from user and create a new Student
        //try-catch handles bad input so the program doesnt crash
        private void AddStudent()
        {
            Console.WriteLine("\n--- ADD NEW STUDENT ---");

            try
            {
                Console.Write("First name : ");
                string name = Console.ReadLine().Trim();

                Console.Write("Last name : ");
                string lastName = Console.ReadLine().Trim();

                Console.Write("Age : ");
                int age = int.Parse(Console.ReadLine());
                if (age <= 16)
                    throw new ArgumentException("Age must be greater than 16");

                Console.Write("Email : ");
                string email = Console.ReadLine().Trim();
                if (!email.Contains("@"))
                    throw new ArgumentException("Email must contain '@'");

                Console.Write("Phone : ");
                string phone = Console.ReadLine().Trim();

                Console.Write("GPA (0-100): ");
                double gpa = double.Parse(Console.ReadLine());
                if (gpa < 0 || gpa > 100)
                    throw new ArgumentException("GPA must be between 0 and 100");

                Console.WriteLine("Faculty    : (0) IT   (1) Business   (2) Design   (3) Medicine");
                Console.Write("Enter number: ");
                int facultyIndex = int.Parse(Console.ReadLine());

                if (!Enum.IsDefined(typeof(Faculty), facultyIndex))
                    throw new ArgumentException("Faculty must be 0, 1, 2, or 3");

                Faculty faculty = (Faculty)facultyIndex;

                Student newStudent = new Student(name, lastName, age, email, phone, gpa, faculty);
                _repo.Add(newStudent);
                _logger.Log($"Added new student: {name} {lastName}");
                Console.WriteLine("\nStudent added successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter valid numbers for Age, GPA, and Faculty.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n Validation error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
        }

        //option 7: Remove a student by their email address
        private void RemoveStudent()
        {
            Console.Write("\nEnter the email of the student to remove: ");
            string email = Console.ReadLine();
            _logger.Log($"Attempted to remove student with email: '{email}'");

            bool removed = _repo.RemoveByEmail(email);

            if (removed)
                Console.WriteLine("Student removed successfully.");
            else
                Console.WriteLine("No student found with that email.");
        }
    }
}