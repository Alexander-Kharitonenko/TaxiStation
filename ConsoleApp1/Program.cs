using System;
using System.Collections;
using System.IO;
using Cars;

namespace ConsoleApp1
{
    class Program
    {
       public static void Main()
        {
            Car Elite_Car = new CreatorEliteCar().Create("BatmanCar", 2, 1000000, 400, 70, false, 50, 90 , 120);
            Car Middle_Car = new CreatorMiddleCar().Create("TannedPriora", 4, 400, 200, 50, true, 20, 100 , 210);
            Car Beggare_Car = new CreatorBeggareCar().Create("ManWithCart", 1, 100, 20, 2,true, 5 , 60 , 20);

            Car[] TaxiStation = { Beggare_Car, Middle_Car, Elite_Car, };

            uint Price = CarInformation.GetTaxiFleetPrice(TaxiStation);
  
            Console.WriteLine(
                " _______________$$$$$$$$$$$$$$$$$$$'\n'" +
                "______________$$$$_$$$$$$$$$$$$$$$$$'\n'" +
                "____________$$$$_________$$$_______$$$'\n'" +
                "___________$$$___________$$$_________$$$'\n'" +
                "__________$$$$___________$$$__________$$$$'\n'" +
                "__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$'\n'" +
                "_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$'\n'" +
                "_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$'\n'" +
                "__$$$$$$$$$___$$$$$$$$$$$$$$$$$$$$$$$$$___$$$$$$$$'\n'" +
                "_$$$$$$$$_______$$$$$$$$$$$$$$$$$$$$$_______$$$$$$'\n'" +
                "__$$$$$$__$$$$$__$$$$$$$$$$$$$$$$$$$__$$$$$$__$$$'\n'" +
                "_________$$___$$_____________________$$___$$__'\n'" +
                "_________$$___$$_____________________$$$__$$__'\n'" +
                "__________$$$$_________________________$$$$__");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The cost of our taxi fleet is - {Price}$");
            Console.WriteLine();
            Console.WriteLine($"Cars sorted by fuel consumption");
            CarInformation.SortCar(TaxiStation);
            Console.WriteLine();
            Console.WriteLine();
            Elite_Car.CargoTransportationServices();
            Middle_Car.CargoTransportationServices();
            Beggare_Car.CargoTransportationServices();
            Console.WriteLine();
            Console.WriteLine();
            CarInformation. GetCarBySpeed(TaxiStation);
            CarInformation.GetTaxiBonus(TaxiStation);

       }

    }
}
