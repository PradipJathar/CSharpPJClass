using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_AccessModifiers
{
    class Program 
    {
        static void Main(string[] args)
        {
            Friuts mango = new Friuts();
            mango.name = "Apple";
            mango.color = "Red";
            mango.averageWeight = 0.5;
            mango.test = "good";
            mango.GetFruitInfo();
            mango.GetSweetness();

            SweetFriuts apple = new SweetFriuts();
            apple.averageWeight = 0.2;
            apple.GetFruitInfo();
            apple.howMuchSweetness = "A Lot";
            apple.GetSweetness();
        }
    }


    // internal  AccessModifiers example (see P7_Constructors)

    public class ClassPublic
    {
        public string str;
    }

    internal class ClassInternal   // internal - The code is only accessible within its own assembly, but not from another assembly. 
    {
        public string str2;
    }


    // Inheritance:
    // It is possible to inherit fields and methods from one class to another.
    // Derived Class (child) - the class that inherits from another class
    // Base Class (parent) - the class being inherited from
    // To inherit from a class, use the : symbol.
    // sealed - If you don't want other classes to inherit from a class, use the sealed keyword:


    // Friuts - Base Class (parent) - the class being inherited from
    class Friuts      // Default (if not given) access modifier for class itself is "internal". 
    {

        string name;                        // Default (if not given) accsess modifier for class members is "private".

        private string color;               // private - The code is only accessible within the same class.

        public double averageWeight;        // public - The code is accessible for all classes.

        protected string test;              // The code is accessible within the same class, or in a class that is inherited from that class.


        public void GetFruitInfo()
        {
            Console.WriteLine($"Fruit info is {name} - {color} - {averageWeight} - {test}");
        }
    }


    // SweetFriuts - Derived Class (child) - the class that inherits from another class
    class SweetFriuts : Friuts
    {
        public string howMuchSweetness;


        public void GetSweetness()
        {
            Console.WriteLine($"This is get sweetness method. {name} - {color} - {averageWeight} - {test}");
        }
    }

   
    
    

}
