using System;

namespace Week1.Homework3
{
    public class BicycleHW3
    {
        //Field(variable)
        private string _seat;

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
        }

        //Constructor with parameter
        public BicycleHW3(string type)
        {
            HandlebarType = type;
            Console.WriteLine("BicycleHW3 constructor with parameter");
        }
    }
}