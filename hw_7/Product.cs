using System;
using System.Collections.Generic;
using System.Text;

namespace hw_7
{
    internal class Product
    {
        // i wanted to use some validations on setters so i used private fields for some values
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;
        private double _rating;
        private double _discountPercent;

        // properties
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id must be greater than 0");
                    return;
                }
                _id = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("name cannot be empty");
                    return;
                }
                _name = value.Trim();
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("price must be greater than 0");
                    return;
                }
                _price = value;
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("quantity must be greater than 0");
                    return;
                }
                _quantity = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 1.0 || value > 5.0)
                {
                    Console.WriteLine("rating must be between 1.0 - 5.0");
                    return;
                }
                _rating = value;
            }
        }
        public double DiscountPercent
        {
            get { return _discountPercent; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("discount must be between 0%-100%");
                    return;
                }
                _discountPercent = value;
            }
        }

        // no setter for this property because it is calculated based on quantity
        public bool IsAvailable
        {
            get { return this.Quantity > 0; }
        }


        // no validations needed for these properties so i used auto-properties
        public string Description { get; set; }
        public string Brand { get; set; }

        // using enum for category to limit the options and make it more readable
        public Category Category { get; set; }
        public DateTime AddedDate { get; set; }



        // constructor
        public Product(int id, string name, string description,
                      double price, int quantity, string brand,
                      Category category, double rating,
                      double discountPercent)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Brand = brand;
            this.Category = category;
            this.Rating = rating;
            this.DiscountPercent = discountPercent;
            this.AddedDate = DateTime.Now;
        }

        // methods
        public double GetFinalPrice()
        {
            return this.Price - (this.Price * this.DiscountPercent / 100);
        }

        public void AddStock(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("amount must be greater than 0");
                return;
            }
            this.Quantity += amount;
        }
        public void RemoveStock(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("amount must be greater than zero");
                return;
            }
            if (amount > this.Quantity)
            {
                Console.WriteLine($"we dont have that much babes, we have: {this.Quantity}");
                return;
            }
            this.Quantity -= amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"PRODUCT: {this.Name}");
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"BRAND: {this.Brand}");
            Console.WriteLine($"CATEGORY: {this.Category}");
            Console.WriteLine($"DESCTIPRION: {this.Description}");
            Console.WriteLine($"PRICE: {this.Price}$");
            Console.WriteLine($"DISCOUNT: {this.DiscountPercent}%");
            Console.WriteLine($"FINAL PRICE: {this.GetFinalPrice()}$");
            Console.WriteLine($"QUANTITY: {this.Quantity}");
            Console.WriteLine($"IS AVAILABLE: {(this.IsAvailable ? "TRUE" : "FALSE")}");
            Console.WriteLine($"RATING: {this.Rating}");
            Console.WriteLine($"ADDED: {this.AddedDate.ToShortDateString()}");
        }
    }
}

