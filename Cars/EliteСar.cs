using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Markup;

namespace Cars
{
    public class EliteСar : Car, IEngine
    {
        public bool RideWithMusic;

        public uint Price { get; set; }

        public uint NumberOfKilometers { get; set; }

        public uint MusicСoefficient { get; set; }

        public EliteСar(string BrandCar, uint PassengerSeats, uint PriceCar, uint MaxSpid, uint TankСapacity, uint Price, uint MusicСoefficient, bool RideWithMusic) : base(BrandCar, PassengerSeats, PriceCar, MaxSpid, TankСapacity)
        {
           
            this.Price = Price;
            this.NumberOfKilometers = NumberOfKilometers;
            this.MusicСoefficient = MusicСoefficient;
            this.RideWithMusic = RideWithMusic;
        }

        public override float FuelСonsumption()
        {
            
            if (TankСapacity != 0)
            {

                TankСapacity = (TankСapacity / 100) * 9;    
                Console.WriteLine($"Fuel consumption of elite cars {TankСapacity} liters per 100 km");
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

        public void RadioСassette()
        {
            if (this.RideWithMusic)
            {
                var reader = new Mp3FileReader(@"C:\Users\Александр\Desktop\С#\Проект25 - ДЗ ООП\ConsoleApp1\ConsoleApp1\Data\Music\Sound_06787.mp3");
                var waveOut = new WaveOutEvent(); // or WaveOutEvent()
                waveOut.Init(reader);
                waveOut.Play();
            }
            else 
            {
                Console.WriteLine("You booked a quiet ride");
            }


        }

        public void PaymentForTheTrip()
        {
            if (this.RideWithMusic)
            {
                Price += Price + NumberOfKilometers * MusicСoefficient;
                Console.WriteLine($"Payment for travel - {Price}");
            }
            else 
            {
                Price += Price + NumberOfKilometers;
                Console.WriteLine($"Payment for travel - {Price}");
            }
        }
    }
}
