using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


namespace hw_9
{
    // person can have all the fields of employee, but we will only use name and surname for this class. (:
    internal class Person
    {
        // private fields
        private string name;
        private string surname;

        // properties with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid name");
                    return;
                }
                this.name = value.Trim();
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid surnname");
                    return;
                }
                this.surname = value.Trim();
            }
        }

        // parameterized constructor
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        // override ToString for easy display of person's name
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
