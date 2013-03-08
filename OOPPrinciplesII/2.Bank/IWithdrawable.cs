using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Holds methods for an object that can be withdrawable
    /// </summary>
    interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
