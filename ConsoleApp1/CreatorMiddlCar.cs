﻿using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorMiddleCar : Taxi // реализация фабрик
    {
        public override Car Create()
        {

            return new MiddleСars("TannedPriora", 4 , 400, 200, 50);
        }
    }
}
