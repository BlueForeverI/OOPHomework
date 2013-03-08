using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Represents a deposit account. Derives from Account
    /// Implements IDepositable and IWithdrawable
    /// </summary>
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if(this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(numberOfMonths);
        }
    }
}
