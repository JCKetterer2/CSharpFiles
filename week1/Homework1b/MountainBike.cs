using System;


namespace Week1.Homework1b
{
    /*
        Child or derived class
     */
    public class MountainBike : Bicycle1b
    {
        // Class variable
        // Field
        private int _sprocket = 30;

        // Class variable
        // Property
        // In this case it is recommended to do the auto property way below and remove the field above.
        // Use this way, if you need to do more that assign a default value.
        public override int Sprocket
        {

            get
            {
                return _sprocket;
            }
        }

        // Class variable
        // Override auto property and give it a new default value
        // As of C# 6, this is the preferred way
        public override int WheelSpokes { get; } = 35;

        /*
            Default Constructor
            If you want to change the value of the parent class variable _wheelspokes
            you can also change it here in the constructor rather than creating it
            using a property like the Sprocket.
         */
        public MountainBike()
        {
            Console.WriteLine("Mountain Bike");
        }

        // Generic Method for Mountain Bike that can pass to the DownHillBike class
        public virtual void MyMountainColor()
        {
            Console.WriteLine("Mountain Bike color is Red.");
        }

    }
}