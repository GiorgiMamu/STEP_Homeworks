using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lec12_classwork
{
    internal class Student : IEnumerable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Point { get; set; }


        private static Student[] _allStudents = new Student[0];

        public Student() { }
        public Student(string firstName, string lastName, int age, string email, string phone, int point)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
            Point = point;
        }


        public static void SetStudentArray(Student[] students)
        {
            _allStudents = students;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < _allStudents.Length; i++)
                yield return _allStudents[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static bool operator >(Student a, Student b) { return a.Point > b.Point; }
        public static bool operator <(Student a, Student b) { return a.Point < b.Point; }

        public static bool operator >=(Student a, Student b) { return a.Age >= b.Age; }
        public static bool operator <=(Student a, Student b) { return a.Age <= b.Age; }

        public static int operator +(Student a, Student b) { return a.Point + b.Point; }

        public static bool operator ==(Student a, Student b)
        {
            return a.Point == b.Point && a.Age == b.Age;
        }

        public static bool operator !=(Student a, Student b) { return !(a == b); }

        public override bool Equals(object? obj) => obj is Student s && this == s;
        public override int GetHashCode() => HashCode.Combine(Point, Age);

        public override string ToString()
        {
            return $"{FirstName} {LastName} | age: {Age} | point: {Point} | email: {Email} | phone: {Phone}";
        }

        // ვიპოვოთ ისეთი სტუდენტი რომელსაც აქვს ყველაზე დაბალი ქულა
        public static Student FindMinPoint(Student[] students)
        {
            Student min = students[0];
            foreach (Student s in _allStudents)
                if (s < min) min = s;   
            return min;
        }

        // ვიპოვოთ ისეთი სტუდენტი რომელიც ყველაზე დიდია ასაკით
        public static Student FindOldest(Student[] students)
        {
            Student oldest = students[0];
            foreach (Student s in _allStudents)
                if (s >= oldest) oldest = s;    
            return oldest;
        }

        // ვიპოვოთ ყველა სტუდენტის საშუალო ქულა
        public static double AveragePoint(Student[] students)
        {
            int total = 0;
            foreach (Student s in _allStudents)
                total += s.Point;   
            return (double)total / students.Length;
        }

        // დაასორტირეთ სტუდენტების მასივი
        public static Student[] SortByPoint(Student[] students)
        {
            Student[] sorted = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
                sorted[i] = students[i];

            for (int i = 0; i < sorted.Length - 1; i++)
                for (int j = 0; j < sorted.Length - 1 - i; j++)
                    if (sorted[j] < sorted[j + 1])  
                    {
                        Student temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }

            return sorted;
        }
    }
}