using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee pradip = new Employee("Pradip Jathar", "Thermax", 252045.60);
        }
    }


    class Employee
    {
        public string name;
        public string company;
        public double salery;
        
        public Employee(string empName, string empCompany, double empSalery)
        {
            name = empName;
            company = empCompany;
            salery = empSalery;
        }
    }
}
