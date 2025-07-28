using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Administrator : Staff
    {
        public override void ShowRole()
        {
            Console.WriteLine($"{Name} is managing the School");
        }
    }
}
