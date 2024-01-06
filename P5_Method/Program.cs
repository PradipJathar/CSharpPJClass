using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Method
{
    class Program
    {

        static void Main(string[] args)
        {            
            Intro("Pradip", "Jathar", 24);          // Method
            Console.WriteLine($"My percentage are {CalculatePercentage(80, 70, 90, 60)}.");    // Function

            Intro("Swati", "Jathar", 22);           // Method
            Console.WriteLine($"{CalculatePercentage(45, 78, 89, 40)} are my percentage.");   // Function
        }


        // Method (void Method - Method with no return value)

        static void Intro(string firstName, string lastName, int age)
        {
            string fullName = firstName + " " + lastName;

            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.");
        }



        // Function (Method with return value)

        static double CalculatePercentage(int phyMarks, int chemMarks, int mathMarks, int bioMarks)
        {
            int totalMarks = phyMarks + chemMarks + mathMarks + bioMarks;

            double percentage = totalMarks / 4;

            return percentage;
        }

    }
}
