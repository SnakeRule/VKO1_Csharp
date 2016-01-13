using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumption = 7.02;
            double consumptionfinal;
            double gascost = 1.595;
            double gascostfinal;

            string input;
            double distance;

            Console.Write("Enter distance driven in km : ");
            input = Console.ReadLine();

            distance = double.Parse(input);

            consumptionfinal = (consumption * distance) / 100;
            gascostfinal = consumptionfinal * gascost;

            Console.WriteLine("Gas consumption: {0:F2} ", consumptionfinal);
            Console.Write("Gas costs: {0:F2}", gascostfinal);
        }
    }
}
