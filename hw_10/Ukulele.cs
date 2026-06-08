using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The ukulele produces a bright, cheerful sound.");
        }
        public override void Desc()
        {
            Console.WriteLine("The ukulele is a small, four-stringed instrument that originated in Hawaii. It is known for its distinctive sound and is often associated with Hawaiian music.");
        }
        public override void History()
        {
            Console.WriteLine("History: The ukulele became popular in Hawaii in the 19th century.");
        }
    }
}
