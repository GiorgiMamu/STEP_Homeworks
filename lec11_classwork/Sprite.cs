using System;
using System.Collections.Generic;
using System.Text;

namespace lec11_classwork
{
    internal abstract class Sprite
    {

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool isOnScreen { get; set; }




        public virtual void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public abstract void Drow();



    }
}
