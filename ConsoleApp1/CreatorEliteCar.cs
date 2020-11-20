using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorEliteCar : Taxi // реализация фабрики
    {
        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, bool ServicePermission, uint Price, uint CargoWeight, uint NumberOfKilometers)
        {

            return new EliteСar(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity, ServicePermission, Price, CargoWeight, NumberOfKilometers);
        }
    }
}
