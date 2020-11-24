using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Cars
{
   public class BeggareCar : Car , IEngine
    {

        

        public uint Price { get; set; }

        public uint NumberOfKilometers { get; set; }

        public uint CargoWeight { get; set; }

        public BeggareCar(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpid, uint TankСapacity , uint Price, uint CargoWeight, uint NumberOfKilometers) : base(BrandCar, PassengerSeats, PriceCar, MaxSpid, TankСapacity)
        {
            
            this.Price = Price;
            this.CargoWeight = CargoWeight;
            this.NumberOfKilometers = NumberOfKilometers;

        }
       

        public override float FuelСonsumption()
        {
            if (TankСapacity != 0)
            {
                
                Console.WriteLine($"Fuel consumption: Come on {TankСapacity} bottles of vodka and drove");
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

        public void PaymentForTheTrip()
        {

            Price += Price + NumberOfKilometers * CargoWeight;
            Console.WriteLine($"Payment for travel - {Price}$ and bonuses are not provided :)");

        }



    }
}
