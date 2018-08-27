using System;

//Car is extension of Vehicle (inheritance)
public class Car : Vehicle
{
    //This CloseWindow is an example of polymorphism, as it overrides the Vehicle class CloseWindow
    public override void CloseWindow()
    {
        Console.WriteLine("My Car Window is closed");
    }
}