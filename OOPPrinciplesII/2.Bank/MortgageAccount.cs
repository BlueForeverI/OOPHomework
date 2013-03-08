using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Represents a mortgage account. Derives from Account
    /// Implements IDepositable
    /// </summary>
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            decimal amount = 0;

            switch (this.Customer.Type)
            {
                case CustomerType.Company:
                    if(numberOfMonths <= 12)
                    {
                        amount = (numberOfMonths / (decimal)2) * this.InterestRate;
                    }
                    else
                    {
                        amount = (6 + (numberOfMonths - 12)) * this.InterestRate;
                    }
                    break;

                case CustomerType.Individual:
                    if(numberOfMonths > 6)
                    {
                        amount = (numberOfMonths - 6) * this.InterestRate;
                    }
                    break;
            }

            return amount;
        }
    }
}
