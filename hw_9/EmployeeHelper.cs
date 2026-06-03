using System;
using System.Collections.Generic;
using System.Text;

namespace hw_9
{
    internal class EmployeeHelper
    {

        // method to print employees by country
        public static void PrintEmployeesByCountry(Employee[] employees, Country country)
        {
            foreach (var employee in employees)
            {
                if (employee.Country == country)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
