using System;
using System.Collections.Generic;
using System.Text;

namespace _4._16._2022.Models
{
    class Bus:Vehicle
    {
        private static int _passengherCount;
        public int PassengherCount
        {
            get { return _passengherCount; }
            set
            {
                if (value!=0)
                {
                    _passengherCount = value;
                }
            }
        }

        public Bus(int year):base(year)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Year: {Year} - PassengerCount: {PassengherCount}");
        }
    }
}
