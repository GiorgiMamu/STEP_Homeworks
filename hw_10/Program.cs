namespace hw_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] instruments =
            {
                new Violin(),
                new Ukulele(),
                new Trombone(),
                new Cello()
            };
            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.Show();
                instrument.Sound();
                instrument.Desc();
                instrument.History();

                Console.WriteLine("----------------------------------");
            }

            Worker[] workers =
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer()
            };

            foreach (Worker worker in workers)
            {
                worker.Print();
            }
        }
    }
}
