using System;
using System.Collections.Generic;
using System.Text;

namespace _4._16._2022.Models
{
    class Car : Vehicle
    {
        private static int _speed;
        public string Brand;
        public string Model;
        public int MaxSpeed
        {
            get
            { return _speed; }
            set 
            {
                if (value>=0 && value<=260)
                {
                    _speed = value;
                }
            }
        }


        public Car(int year,string brand,string model):base(year)
        {
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color: {Color}- Year: {Year} - Brand {Brand} - Model {Model}");
        }
    }
}
