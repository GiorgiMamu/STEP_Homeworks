using System;
using hw_13.Helpers;

namespace hw_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "using" statement works with any class that implements IDisposable
            using (Logger logger = new Logger())
            {
                logger.Log("Application started");

                //create the data layer
                StudentRepository repo = new StudentRepository();

                //create the UI layer, pass in the data layer and logger
                Menu menu = new Menu(repo, logger);

                //start the while loop - program runs here until user exits
                menu.Run();

            } 

            //small pause so the user sees the final logger message before the window closes
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}