using HRManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myEmployees = new List<Employee>();

            //Employee employee = new Employee();
            //HourlyEmployee hEmployee = new HourlyEmployee();// instaitated withdefault construtor then set after the fact
            //hEmployee.FirstName = "Duncan";
            //hEmployee.LastName = "Idahoe";
            HourlyEmployee hEmployee = new HourlyEmployee("Duncan", "Idahoe", 15.0M); // instaitated with overloaded constructor
            //hEmployee.EmpNum = 1; // not needed to be set manually with the employee constructor inherited from Employee
            //hEmployee.HourlyRate = 15.00M;
            hEmployee.Hours.Add(80.0);
            hEmployee.Hours.Add(80.0);
            hEmployee.Hours.Add(72.0);


            //SalaryEmployee salEmployee = new SalaryEmployee();// instaitated withdefault construtor then set after the fact
            //salEmployee.FirstName = "Gurney";
            //salEmployee.LastName = "Halack";
            SalaryEmployee salEmployee = new SalaryEmployee("Gurney", "Halack", 40000.00M); // instaitated with overloaded constructor
            //salEmployee.EmpNum = 2; // not needed to be set manually with the employee constructor inherited from Employee
            //salEmployee.Salary = 40000.00M;
            salEmployee.Hours.Add(80.0);
            salEmployee.Hours.Add(80.0);
            salEmployee.Hours.Add(72.0);

            myEmployees.Add(hEmployee);
            myEmployees.Add(salEmployee);

            decimal payroll = 0;
            foreach (Employee e in myEmployees)
            {
                payroll += e.Pay(0, 2);
            }

            DisplayEmployeeInfo(hEmployee); // method extraction..... huge tool built into visual studio to encapsilate code into methos at the click off a button. 
            DisplayEmployeeInfo(salEmployee);

            //Console.WriteLine("hEmployee to string:" + salEmployee.ToString());  
            //Console.WriteLine("hEmployee Pay summary:" + salEmployee.PaySummary);
            //Console.WriteLine("hEmployee Pay for periods 0-2:" + salEmployee.Pay(0, 2).ToString("C")); // the C here causes display as currency 
            
            
            Console.WriteLine("\nTotal Payroll total for 0-2: " + payroll.ToString("C"));

            Console.WriteLine("\nEmployee list:");
            foreach (Employee e in myEmployees)
            {
                Console.WriteLine("Employee:" + e); // Observe you get all the To.string inheritech values of te tostring methos here thanks to override even whenusing polymorphicly
                if (e is HourlyEmployee)
                {
                    HourlyEmployee hourlyEmployee = e as HourlyEmployee; // This passes the current e into an hourly employee
                    Console.WriteLine(hourlyEmployee.FirstName + "" + e.LastName + " Hourly Rate: " + hourlyEmployee.HourlyRate + "\n");
                }
                if (e is SalaryEmployee)
                {
                    SalaryEmployee SalEmp = e as SalaryEmployee; // This passes the current e into a salary employee
                    Console.WriteLine(SalEmp.FirstName + "" + e.LastName + " Salary: " + SalEmp.Salary + "\n");
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        } 

        private static void DisplayEmployeeInfo(Employee Employee) // extracted method with generic calls Polyorphisim
        {
            Console.WriteLine("Name: "  +Employee.FirstName + " " + Employee.LastName);
            Console.WriteLine("Employee to string:" + Employee.ToString());
            Console.WriteLine("Employee Pay summary:" + Employee.PaySummary);
            Console.WriteLine("Employee Pay for periods 0-2:" + Employee.Pay(0, 2).ToString("C")); // the C here displays as currency 
            Console.WriteLine("");
        }
    }
}
