using Cars;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CreatorBeggareCar : Taxi // реализация фабрики
    {
        public override Car Create()
        {
            return new BeggareCar("ManWithCart", 1, 100 , 20, 2);
        }
      

    }
}
