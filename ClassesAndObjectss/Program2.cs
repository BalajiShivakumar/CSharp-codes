using System;
namespace ClassesAndObjectss;

class Car
{
    public string color = "red";
    public string type = "SUV";
    public string model = "XUV 700";
}

class Bike
{
    
    public string model = "RC390";
    public string color = "orange";
    public int speed = 250;
    public void throttle()
    {
        Console.WriteLine("Now on top speed");
    }
}