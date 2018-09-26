using System;

namespace Week1.Homework3
{
    public class BicycleHW3
    {
        //Field(variable)
        private string _seat;
        private int _numOfGears = 10;

        //Property
        public string Seat
        {
            set
            {
                this._seat = value;
            }
            get
            {
                return _seat;
            }
        }

        //Auto-property
        public string HandlebarType { get; set;}


        //Default Constructor
        public BicycleHW3()
        {
            Console.WriteLine("BicycleHW3 Default Constructor");
            Console.WriteLine("Number of gears = " + NumOfGears);
        }

        //Constructor with parameter
        public BicycleHW3(string type)
        {
            NumOfGears = 12;
            HandlebarType = type;
            Console.WriteLine("BicycleHW3 constructor with parameter");
            Console.WriteLine("Number of gears = " + NumOfGears);
        }

        //private property (not a private method)
        private int NumOfGears
        {
            get
            {
                return this._numOfGears;
            }
            set
            {
                this._numOfGears = value;
            }
        }
    }
}