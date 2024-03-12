using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public sealed class HourlyEmployee:Employee
    { 
        public HourlyEmployee():this("","",15.0M) 
        {
            //  HourlyRate = 15.0M; // Not needed with overloaded constructor chained by :this
        }
        public decimal HourlyRate { get; set; }

        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) : base(firstName, lastName) // :base chains this back to the constructor in the Employee class
        {
            HourlyRate = hourlyRate;
        }
        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour.";
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }

        public override decimal Pay(int start, int end)
        {
            double hours = 0;
            for (int day = start; day <= end; ++day) 
            {
                hours += Hours[day];
            }
            return (decimal)hours * HourlyRate; 
        }
    }
}
