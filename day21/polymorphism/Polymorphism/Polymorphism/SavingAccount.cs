using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class SavingAccount : BankAccount
    {
        public double IntrestRate = 0.03;

        public double CalcuateIntrest()
        {

        return Balance*IntrestRate; 
        }

    }
}
