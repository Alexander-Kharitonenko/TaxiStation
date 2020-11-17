using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorElitCat : Taxi // реализация фабрики
    {
        public override Car Criate()
        {

            return new EliteСar("BatmanCar", 2 , 1000000, 400 , 70);
        }
    }
}
