using System;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Use default constructor, creating copy (instance) of Vehicle class
            Vehicle vehicle = new Vehicle();

            vehicle.Color = "Blue";
            
            vehicle.WheelType = "Chrome";
            Console.WriteLine(vehicle.WheelType);

            vehicle.OpenDoor();
            vehicle.CloseWindow();

            //Instance with parameter constructor
            Vehicle vehicle2 = new Vehicle("Chevy");

            //example of inheritance (car is child class of vehicle parent)
            Car myCar = new Car();
            myCar.Color = "Green";
            myCar.OpenDoor();
            myCar.CloseWindow();
        }
    }
}
