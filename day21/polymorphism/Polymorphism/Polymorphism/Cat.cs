using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cat : Animal
    {

        /*
        public void catSound()

        {
            Console.WriteLine("Cat Says meao");
        }
        */

        public override void animalSound()
        {
            Console.WriteLine("Cat Says meao");
        }


    }
}
