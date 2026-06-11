using System;
using System.Collections.Generic;
using System.Text;

namespace lec11_classwork
{
    internal class Enemy : Sprite, IShootable
    {

        public int Health { get; set; }
        public int Demage { get; set; }


        public override void Move(int x, int y)
        {
            X += x;

        }


        public override void Drow()
        {
            Console.WriteLine("I am enemy");
        }

        public void Shoot()
        {
            Console.WriteLine("enemy shoots");
        }

    }
}
