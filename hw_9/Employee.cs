using System;
using System.Collections.Generic;
using System.Text;

namespace hw_9
{
    internal class Employee : Person
    {

        // private field
        private DateTime dateOfBirht;
      

        // properties
        public DateTime DateOfBirth
        {
            get { return dateOfBirht; }
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Invalid date of birth");
                    return;
                }
                this.dateOfBirht = value;
            }
        }

        // no need for validation as enums will only accept defined values
        public Country Country { get; set; }
        public Gender Gender { get; set; }
        public Contacts Contact { get; set; }

        // parameterized constructor calling base constructor to set name and surname, and setting other properties
        public Employee(
            string name,
            string surname,
            DateTime dateOfBirth,
            Country country,
            Gender gender,
            Contacts contact)
            : base(name, surname)
        {
            DateOfBirth = dateOfBirth;
            Country = country;
            Gender = gender;
            Contact = contact;
        }


        // method to calculate age. method calculates the age based on
        // current date and the date of birth, and accounts for
        // whether the birthday has occurred yet this year.
        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateOfBirth > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Age: {GetAge()}, Country: {Country}, Gender: {Gender}, Contact: {Contact}";
        }
    }
}
