using Cars;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CreatorBeggareCar : Taxi // реализация фабрики
    {
        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, bool ServicePermission, uint Price, uint CargoWeight, uint NumberOfKilometers)
        {
            return new BeggareCar(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity, ServicePermission, Price, CargoWeight, NumberOfKilometers);
        }
      

    }
}
