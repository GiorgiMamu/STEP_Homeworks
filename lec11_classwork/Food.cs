using System;
using System.Collections.Generic;
using System.Text;

namespace lec11_classwork
{
    internal class Food : Sprite
    {

        public int Heal { get; set; }




        public override void Drow()
        {
            Console.WriteLine("I am food");
        }


    }
}
