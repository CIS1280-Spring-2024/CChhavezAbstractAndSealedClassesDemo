using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class Employee // change the class to abstract with the abstract keyword. 
    {
        public Employee() { EmpNum = LastEmpNumber++; } // This constructor incrememts the employee number every time an it is instatiated
        private static int LastEmpNumber = 0; // this is the static vatiable to hold that data. it is statis so only one ever exists
                                               // COOL REUSABLE TECH
        
        public Employee(string firstName, string lastName):this() // :this() chains to the connstructer above so bother happen when the class is instatiated
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int EmpNum { get; private set; } // changed to privvate so onlty the constructor can access employee number setting.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<double> hours = new List<double>(); // add a list to hold hours worked 

        public List <double> Hours // Add public method for handling the hours list
        {
            get { return hours;}
            set { hours = value;}
        }
        public abstract Decimal Pay(int start, int end); // Contract method.  must be implemented for the class to be concrete rather than abstract. all abstract method must be implemented or it will be declared abstract.
        public abstract string PaySummary // change Virtual to Abstract
        {
            get; // remove all implementation from the get method
        }

        public override string ToString()
        {
            return EmpNum + " " + FirstName + " "+LastName;
        }
    }
}
