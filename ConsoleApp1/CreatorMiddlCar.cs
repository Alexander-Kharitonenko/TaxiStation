using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorMiddleCar : Taxi // реализация фабрик
    {
        

        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpееd, uint TankСapacity, uint Price, uint CargoWeight, uint NumberOfKilometers , bool ServicePermission = false)
        {
            return new MiddleСars(BrandCar, PassengerSeats, PriceCar, MaxSpееd, TankСapacity,Price, CargoWeight, NumberOfKilometers, ServicePermission);
        }
    }
}
