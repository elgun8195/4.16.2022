using System;
using System.Collections.Generic;
using System.Text;

namespace _4._16._2022.Models
{
    abstract class Vehicle
    {
        public string Color;
        public int Year;
        public Vehicle(int year)
        {
            Year = year;
        }
        public abstract void  ShowInfo();
    }
}
