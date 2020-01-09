using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Inheritance
{
    class Crew
    {
        Random r = new Random();
        public Crew()
        {

            //Console.WriteLine("\t#########\n");
            Console.WriteLine($"Commander: {Generate()}");
            Console.WriteLine($"2nd pilot: {Generate()}");
            Console.WriteLine($"Navigator: {Generate()}");

            for (int i = 0; i < r.Next(1, 5); i++)
            {
                Console.WriteLine($"Member {i + 1}: {Generate()}");
            }
            //Console.WriteLine($"Commander: {Generate()}");
        }

        public string Generate()
        {
            return $"\t{Convert.ToString((Dictionary.FirstName)r.Next(Enum.GetNames(typeof(Dictionary.FirstName)).Length))} {Convert.ToString((Dictionary.SecondName)r.Next(Enum.GetNames(typeof(Dictionary.SecondName)).Length))}. Age: {r.Next(20, 60)} years";
        }

        public override string ToString()
        {
            return $"Commander: {Generate()}";
        }
    }
}
