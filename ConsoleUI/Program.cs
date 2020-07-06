using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE  Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             * DONE
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONEProvide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
             * ????????
            */

            // Create a list of Vehicle called vehicles
            // Done

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             * ?????
             */

            Car newCar = new Car()
            {
                HasTrunk = true,
                Model = "3285i",
                Make = "Bmw",
                Year = 1993
            };

            Motorcycle motorcycle = new Motorcycle()
            {
                HasSideCart = true,
                Make = "Harley",
                Model = "Pink",
                Year = 1999
            };

            Vehicle sedan = new Car();
            
            sedan.DriveAbstract();
            sedan.DriveVirtual();
            sedan.Year = 2020;
            sedan.Model = "Polaris";
            sedan.Make = "GroundCrew 3s";
            sedan.HasTrunk = true;

            Vehicle sport = new Car();
            sport.Year = 2003;
            sport.
            
        

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
