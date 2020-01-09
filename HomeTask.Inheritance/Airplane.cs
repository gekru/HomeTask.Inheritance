using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Inheritance
{
    abstract class Airplane 
    {
        public int SideNumber { get; set; }
        public string Model { get; set; }
        public Crew Crew { get; set; }

        public Airplane(int sideNumber, string model)
        {
            SideNumber = sideNumber;
            Model = model;
            Crew Crew = new Crew();
            Console.WriteLine($"\nSide number:\t{SideNumber}\nModel:\t\t{Model}");
        }

        public abstract int Capasity();
        public override string ToString()
        {
            return $"\nSide number:\t{SideNumber}\n" +
                   $"Model:\t\t{Model}\n";
        }
    }
}
