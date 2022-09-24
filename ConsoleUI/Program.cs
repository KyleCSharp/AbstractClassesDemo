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
             -DONE Create an abstract class called Vehicle
             -DONE The vehicle class shall have three string properties Year, Make, and Model
             -DONE Set the defaults to something generic in the Vehicle class
             -DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             *-DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * -DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *-DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle-
             *-DONE Provide the implementations for the abstract methods
             *-DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
               var Vehicles = new List<Vehicle>(); 
            /*
             * -DONECreate 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * -DONE Set the properties with object initializer syntax
             */ Car Car = new Car() { HasTrunk=true, Year=2021, Make="Toyota", Model="Corolla"};
                Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Year =2022, Make="Honda", Model="Rebel 500" };
            Vehicle Truck = new Car() { HasTrunk = false, Year = 2022, Make = "Toyota", Model = "Tacoma" };
            Vehicle Suv = new Car() { HasTrunk = true, Year = 2022, Make = "Dodge", Model = "Durango SRT 392" };


            //Car car = new Car();
            //car.Year = 1994;


            


            
            
            //-DONEAdd the 4 vehicles to the list
            Vehicles.Add(Suv);
            Vehicles.Add(Truck);
            Vehicles.Add(motorcycle);
            Vehicles.Add(Car);
            
            //_DONE Using a foreach loop iterate over each of the properties
           
            
            foreach (var v in Vehicles)
            {
                Console.WriteLine($"{v.Year}, {v.Make}, {v.Model}");


                v.DriveAbstract();
                v.DriveVirtual();
                Console.WriteLine("_______________________________");
            }

            //-DONE Call each of the drive methods for one car and one motorcycle
            //^^^^^did for all in the foreach loop

            #endregion
            Console.ReadLine();
        }
    }
}
