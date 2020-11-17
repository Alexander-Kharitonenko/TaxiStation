using Cars;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CreatorBeggareCar : Taxi // реализация фабрики
    {
        public override Car Criate()
        {
            return new BeggarCar("ManWithCart", 1, 100 , 20, 2);
        }
      

    }
}
