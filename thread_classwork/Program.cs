namespace thread_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"Thread 1: {i}");
                    Thread.Sleep(1000);
                }
            });
            Thread thread2 = new Thread(() =>
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine($"Thread 2: {i}");
                    Thread.Sleep(1000);
                }
            });
            

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

        }
    }
}
