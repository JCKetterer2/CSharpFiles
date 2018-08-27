using System;

public class Vehicle
{
    //Reference type Field
    // Private variables should use an underscore
    private string _color;

    //Normal Property
    public string Color 
    {
        get
        {
            return _color;
        }

        set
        {
            Console.WriteLine(value);
            this._color = value;
        }
    }


//Automatic Property (short version of above code, has implied private variable called _wheelType)
    public string WheelType { get; set;}


    //Default Constructor (defined by the name of the class)
    public Vehicle()
    {
        Console.WriteLine("Default Vehicle Constructor");
    }


    //Constructor with a parameter
    public Vehicle(string type)
    {
        Console.WriteLine(type);
    }


    //Method with no parameters
    public void OpenDoor()
    {
        Console.WriteLine("Door is open");
    }

    //example of polymorphism from the child class
    public virtual void CloseWindow()
    {
        Console.WriteLine("Vehicle Window Closed");
    }

    //example2 of polymorphism
    public virtual void MoveForward()
    {
        Console.WriteLine("Vehicle moving forward...");
    }
}