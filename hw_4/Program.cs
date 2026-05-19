namespace hw_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task_1

            Console.Write("enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            #endregion

            #region task_2

            Console.Write("\nenter hight: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            #endregion

            #region task_3

            Console.Write("\nenter num ");
            int limit = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"sum is: {sum}");

            #endregion

            #region task_4

            Random random = new Random();

            int secretNumber = random.Next(1, 101);

            int guess = 0;

            Console.WriteLine("\nguess between 1 and 100");

            while (guess != secretNumber)
            {
                Console.Write("enter number: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > secretNumber)
                {
                    Console.WriteLine("too big");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("too small");
                }
                else
                {
                    Console.WriteLine("its correct");
                }
            }

            #endregion
        }
    }
}
