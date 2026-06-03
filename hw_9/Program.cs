using System.Xml.Linq;

namespace hw_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("Giorgi", "Mamulashvili", new DateTime(2005, 3, 15), Country.Georgia, Gender.Male, Contacts.Phone),
                new Employee("Nika", "Beridze", new DateTime(2004, 6, 20), Country.Georgia, Gender.Male, Contacts.Email),
                new Employee("Anna", "Muller", new DateTime(1998, 1, 5), Country.Germany, Gender.Female, Contacts.Phone),
                new Employee("Max", "Schmidt", new DateTime(1997, 8, 12), Country.Germany, Gender.Male, Contacts.Fax),
                new Employee("Pierre", "Martin", new DateTime(1995, 4, 25), Country.France, Gender.Male, Contacts.Email),
                new Employee("Marie", "Dubois", new DateTime(1996, 11, 10), Country.France, Gender.Female, Contacts.Phone),
                new Employee("Marco", "Rossi", new DateTime(1994, 9, 17), Country.USA, Gender.Male, Contacts.Fax),
                new Employee("Giulia", "Bianchi", new DateTime(1999, 2, 28), Country.USA, Gender.Female, Contacts.Email)
            };

            EmployeeHelper.PrintEmployeesByCountry(employees,Country.USA);
        }

    }
}

