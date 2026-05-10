using System.Diagnostics;

namespace hw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task_1
            Console.Write("Please enter your age: ");
            string strAge = Console.ReadLine();
            if (int.TryParse(strAge, out int age))
                Console.WriteLine(age >= 18 ? "you can vote" : "you cannot vote");
            else
                Console.WriteLine("what do you mean?!");


            // task_2 
            // lets assume user enters numbers and lets do cases when 2 or 3 numbers are equal
            Console.Write("enter first number: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.Write("enter second number: ");
            int.TryParse(Console.ReadLine(), out int b);

            Console.Write("enter third number: ");
            int.TryParse(Console.ReadLine(), out int c);

            if (a == b && b == c) Console.WriteLine($"all are equal: {a}");
            else if (a == b && a > c) Console.WriteLine($"first and second are equal and biggest: {a}");
            else if (a == c && a > b) Console.WriteLine($"first and third are equal and biggest: {a}");
            else if (b == c && b > a) Console.WriteLine($"second and third are equal and biggest: {b}");
            else if (a > b && a > c) Console.WriteLine($"sirst number is the biggest: {a}");
            else if (b > a && b > c) Console.WriteLine($"second number is the biggest: {b}");
            else Console.WriteLine($"third number is the biggest: {c}");


            //task_3
            Console.Write("enter first number: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("enter second number: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine(num1==num2 ? 3*(num1+num2) : num1+num2);

        }
    }
}
