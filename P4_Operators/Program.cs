using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operators:
            // Operators are used to perform operations on variables and values.

            // Types of Operators:
            // 1. Arithmetic
            // 2. Assignment
            // 3. Comparison
            // 4. Logical


            // 1. Arithmetic Operators:
            // Arithmetic operators are used to perform common mathematical operations.

            int x = 5;
            int y = 3;

            Console.WriteLine("Arithmetic Operators:");

            // +	Addition        Adds together two values                    x + y
            Console.WriteLine("Addition : " + (x + y));

            // -	Subtraction     Subtracts one value from another	        x - y
            Console.WriteLine("Subtraction : " + (x - y));

            // *	Multiplication  Multiplies two values	                    x * y	
            Console.WriteLine("Multiplication : " + (x * y));

            // /	Division	    Divides one value by another	            x / y
            Console.WriteLine("Division : " + (x / y));

            // %	Modulus	        Returns the division remainder	            x % y
            Console.WriteLine("Modulus : " + (x % y));

            // ++	Increment	    Increases the value of a variable by 1	    x++
            Console.WriteLine("Increment : " + (x++));

            // --	Decrement	    Decreases the value of a variable by 1	    x--
            Console.WriteLine("Decrement : " + (y--));
                        
        }
    }
}
