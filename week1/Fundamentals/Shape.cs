using System;

namespace week1.Fundamentals
{
    public abstract class Shape
    {
        public int Sides {set; get;}

        //this abstract method is implemented in the Square class
        public abstract double Area();
    }
}