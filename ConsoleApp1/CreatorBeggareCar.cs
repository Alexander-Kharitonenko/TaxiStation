using Cars;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CreatorBeggareCar : Taxi // реализация фабрики
    {
        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, uint Price, uint CargoWeight, uint NumberOfKilometers , bool ServicePermission = false)
        {
            return new BeggareCar(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity, Price, CargoWeight, NumberOfKilometers);
        }
      

    }
}
