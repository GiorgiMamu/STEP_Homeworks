using System;
using System.Collections.Generic;
using hw_16.Models;
using hw_16.Services;
using hw_16.Helpers;

namespace hw_16
{
    internal class Program
    {
        static void Main()
        {
            Logger logger = new Logger();

            List<Person> people = new List<Person>
            {
                new Person("Nika", 22),
                new Person("Ana", 19),
                new Person("Giorgi", 25),
                new Person("Mariam", 19),
                new Person("Nika", 22),
                new Person("Levan", 30)
            };

            logger.Info("Starting demo of custom LINQ-like methods.");

            var adultsUnder30 = people.MyWhere(p => p.Age < 30 && p.Age >= 18);
            logger.Info("Where (age 18-29): " + string.Join(", ", adultsUnder30));

            var byAge = people.MyOrderBy(p => p.Age);
            logger.Info("OrderBy (age asc): " + string.Join(", ", byAge));

            try
            {
                var firstOver24 = people.MyWhere(p => p.Age > 24).MyFirst();
                logger.Info("First (age > 24): " + firstOver24);
            }
            catch (InvalidOperationException ex)
            {
                logger.Error(ex.Message);
            }

            var firstOver100 = people.MyWhere(p => p.Age > 100).MyFirstOrDefault();
            logger.Info("FirstOrDefault (age > 100): " + (firstOver100?.ToString() ?? "null"));

            var onlyLevan = people.MySingle(p => p.Name == "Levan");
            logger.Info("Single (Name == Levan): " + onlyLevan);

            var noOneNamedX = people.MySingleOrDefault(p => p.Name == "Xyz");
            logger.Info("SingleOrDefault (Name == Xyz): " + (noOneNamedX?.ToString() ?? "null"));

            bool anyTeen = people.MyAny(p => p.Age < 20);
            logger.Info("Any (age < 20): " + anyTeen);

            bool allAdults = people.MyAll(p => p.Age >= 18);
            logger.Info("All (age >= 18): " + allAdults);

            int totalCount = people.MyCount();
            int countOver20 = people.MyCount(p => p.Age > 20);
            logger.Info($"Count (all): {totalCount}, Count (age > 20): {countOver20}");

            var uniquePeople = people.MyDistinct();
            logger.Info("Distinct: " + string.Join(", ", uniquePeople));

            logger.Warning("Demo finished.");
        }
    }
}