using System;

namespace week1.Fundamentals
{
    public class Square : Shape
    {
        //properties
        public int Length {get; set;}
        public int Height {get; set;}
        public string Color {get; set;}

        //Constructor
        public Square(int length, int height)
        {
            this.Length = length;
            this.Height = height;
        }

        //deconstructor
        /*
            https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct
            https://stackoverflow.com/questions/40906305/c-sharp-7-0-deconstructor
        */        
        public void Deconstruct(out int length, out int height)
        {
            length = this.Length;
            height = this.Height;
        }

        //default constructor
        public Square() {}

        //method
        /*
        void Something()
        {
            System.Convert.ToDouble(23.4f); // intellisense will popup possible parenthesis value types
        }
         */

        //Shapes is an abstract class containing the abstract method Area, being implemented here
        public override double Area()
        {
            Sides = 4;
            return (this.Length * this.Height) + Sides;
        }

    }
}