namespace lec5_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal balance = 1000m;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1 - Check balance");
                Console.WriteLine("2 - Deposit money");
                Console.WriteLine("3 - Withdraw money");
                Console.WriteLine("4 - Exit");

                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. please enter number between 1 and 4");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Current nalance: {balance:C}");
                        break;

                    case 2:
                        Console.Write("enter amount to deposit: ");

                        if (!decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        else if (depositAmount <= 0)
                        {
                            Console.WriteLine("Amount must be greater than 0.");
                        }
                        else
                        {
                            balance += depositAmount;
                            Console.WriteLine($"sucessfully deposited {depositAmount:C}");
                            Console.WriteLine($"new balance: {balance:C}");
                        }

                        break;

                    case 3:
                        Console.Write("Enter amount to withdraw: ");

                        if (!decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        else if (withdrawAmount <= 0)
                        {
                            Console.WriteLine("Amount must be greater than 0.");
                        }
                        else if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"Sucessfully withdrew {withdrawAmount:C}");
                            Console.WriteLine($"Remaining balance: {balance:C}");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the ATM.");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. please choose between 1 and 4.");
                        break;
                }
             }

        }
    }
}
