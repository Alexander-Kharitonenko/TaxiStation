using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorMiddlCar : Taxi // реализация фабрик
    {
        public override Car Criate()
        {

            return new MiddleСars("TannedPriora", 4 , 400, 200, 50);
        }
    }
}
