using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables:
            // Variables are containers for storing data values.

            int num = 10;           // Creating Variables and assign value at same time.

            int num1;               // Creating Variables.
            num1 = 20;              // Assign value to it.


            // Variables with some DataTypes:

            int rollNumber = 21;
            double price = 199.99;
            char myLetter = 'P';
            string myName = "Pradip";
            bool myBool = true;



            // Constants:
            // If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
            // This will declare the variable as "constant", which means unchangeable and read-only.

            const double PI = 3.14159;              // You cannot declare a constant variable without assigning the value.
            // pi = 7.2;                            // You cannot change a value of constant.

            Console.WriteLine("Area of circle with 2 m radius is " + PI * 2 * 2 + " m square.");



            // Display Variables:

            string firstName = "Pradip ";
            string lastName = "Jathar";
            Console.WriteLine(firstName + lastName);                    // Use the + character to join a variable to another variable if they are string.

            int a = 5, b = 10;                                          // To declare more than one variable of the same type, use a comma-separated list.
            Console.WriteLine("Addition of a and b is " + a + b);       // The + character works as a mathematical operator.



            // The general rules for naming variables are:
            // 1. Names can contain letters, digits and the underscore character (_). eg --> a-z, A-Z, 0-9, and _
            // 2. Names must begin with a letter or underscore. eg --> int num1 or string _name
            // 3. Names should start with a lowercase letter and it cannot contain whitespace. eg --> firstName, lastName
            // 4. Names are case sensitive ("myVar" and "myvar" are different variables)
            // 5. Reserved words (like C# keywords, such as int double, class, static, void) cannot be used as names.

        }
    }
}
