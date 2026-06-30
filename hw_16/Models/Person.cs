using System;
using System.Collections.Generic;
using System.Text;

namespace hw_16.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"{Name} ({Age})";

        public override bool Equals(object? obj)
        {
            if (obj is not Person other) return false;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode() => HashCode.Combine(Name, Age);
    }
}
