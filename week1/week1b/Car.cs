using System;

//Car is extension of Vehicle (inheritance)
public class Car : Vehicle
{
    public override void CloseWindow()
    {
        Console.WriteLine("My Car Window is closed");
    }
}