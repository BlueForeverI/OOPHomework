using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Represents a loan account. Derives from Account
    /// Implements IDepositable 
    /// </summary>
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            int months = numberOfMonths;
            switch (this.Customer.Type)
            {
                case CustomerType.Individual:
                    months = numberOfMonths - 3;
                    break;

                case CustomerType.Company:
                    months = numberOfMonths - 2;
                    break;
            }

            return months * this.InterestRate;
        }
    }
}
