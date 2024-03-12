using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    internal class SalaryEmployee : Employee // after setting up the clas syou can click on the name and have visual studoo auro stub out the abstract classes
    {
        public SalaryEmployee() :this("","", 30000.00M)
        { 
            //Salary = 30000.00M; // Not needed with overloaded constructor chained by :this
        }
        public decimal Salary { get; set; } // implements salasry proprty

        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName) // :base chains this back to the constructor in the Employee class
        {
            Salary = salary;
        }
        public override string PaySummary
        {
            get
            {
                return "This salary employee is payed " + Salary + " per year.";
            }
        }
  

        public override decimal Pay(int start, int end)
        {
            const int payPeriodsPeryear = 24;
            decimal pay = Salary * (end - start)/payPeriodsPeryear;
            return pay;
        }

        public override string ToString()
        {
            return base.ToString() + " Salary Employee"; // base keyword lets you accces methods of the base class
        }
    }
}
