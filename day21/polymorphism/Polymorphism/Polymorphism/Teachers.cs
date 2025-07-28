using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Teachers : Staff
    {
        public  string  subject { get; set; }

        public override void ShowRole()
        {
            Console.WriteLine($"Teacher is teaching {subject}");
        }

}
}
