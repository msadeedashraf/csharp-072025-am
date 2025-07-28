using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Staff
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public virtual void ShowRole()
        {
            Console.WriteLine("General Staff");
        }
    }
}
