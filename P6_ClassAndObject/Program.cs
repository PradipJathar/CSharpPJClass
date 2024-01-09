using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {

            Car ford = new Car();
            ford.model = "Ford";
            ford.color = "Yellow";
            ford.year = 2013;
            ford.weight = 245.80;
            ford.maxSpeed = 200;

            ford.GetCarInfo();


            Car tata = new Car();
            tata.model = "TATA";
            tata.color = "Black";
            tata.year = 2015;
            tata.weight = 300.50;
            tata.maxSpeed = 250;

            tata.GetCarInfo();
        }
    }


    class Car
    {
        // Fields 

        public string model;            // variable

        public string color;            // variable

        public int year;                // variable

        public double weight;           // variable

        public int maxSpeed;            // variable


        // Methods

        public void GetCarInfo()        // Method
        {
            Console.WriteLine($"I have {model} car having max speed is {maxSpeed} kmph. Its color is {color} and weight is {weight} kg. The car age is {CarAge()} year old.");
        }


        public int CarAge()             // Function
        {
            int age = 2024 - year;

            return age;
        }
    }
}
