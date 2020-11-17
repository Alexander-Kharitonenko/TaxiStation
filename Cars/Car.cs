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

        public  uint MaxSpid { get; set; } // саксимальная скорость 

        public  float TankСapacity { get; set; }// бак

       



        public Car(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpid, uint TankСapacity)
        {
            this.BrandCar = BrandCar;
            this.PassengerSeats = PassengerSeats;
            this.PriceCar = PriceCar;
            this.MaxSpid = MaxSpid;
            this.TankСapacity = TankСapacity;
        }
        public abstract void GetBonusfromTaxi(FileStream file);



       
    }
}

