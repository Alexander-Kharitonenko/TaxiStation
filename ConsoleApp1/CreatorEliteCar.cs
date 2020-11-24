using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CreatorEliteCar : Taxi // реализация фабрики
    {
        public override Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, uint Price, uint CargoWeight, uint NumberOfKilometers, bool RideWithMusic)
        {

            return new EliteСar(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity,Price, NumberOfKilometers, RideWithMusic);
        }
    }
}
