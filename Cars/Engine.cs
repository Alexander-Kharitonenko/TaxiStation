using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Engine : IEngine
    {
        public virtual void FuelСonsumption()
        {
 
                Console.WriteLine("Consumption not determined");
                
        }
    }
}
