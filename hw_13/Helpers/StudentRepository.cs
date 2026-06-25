using System;
using System.Collections.Generic;
using hw_13.Models;

namespace hw_13.Helpers
{
    //class responsible for storing and managing data
    public class StudentRepository
    {
 
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>
            {
                new Student("Giorgi", "Beridze", 20, "giorgi@tsu.ge", "555-001", 85.5, Faculty.IT),
                new Student("Mariam", "Kvachadze", 22, "mariam@tsu.ge", "555-002", 91.0, Faculty.Medicine),
                new Student("Luka", "Jojua", 19, "luka@tsu.ge", "555-003", 76.0, Faculty.Business),
                new Student("Nino", "Surmanidze", 21, "nino@tsu.ge", "555-004", 88.5, Faculty.Design),
                new Student("Davit", "Kvaratskhelia", 23, "davit@tsu.ge", "555-005", 95.0, Faculty.IT),
                new Student("Salome", "Tsiklauri", 20, "salome@tsu.ge", "555-006", 72.0, Faculty.Business),
                new Student("Tornike", "Abuladze", 18, "tornike@tsu.ge", "555-007", 80.0, Faculty.Design),
                new Student("Ana", "Geladze", 24, "ana@tsu.ge", "555-008", 67.5, Faculty.Medicine),
                new Student("Irakli", "Tabatadze", 21, "irakli@tsu.ge", "555-009", 93.0, Faculty.IT),
                new Student("Tamar", "Maisashvili", 19, "tamar@tsu.ge", "555-010", 78.5, Faculty.Business),
            };
        }

        // returns the full list 
        public List<Student> GetAll() => _students;

        //find the student with the highest GPA
        public Student GetBest()
        {
            Student best = _students[0]; 
            foreach (Student s in _students)
            {
                if (s > best) 
                    best = s;
            }
            return best;
        }

        //calculate average GPA using a for loop 
        public double GetAverageGPA()
        {
            double total = 0;
            for (int i = 0; i < _students.Count; i++)
            {
                total += _students[i].GPA; 
            }

            return total / _students.Count;
        }

        //search students whose last name CONTAINS the search term
        public List<Student> SearchByLastName(string lastName)
        {
            List<Student> results = new List<Student>();
            string search = lastName.Trim().ToLower();

            foreach (Student s in _students)
            {
                if (s.LastName.ToLower().Contains(search))
                    results.Add(s);
            }
            return results;
        }

       
        public void SortByGPADescending()
        {
            int n = _students.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {                 
                    if (_students[j] < _students[j + 1]) 
                    {
                        Student temp = _students[j];
                        _students[j] = _students[j + 1];
                        _students[j + 1] = temp;
                    }
                }
            }
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        //find a student by email and remove them
        //returns true if found and removed, false if not found
        public bool RemoveByEmail(string email)
        {
            string target = email.Trim().ToLower();

            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Email.ToLower().Equals(target))
                {
                    _students.RemoveAt(i); 
                    return true;
                }
            }

            return false; 
        }
    }
}