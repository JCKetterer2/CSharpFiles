using System;

namespace Week1.Homework1b
{
    /*
        This class inherits from its parent class MountainBike, and also
        gains all of the Mountain Bike's inherited attributes from
        the Bicycle Class.
     */
    public class DownHillBike : MountainBike
    {
        // Class variable
        // Override auto property and give it a new default value
        // As of C# 6, this is the preferred way
        public override int WheelSpokes { get; } = 45;

        // Class variable
        // Override auto property and give it a new default value
        // As of C# 6, this is the preferred way
        public override int Sprocket { get; } = 35;

        // Overridden Method from Mountain Bike
        public override void MyMountainColor()
        {
            Console.WriteLine("Dowhill Bike color is Green.");
        }
    }
}