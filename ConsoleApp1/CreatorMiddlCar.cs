using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorMiddleCar : Taxi // реализация фабрик
    {
        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, bool ServicePermission, uint Price, uint CargoWeight, uint NumberOfKilometers)
        {

            return new MiddleСars(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity,ServicePermission, Price, CargoWeight, NumberOfKilometers);
        }
    }
}
