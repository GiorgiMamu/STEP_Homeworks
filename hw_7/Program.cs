namespace hw_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(
                id: 1,
                name: "Laptop",
                description: "studios gaqachavs",
                price: 2500.00,
                quantity: 15,
                brand: "HP",
                category: Category.Electronics,
                rating: 4.5,
                discountPercent: 10
            );

            Product product2 = new Product(
                id: 2,
                name: "Running shoes",
                description: "es isaa tavisit ro darbis",
                price: 320.00,
                quantity: 0, // to test availability
                brand: "Nike",
                category: Category.Sports,
                rating: 4.2,
                discountPercent: 25
            );

            // test creating object with invalid data
            Product product3 = new Product(
                id: -2,
                name: " ",
                description: "es isaa tavisit ro darbis",
                price: -320.00,
                quantity: -7, // to test availability
                brand: "Nike",
                category: Category.Sports,
                rating: -4.2,
                discountPercent: -25
            );

            Console.WriteLine();

            // print info and (includes final price)
            product1.PrintInfo();
            Console.WriteLine();
            product2.PrintInfo();
            Console.WriteLine();


            // stock operations
            product2.AddStock(50);
            Console.WriteLine($"{product2.Name} - quantity: {product2.Quantity}, isAvailable: {product2.IsAvailable}");

            Console.WriteLine();

            product1.RemoveStock(3);
            Console.WriteLine($"{product1.Name} - quantity: {product1.Quantity}");

            Console.WriteLine();

            product1.RemoveStock(999);  // to test


        }
    }
}


