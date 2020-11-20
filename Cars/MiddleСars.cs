using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{
   public class MiddleСars : Car
    {
       
        public MiddleСars(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpeed, uint TankСapacity) : base(BrandCar, PassengerSeats, PriceCar, MaxSpeed, TankСapacity)
        {
            this.BrandCar = BrandCar;
            this.PassengerSeats = PassengerSeats;
            this.PriceCar = PriceCar;
            this.MaxSpeed = MaxSpeed;
            this.TankСapacity = TankСapacity;
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

       
   }
}
