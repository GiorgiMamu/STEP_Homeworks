namespace hw_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task_1

            int[] firstArr = { 0, 1, 2, 3, 4, 7 };
            int[] secondArr = { 5, 6, 7, 8, 9 };

            int[] resultArr = new int[firstArr.Length + secondArr.Length];

            int index = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                resultArr[index] = firstArr[i];
                index++;
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                resultArr[index] = secondArr[i];
                index++;
            }

            // lamazad davprintot
            Console.Write("resultArr = [");

            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write(resultArr[i]);
                if (i < resultArr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            #endregion



            #region task_2

            int[] randArr = { 3, 5, -4, 8, 11, 1, -1, 6};
            Console.Write("\nEnter target sum: ");

            bool isNumber = int.TryParse(Console.ReadLine(), out int targetSum);
            if (isNumber)
            {
                // max how many pair can it have - n(n-1)/2
                int resultArrLength = randArr.Length * (randArr.Length - 1) / 2;
                
                // 2D array to store pairs
                int[,] arrOfPairs = new int[resultArrLength, 2];

                int pairCount = 0;
                for (int i = 0; i < randArr.Length; i++)
                {
                    for (int j = i+1; j < randArr.Length; j++)
                    {
                        if (randArr[i] + randArr[j] == targetSum)
                        {
                            arrOfPairs[pairCount, 0] = randArr[i];
                            arrOfPairs[pairCount, 1] = randArr[j];
                            pairCount++;
                        }
                    }
                }

                // print that beautifully too
                Console.Write("resultArray = [");

                for (int i = 0; i < pairCount; i++)
                {
                    Console.Write("[" + arrOfPairs[i, 0] + ", " + arrOfPairs[i, 1] + "]");

                    if (i < pairCount - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");

            }
            else
            {
                Console.WriteLine("it is not a number");
            }

            #endregion



        }
    }
}
