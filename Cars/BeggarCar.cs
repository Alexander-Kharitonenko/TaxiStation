using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cars
{
   public class BeggarCar : Car , IEngine
    {

        

        public BeggarCar(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpid, uint TankСapacity) : base(BrandCar, PassengerSeats, PriceCar, MaxSpid, TankСapacity)
        {
            this.BrandCar = BrandCar;
            this.PassengerSeats = PassengerSeats;
            this.PriceCar = PriceCar;
            this.MaxSpid = MaxSpid;
            this.TankСapacity = TankСapacity;
        }
       

        public override void FuelСonsumption()
        {
            if (TankСapacity != 0)
            {
                Console.WriteLine($"Fuel consumption: Come on {TankСapacity} bottles of vodka and drove");
               
            }
            else
            {
               base.FuelСonsumption();
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
