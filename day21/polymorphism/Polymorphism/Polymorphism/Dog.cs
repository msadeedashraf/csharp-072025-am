using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog : Animal
    {

        /*
        public void dogSound()
        {
            Console.WriteLine("Dog says wuf wuf");
        }
        */
        public override void animalSound()
        {
            Console.WriteLine("Dog says wuf wuf");
        }


    }
}
