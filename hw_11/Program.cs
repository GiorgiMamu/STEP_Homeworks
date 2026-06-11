namespace hw_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 7, 7 , 5, 6, 7, 8, 9};

            Array array = new Array(data);

            array.showEven();
            array.showOdd();
            Console.WriteLine($"count of unique values: {array.CountDistinct()}");
            Console.WriteLine($"count of values equal 7: {array.EqualToValue(7)}");
        }
    }
}
