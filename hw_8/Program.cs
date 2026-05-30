using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace hw_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../CarsData.txt";

            string[] lines = File.ReadAllLines(path);

            Car[] cars = new Car[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                cars[i] = new Car(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    decimal.Parse(data[3]),
                    data[4]
                );
            }

            // methods calls
            PrintAllCars(cars);
            Console.WriteLine();
            GetMostExpensiveCar(cars);
            Console.WriteLine();
            GetCarsAfterYear(cars, 2022);
            Console.WriteLine();
            GetAveragePrice(cars);
            Console.WriteLine();
            GetCarsByColor(cars, "White");
            Console.WriteLine();

            // Class Car methods calls
            cars[0].PrintInfo();
            cars[0].ApplyDiscount(10);
            Console.WriteLine("after discount:");
            cars[0].PrintInfo();
            Console.WriteLine($"age: {cars[0].CalculateAge()}");
            Console.WriteLine(cars[0].IsVintage() ? "it is vintage" : "it is not vintage");
            Console.WriteLine(cars[0].IsExpensive() ? "it is expensive" : "it is not expensive");
            cars[0].Start();
            cars[0].Stop();




        }

        // methods
        static void PrintAllCars(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].PrintInfo();
            }
        }

        static void GetMostExpensiveCar(Car[] cars)
        {
            Car expensiveCar = cars[0];

            for (int i = 1; i < cars.Length; i++)
            {
                if (cars[i].Price > expensiveCar.Price)
                {
                    expensiveCar = cars[i];
                }
            }

            Console.WriteLine("most expensive car:");
            expensiveCar.PrintInfo();
        }

        static void GetCarsAfterYear(Car[] cars, int year)
        {
            Console.WriteLine($"cars after {year}");

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Year > year)
                {
                    cars[i].PrintInfo();
                }
            }
        }

        static void GetAveragePrice(Car[] cars)
        {
            decimal sum = 0;

            for (int i = 0; i < cars.Length; i++)
            {
                sum += cars[i].Price;
            }

            decimal average = sum / cars.Length;

            Console.WriteLine($"average price: {average}");
        }

        static void GetCarsByColor(Car[] cars, string color)
        {
            Console.WriteLine($"cars with color {color}");

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color.ToLower() == color.ToLower())
                {
                    cars[i].PrintInfo();
                }
            }
        }



    }
}
