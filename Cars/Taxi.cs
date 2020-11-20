using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{
    public abstract class Taxi // класс фабричного метода
    {

        public abstract Car Create(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpid, uint TankСapacity, bool ServicePermission, uint Price, uint CargoWeight, uint NumberOfKilometers); // фабричный метод

       
    }
}
