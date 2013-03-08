using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Bank
{
    /// <summary>
    /// hold information about the type of the customer
    /// </summary>
    enum CustomerType
    {
        Individual,
        Company
    }

    /// <summary>
    /// Represents a bank customer
    /// </summary>
    class Customer
    {
        public string Name { get; private set; }
        public CustomerType Type { get; private set; }

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
