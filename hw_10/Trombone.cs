using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal class Trombone: MusicalInstrument
    {
        public Trombone() : base("Trombone")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The trombone produces a rich, brassy sound.");
        }
        public override void Desc()
        {
            Console.WriteLine("The trombone is a brass instrument that is played by sliding a telescoping tube to change the pitch. It has a distinctive sound and is commonly used in orchestras, jazz bands, and marching bands.");
        }
        public override void History()
        {
            Console.WriteLine("History: The trombone was developed during the Renaissance period.");
        }
    }
}
