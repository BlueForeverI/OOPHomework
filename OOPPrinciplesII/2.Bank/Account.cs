using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// Abstract class to hold informatino about generic bank account
    /// </summary>
    abstract class Account
    {
        public Customer Customer { get; protected set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        /// <summary>
        /// Virtual method to calculate the interest of an account
        /// for a number of months
        /// </summary>
        /// <param name="numberOfMonths">Number of months to calculate interest for</param>
        /// <returns>The interest for the number of months</returns>
        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }
    }
}
