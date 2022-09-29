using System;

namespace BasicClasses_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { Make = "Honda", Model = "Civic", Year = 2010 };
            Console.WriteLine($"{myCar.Make} is the make.\n{myCar.Model} is the model.\nBuilt in the year {myCar.Year}."); ;
        }
    }
}
