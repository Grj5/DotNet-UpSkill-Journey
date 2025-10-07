using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    // OOP/InheritanceExample.cs

    public class Vehicle
    {
        public string Brand { get; set; }
        public void Start() => Console.WriteLine($"{Brand} started.");
    }

    public class Car : Vehicle
    {
        public int Doors { get; set; }
        public void Honk() => Console.WriteLine($"{Brand} is honking!");
    }

    class Inheritance
    {
        static void Main()
        {
            var car = new Car { Brand = "Tesla", Doors = 4 };
            car.Start();
            car.Honk();
        }
    }

}
