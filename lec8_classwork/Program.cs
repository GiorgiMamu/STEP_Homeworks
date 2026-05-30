namespace lec8_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, -10, 25, 3, -50, 100, 0 };

            void GetMaxAndMin(int[] arr)
            {
                int min = arr[0];
                int max = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];

                    if (arr[i] > max)
                        max = arr[i];
                }

                Console.WriteLine($"min: {min} - {GetSign(min)}");
                Console.WriteLine($"max: {max} - {GetSign(max)}");
            }

         
            string GetSign(int number)
            {
                if (number > 0)
                    return "positive";
                else if (number < 0)
                    return "negative";
                else
                    return "zero";
            }

            GetMaxAndMin(numbers);
        }
    }
}
