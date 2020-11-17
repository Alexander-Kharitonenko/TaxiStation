using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Engine : IEngine
    {
        public virtual float FuelСonsumption()
        {
 
            Console.WriteLine("Consumption not determined");
            return 0.0f;
                
        }
    }
}
