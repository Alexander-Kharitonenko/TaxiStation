using Cars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sorter : IComparer
    {
        public int Compare(Object x, Object y)
        {
            Car car1 = x as Car;
            Car car2 = y as Car;
            if (car1 != null | car2 != null)
            {
                if (car1.TankСapacity > car1.TankСapacity)
                    return 1;
                else if (car1.TankСapacity < car1.TankСapacity)
                    return -1;
                else
                    return 0;
            }
            else
            {
                throw new Exception("Can't compare two objects");
            }
        }
    }
}
