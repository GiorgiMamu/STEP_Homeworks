using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager: Responsible for managing employees and projects.");
        }
    }
}
