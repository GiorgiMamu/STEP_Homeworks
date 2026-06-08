using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Violin")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The violin produces a high-pitched, melodic sound.");
        }
        public override void Desc()
        {
            Console.WriteLine("The violin is a string instrument that is played with a bow. It has four strings and is known for its versatility in various music genres.");
        }
        public override void History()
        {
            Console.WriteLine("The violin has a rich history dating back to the 16th century. It evolved from earlier string instruments and has been used in classical, folk, and contemporary music throughout the centuries.");
        }
    
    }
}
