
using P8_AccessModifiers;
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


        // Accessing class for check accesibility (AccessModifiers)

        ClassPublic xyz = new ClassPublic();

        // ClassInternal abc = new ClassInternal();  // internal - The code is only accessible within its own assembly, but not from another assembly. 
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
