using System;

//Bicycle is extension of Vehicle (inheritance)
public class Bicycle : Vehicle
{
    //Reference type Field
    // Private variables should use an underscore
    private int _numOfGears;

    //Normal Property
    public int NumofGears  
    {
        get
        {
            return _numOfGears;
        }

        set
        {
            Console.WriteLine("Bicycle number of gears = " + value);
            this._numOfGears = value;
        }
    }

    public string HandlebarType { get; set;}


    //This MoveForward is an example of polymorphism, as it overrides the Vehicle class MoveForward
    public override void MoveForward()
    {
        Console.WriteLine("Bicycle pedaling forward...");
    }
}