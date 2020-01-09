using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Inheritance
{
    class CargoAirplane : Airplane
    {
        Random liftingCapasity = new Random();
        public int Capacity { get; set; }
        public CargoAirplane(int sideNumber, string model) : base(sideNumber, model)
        {
        }

        public override int Capasity()
        {
            int capasityCargo = liftingCapasity.Next(50, 100);
            Console.WriteLine($"\nCurrent Cargo Plane can lift {capasityCargo} tones\n");
            return capasityCargo;
        }

        
    }
}
