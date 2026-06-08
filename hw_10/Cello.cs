using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal class Cello: MusicalInstrument
    {
        public Cello() : base("Cello")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The cello produces a deep, rich sound.");
        }
        public override void Desc()
        {
            Console.WriteLine("The cello is a string instrument that is played with a bow. It has four strings and is known for its warm, resonant tone. The cello is often used in classical music, chamber music, and orchestras.");
        }
        public override void History()
        {
            Console.WriteLine("History: The cello appeared in Europe during the 16th century.");
        }
    }
}
