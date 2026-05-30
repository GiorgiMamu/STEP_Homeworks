using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace hw_8
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _year;
        private decimal _price;
        private string _color;


        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("brand cannot be empty");
                    return;
                }
                _brand = value.Trim();
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("model cannot be empty");
                    return;
                }
                _model = value.Trim();
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    Console.WriteLine("its future");
                    return;
                }
                _year = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("price cannot be negative");
                    return;
                }
                _price = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("color cannot be empty");
                    return;
                }
                _color = value.Trim();
            }
        }
        public Car(string brand, string model, int year, decimal price, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Color = color;
        }


        // some methods
        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price}, Color: {Color}");
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("invalid discount percentage");
                return;
            }
            Price -= Price * (percentage / 100);
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - Year;
        }

        public bool IsVintage()
        {
            return CalculateAge() >= 25;
        }


        public void Start()
        {
            Console.WriteLine($"{this.Brand} started");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Brand} stopped");
        }

        public bool IsExpensive()
        {
            return Price > 50000;
        }
    }
}
