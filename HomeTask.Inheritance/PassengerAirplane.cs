using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Inheritance
{
    class PassengerAirplane : Airplane
    {
        Random passangers = new Random();
        public int PassengerQuantity { get; set; }

        public PassengerAirplane(int sideNumber, string model) : base (sideNumber, model)
        {
        }

        public override int Capasity()
        {
            int capasityPas = passangers.Next(100, 200);
            Console.WriteLine($"\nNumber of passengers is {capasityPas}\n");
            return capasityPas;
        }

        
    }
}
