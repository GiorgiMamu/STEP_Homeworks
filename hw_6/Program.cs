namespace hw_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task_1
            int[][] studentScores =
            [
                [ 90, 85, 88 ],
                [ 70, 75 ],
                [ 100, 95, 98, 92 ],
                [ 60 ]
            ];

            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = (double)sum / studentScores[i].Length;

                Console.WriteLine($"student {i + 1} average: {average}");
            }

            #endregion



            #region task_2
            Random random = new Random();

            int[] passcodes = new int[10];

            for (int i = 0; i < passcodes.Length; i++)
            {
                passcodes[i] = random.Next(1000, 10000);
            }

            passcodes[0] = 1234; // for testing 

            Console.Write("enter passcode: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int userCode);

            if (!isNumber)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                bool found = false;

                for (int i = 0; i < passcodes.Length; i++)
                {
                    if (userCode == passcodes[i])
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }

            #endregion



            #region task_3
            int[] numbers = { 5, -10, 25, 3, -50, 100, 0 };

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"minimum: {min}");
            Console.WriteLine($"maximum: {max}");

            #endregion



            #region task_4
            string[] words = { "Hello", "World", "CSharp", "Siyvaruli" };

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"word: {words[i]}");

                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.WriteLine(words[i][j]);
                }

                Console.WriteLine();
            }

            #endregion



            #region task_5
            string[] emails =
            {
                "test@gmail.com",
                "wrongemail.com",
                "hello@yahoo.com",
                "invalidmail"
            };

            for (int i = 0; i < emails.Length; i++)
            {
                bool containsAt = false;

                for (int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '@')
                    {
                        containsAt = true;
                        break;
                    }
                }

                if (containsAt)
                {
                    Console.WriteLine($"{emails[i]} - valid");
                }
                else
                {
                    Console.WriteLine($"{emails[i]} - invalid");
                }
            }

            #endregion

        }
    }
}