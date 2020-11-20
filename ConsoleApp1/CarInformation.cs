using Cars;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CarInformation
    {

        public const string Path = @"C:\Users\Александр\Desktop\С#\Проект25 - ДЗ ООП\ConsoleApp1\ConsoleApp1\Data\";


        public static void GetTaxiBonus(Car[] TaxiStation) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select the taxi class you want to travel 1 - Elite 2 - Medium 3 - Poor");
            Console.ResetColor();
            Console.WriteLine();
            try
            {
                string Text = Console.ReadLine();
                int number = Int32.Parse(Text);
                if (number <= 3 | number > 0)
                {
                    CarInformation.GetBonus(number, TaxiStation);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered the wrong number, you need to enter from 1 to 3");
                    Console.ResetColor();
                    Program.Main();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }



        public static void GetCarBySpeed(Car[] TaxiStation)
        {
            try
            {


                Console.WriteLine("Find a car by speed ? ");
                Console.WriteLine();
                Console.WriteLine("If yes press Y if no press N");
                string Text1 = Console.ReadLine();
                if (Text1 == "Y")
                {

                    Console.WriteLine("Enter speed");
                    string Text_spid = Console.ReadLine();
                    uint SpidCar = UInt32.Parse(Text_spid);
                    SortedBySpeed(TaxiStation, SpidCar);
                    GetCarBySpeed(TaxiStation);

                }
                else if (Text1 == "N")
                {
                    return;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }



        private static void SortedBySpeed(Car[] TaxiStation , uint Spid)
        {
            if(TaxiStation != null) 
            {
                for (int i = 0; i < TaxiStation.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (Spid > 400 & Spid <= TaxiStation[i].MaxSpeed)
                    {
                        
                        Console.WriteLine($"The machine at a given speed is {TaxiStation[i].BrandCar}");break;
                        
                    }
                    else if (Spid > 200 & Spid <= TaxiStation[i].MaxSpeed)
                    {

                        Console.WriteLine($"The machine at a given speed is {TaxiStation[i].BrandCar}"); break;

                    }
                    else if (Spid > 50 & Spid <= TaxiStation[i].MaxSpeed)
                    {

                        Console.WriteLine($"The machine at a given speed is {TaxiStation[i].BrandCar}"); break;

                    }
                    Console.ResetColor();
                }
            }

   
        }

        public static uint GetTaxiFleetPrice(Car[] TaxiStation)
        {
            uint Result = 0;
            for (int i = 0; i < TaxiStation.Length; i++)
            {
                Result += TaxiStation[i].PriceCar;
            }
            return Result;
        }
        public static void SortCar(Car[] TaxiStation)
        {
            Array.Sort(TaxiStation, new Sorter());
            foreach (var car in TaxiStation)
            {
                car.FuelСonsumption();
            }

        }
        private static void GetBonus(int typeTaxi, Car[] TaxiStation)
        {

            FileStream Elitfile = File.OpenRead($"{Path}\\BonusElitCar.txt");
            FileStream Midlefile = File.OpenRead($"{Path}\\BonusMidlCar.txt");
            FileStream Beggerfile = File.OpenRead($"{Path}\\BonusBiggerCar.txt");
            switch (typeTaxi)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have chosen an ELITE taxi, you want to get a cool bonus??");
                    Console.WriteLine();
                    Console.WriteLine("If yes press Y if no press N");
                    Console.ResetColor();
                    string Text1 = Console.ReadLine();
                    if (Text1 == "Y")
                    {
                        TaxiStation[2].GetBonusfromTaxi(Elitfile); break;

                    }
                    else if (Text1 == "N")
                    {
                        Environment.Exit(0); break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered the wrong character, try to repeat all the steps again");
                        Console.ResetColor();
                        Program.Main(); break;
                    }
                   
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have chosen a MIDDLE class taxi, you want to get a class bonus??");
                    Console.WriteLine();
                    Console.WriteLine("If yes press Y if no press N");
                    Console.ResetColor();
                    string Text2 = Console.ReadLine();
                    if (Text2 == "Y")
                    {
                        TaxiStation[1].GetBonusfromTaxi(Midlefile);
                        Program.Main(); break;

                    }
                    else if (Text2 == "N")
                    {
                        Environment.Exit(0); break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered the wrong character, try to repeat all the steps again");
                        Console.ResetColor();
                        Program.Main(); break;
                    }

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have chosen a BEACH class taxi, you want to get a class bonus??");
                    Console.WriteLine();
                    Console.WriteLine("If yes press Y if no press N");
                    Console.ResetColor();
                    string Text3 = Console.ReadLine();
                    if (Text3 == "Y")
                    {
                        TaxiStation[0].GetBonusfromTaxi(Beggerfile);
                        Program.Main(); break;

                    }
                    else if (Text3 == "N")
                    {
                        Environment.Exit(0); break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered the wrong character repeat all actions again");
                        Console.ResetColor();
                        Program.Main(); break;
                    }

            }
            GetTaxiBonus(TaxiStation);
            
        }
    }
}
