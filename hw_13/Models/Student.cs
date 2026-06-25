using System;

namespace hw_13.Models
{
    //Student inherits Person (gets Name, LastName, Age, Email, Phone for free)
    // and also implements IPrintable (so it must have a Print() method)
    public class Student : Person, IPrintable
    {
        //properties that are specific to Student
        public double GPA { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string name, string lastName, int age,
                       string email, string phone, double gpa, Faculty faculty)
        {
            Name = name;           
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
            GPA = gpa;             
            Faculty = faculty;
        }

        
        public override void DisplayInfo()
        {
            Console.WriteLine($"{Name} {LastName} | Age: {Age} | Faculty: {Faculty} | GPA: {GPA:F1}");
        }

        public void Print()
        {
            Console.WriteLine($"Name : {Name} {LastName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Faculty : {Faculty}");
            Console.WriteLine($"GPA : {GPA:F1}");
        }


        public static bool operator >(Student a, Student b) => a.GPA > b.GPA;
        public static bool operator <(Student a, Student b) => a.GPA < b.GPA;
    }
}