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
            Car Elite_Cat = new CreatorElitCat().Criate();
            Car Middl_Cat = new CreatorMiddlCar().Criate();
            Car Beggare_Cat = new CreatorBeggareCar().Criate();

            Car[] TaxiStation = { Elite_Cat, Middl_Cat, Beggare_Cat };

            uint Prise = CarInformation.GetTaxiFleetPrice(TaxiStation);


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
            Console.WriteLine($"The cost of our taxi fleet is - {Prise}$");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cars sorted by speed");
            CarInformation.SortCar(TaxiStation);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            while (true)
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

        }
        

    }
}
