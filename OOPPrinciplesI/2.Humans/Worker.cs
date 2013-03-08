using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Humans
{
    /// <summary>
    /// Represents a worker. Derives from Human
    /// </summary>
    class Worker : Human
    {
        public double WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }

        public Worker(string firstName, string lastName, double weekSalary, 
            int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (double)(5 * (double)this.WorkHoursPerDay);
        }
    }
}
