using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{
    public abstract class Car : Engine
    {
        
        public  string BrandCar { get; set; }// марка машины

        public  uint PassengerSeats { get; set; } //количество мест

        public  uint PriceCar { get; set; } // цена

        public  uint MaxSpeed { get; set; } // саксимальная скорость 

        public  float TankСapacity { get; set; }// бак

        public abstract bool ServicePermission { get; set; }






        public Car(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity)
        {
            this.BrandCar = BrandCar;
            this.PassengerSeats = PassengerSeats;
            this.PriceCar = PriceCar;
            this.MaxSpeed = MaxSpeed;
            this.TankСapacity = TankСapacity;
        }
        public abstract void GetBonusfromTaxi(FileStream file);

        public abstract void CargoTransportationServices();
    }
}

