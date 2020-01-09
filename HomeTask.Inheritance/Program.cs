using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            
            string[] planeModel = new string[] { "Airbus", "Boeing", "Bombardier", "Bombardier", "Saab"}; 
            
            int totalPassangers = 0;
            int totalWeight = 0;

            //Total number of Airplanes 
            int planeNum = 10;

            //Number of the PassangerAirplanes
            int planePasNum = planeNum - r.Next(2,7);

            PassengerAirplane[] plane = new PassengerAirplane[planePasNum];

            for (int i = 0; i < planePasNum; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t*** Passanger Airplane {i+1} ***\n");
                Console.ResetColor();
                plane[i] = new PassengerAirplane(r.Next(100, 500), planeModel[r.Next(planeModel.Length)]);
                totalPassangers += plane[i].Capasity();
            }
            Console.WriteLine($"***********************************\n" +
                $"Total amount of passangers is: {totalPassangers}\n" +
                $"***********************************\n");


            //Number of the CargoAirplanes
            int planeCaargoNum = planeNum-planePasNum;

            CargoAirplane[] planeCargo = new CargoAirplane[planeCaargoNum];
            
            for (int i = 0; i < planeCaargoNum; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t*** Cargo Airplane {i + planePasNum + 1} ***\n");
                Console.ResetColor();

                planeCargo[i] = new CargoAirplane(r.Next(100, 500), planeModel[r.Next(planeModel.Length)]);
                totalWeight += planeCargo[i].Capasity();
            }
            Console.WriteLine(  $"\n***************************************************\n" +
                                $"Total amount of weight that planes can lift is: {totalWeight}\n" +
                                $"***************************************************\n");

            Console.WriteLine(plane[0]);
            
            
            Console.ReadLine();
         
        }
    }
}
