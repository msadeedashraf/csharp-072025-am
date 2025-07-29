using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSol
{
    internal interface ITransferable
    {
        void Transfer(BankAccount toAccount, decimal amount);
    }
}
