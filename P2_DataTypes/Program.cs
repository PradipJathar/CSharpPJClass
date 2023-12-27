using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Types:
            // A data type specifies the size and type of variable values.
            // A variable in C# must be a specified data type.


            // 1. int
            // Size -> 4 bytes
            // Stores whole numbers from -2,147,483,648 to 2,147,483,647.
            
            int myNum = 100000;



            // 2. long
            // Size -> 8 bytes
            // Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            // End the value with an "L".

            long myNum1 = 15000000000L;



            // 3. float 
            // Size -> 4 bytes
            // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
            // End the value with an "F".

            float myNum2 = 5.75F;
            float f1 = 35e3F;               // A decimal point number can also be a scientific number with an "e" to indicate the power of 10.



            // 4. double 
            // Size -> 8 bytes
            // Stores fractional numbers. Sufficient for storing 15 decimal digits.
            // End the value with an "D".

            double myNum3 = 19.99D;
            double d1 = 12e4D;              // A decimal point number can also be a scientific number with an "e" to indicate the power of 10.



            // 5. bool 
            // Size -> 1 bit
            // Stores true or false values.

            bool isCSharpFun = true;
            bool isFishTasty = false;



            // 6. char 
            // Size -> 2 bytes
            // Stores a single character/letter, surrounded by single quotes.

            char myGrade = 'B';



            // 7. string 
            // Size -> 2 bytes per character.
            // Stores a sequence of characters, surrounded by double quotes.

            string myName = "Pradip";




            // Type Casting:

            // Type casting is when you assign a value of one data type to another type.            
            // In C#, there are two types of casting:


            // 1. Implicit Casting (automatically):
            //    Implicit casting is done automatically when passing a smaller size type to a larger size type
            //    char -> int -> long -> float -> double

            Console.WriteLine("Implicit Casting:");

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);


            Console.WriteLine("\nExplicit Casting:");

            // 2. Explicit Casting (manually):
            //    Explicit casting must be done manually by placing the type in parentheses in front of the value.
            //    double -> float -> long -> int -> char
            //    We can use type conversion methods for Explicit Casting.
            //    Type Conversion Methods - Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (for int) and Convert.ToInt64 (for long).

            double myDouble1 = 5.81;
            int myInt1 = (int) myDouble1;
            int myInt2 = Convert.ToInt32(myDouble1);        // Using Type Conversion Methods. (This round the number).

            Console.WriteLine(myDouble1);
            Console.WriteLine(myInt1);
            Console.WriteLine(myInt2);


            // More Examples for Explicit Casting:

            string str = "10";
            int strNum = Convert.ToInt32(str);              // convert string to int 
            Console.WriteLine(strNum);


            string s = "false";
            bool t = Convert.ToBoolean(s);                  // convert string to bool
            Console.WriteLine(t);

            double num2 = 7.25;
            string a = Convert.ToString(num2);              // convert double to string
            Console.WriteLine(a);    

        }
    }
}
