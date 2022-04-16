using _4._16._2022.Models;
using System;

namespace _4._16._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle[] vehicles = new Vehicle[0];

            Car car = new Car(2000, "Lada", "Niva");
            car.Color = "red";
            car.MaxSpeed = 200;
            //car.ShowInfo();


            Bus bus = new Bus(2008);
            bus.PassengherCount = 35;
            //bus.ShowInfo();

            Vehicle[] vehicles =
            {
                car,bus
            };

            

            foreach (Vehicle item in vehicles)
            {
                item.ShowInfo();
            }
            
        }
    }
}
