using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Instrument: {Name}");
        }

        public abstract void Sound();
        public abstract void Desc();
        public abstract void History();

    }
}
