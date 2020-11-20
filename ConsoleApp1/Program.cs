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
            Car Elite_Car = new CreatorEliteCar().Create();
            Car Middle_Car = new CreatorMiddleCar().Create();
            Car Beggare_Car = new CreatorBeggareCar().Create();

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
            CarInformation. GetCarBySpeed(TaxiStation);
            CarInformation.GetTaxiBonus(TaxiStation);

       }

    }
}
