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

        }
    }
}
