using System;
namespace ClassesAndObjectss
{
    class Display
    {
        public static void Main(string[] args)
        {
            Car myObj = new Car();
            Bike myObj1 = new Bike();
            Console.WriteLine("Car color: " + myObj.color);
            Console.WriteLine("Car model: " + myObj.model);
            Console.WriteLine("Car type: " + myObj.type);
            Console.WriteLine("Bike model: " + myObj1.model);
            Console.WriteLine("Bike color: " + myObj1.color);
            Console.WriteLine("Bike Max speed: " + myObj1.speed);

            int speed = myObj1.speed;
            Console.WriteLine(speed);

            
            // Bike - 1
            Features Himalayan = new Features();
            Himalayan.model = "Himalayan 350";
            Himalayan.maxSpeed = 250;
            Himalayan.price = 300000;
            Himalayan.groundClearance = "125mm";

            //Bike - 2
            Features Duke390 = new Features();
            Duke390.model = "Duke 390";
            Duke390.maxSpeed = 270;
            Duke390.price = 400000;
            Duke390.groundClearance = "120mm";

            Console.WriteLine("Bike Model: " + Himalayan.model);
            Console.WriteLine("Max Speed: " + Himalayan.maxSpeed);
            Console.WriteLine("Price: " + Himalayan.price);
            Console.WriteLine("Ground Clearance: " + Himalayan.groundClearance);

            Console.WriteLine("Bike Model: " + Duke390.model);
            Console.WriteLine("Max Speed: " + Duke390.maxSpeed);
            Console.WriteLine("Price: " + Duke390.price);
            Console.WriteLine("Ground Clearance: " + Duke390.groundClearance);

            CarConstructor cars = new CarConstructor("Mustang", "AD342");
            Console.WriteLine("Model Name: " + cars.modelName);
            Console.WriteLine("Model Type: " + cars.modelType);

        }
    }
}

    

