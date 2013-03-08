using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Holds methods for an object that can be depositable
    /// </summary>
    interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
