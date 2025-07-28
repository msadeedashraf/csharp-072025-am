//Change the name of the namespace to your project name
using inheritance_example;

namespace Inheritance_Example
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            Car car1 = new Car() { Color="Red", Make="Honda", Model= "CRV", Year=2022, NumberOfDoor=4 };

            Console.WriteLine($"I'm driving {car1.Color} {car1.NumberOfDoor} door {car1.Make} year {car1.Year}, model is {car1.Model}");

            Truck truck1 = new Truck() { Color = "Black", Make = "Ford", Model = "150", Year = 2024, CargoCapacity = 6000 };
            Console.WriteLine($"I'm driving {truck1.Color} {truck1.Make} year {truck1.Year}, model is {truck1.Model} with a cargo capaticity of {truck1.CargoCapacity}lb");

            Motorcycle m1 = new Motorcycle() { Color = "Orange", Make = "Suzuki", Model = "abc", Year = 2025, NumberOfWheels=2 };
            Console.WriteLine($"I'm driving a {m1.NumberOfWheels} wheeler {m1.Color} {m1.Make} year {m1.Year}, model is {m1.Model}.");




        }

    }


}