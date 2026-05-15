namespace hw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region დავალება 1 - Login სისტემა

            string correctUsername = "admin";
            string correctPassword = "1234";

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            #endregion



            #region დავალება 2 - Calculator (switch)

            Console.Write("Enter first number: ");

            bool firstNumberCheck = double.TryParse(Console.ReadLine(), out double number1);

            Console.Write("Enter operator (+ - * /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");

            bool secondNumberCheck = double.TryParse(Console.ReadLine(), out double number2);

            if (firstNumberCheck && secondNumberCheck)
            {
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Result: {number1 + number2}");
                        break;

                    case '-':
                        Console.WriteLine($"Result: {number1 - number2}");
                        break;

                    case '*':
                        Console.WriteLine($"Result: {number1 * number2}");
                        break;

                    case '/':
                        if (number2 != 0)
                        {
                            Console.WriteLine($"Result: {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number input");
            }

            #endregion



            #region დავალება 3 - ასაკის განსაზღვრა (TryParse)

            Console.Write("Enter age: ");

            bool ageCheck = int.TryParse(Console.ReadLine(), out int age);

            if (ageCheck)
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("ბავშვი");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("თინეიჯერი");
                }
                else if (age >= 20 && age <= 64)
                {
                    Console.WriteLine("ზრდასრული");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("პენსიონერი");
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            #endregion
        }
    }
}
