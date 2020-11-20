using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{
   public class MiddleСars : Car
    {
        public override bool ServicePermission { get; set; }

        public uint Price { get; set; }

        public uint NumberOfKilometers { get; set; }
        public uint CargoWeight { get; set; }

        public MiddleСars(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity, bool ServicePermission, uint Price, uint CargoWeight,uint NumberOfKilometers) : base(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity)
        {
            this.ServicePermission = ServicePermission;
            this.Price = Price;
            this.CargoWeight = CargoWeight;
            this.NumberOfKilometers = NumberOfKilometers;
        }
        
        public override float FuelСonsumption()
        {
            
            if (TankСapacity != 0)
            {

                TankСapacity = (TankСapacity / 100) * 10;
                Console.WriteLine($"Fuel consumption of a car of the middle class {TankСapacity} liters per 100 km");
                return TankСapacity;
            }
            else
            {
                return 0.0f;
            }
        }

       

        public override void GetBonusfromTaxi(FileStream file)
        {
            if (file != null)
            {
                byte[] array = new byte[file.Length];//создаём массив размерностью равной file

                file.Read(array, 0, array.Length); // считываем даннные с файла

                string textFromFile = System.Text.Encoding.Default.GetString(array);// декодируем байты в строку
                Console.WriteLine($"{textFromFile}");
            }
            else
            {
                throw new Exception("File is missing");
            }
        }

        public override void CargoTransportationServices()
        {
            if (this.ServicePermission)
            {
                Price = this.Price * this.CargoWeight;
                Console.WriteLine($"portation cost-{Price}$");
            }
            else
            {
                Price = this.Price * this.NumberOfKilometers;
                Console.WriteLine($"Payment for travel-{Price}$"); ;
            }
        }

    }
}
