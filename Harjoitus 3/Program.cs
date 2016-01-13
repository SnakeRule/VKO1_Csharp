using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3_kerta_1
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Give the first number");
                string line1;
                int nmb1;
                line1 = Console.ReadLine();
                nmb1 = int.Parse(line1);

            Console.WriteLine("Give the second number");
            string line2;
            int nmb2;
            line2 = Console.ReadLine();
            nmb2 = int.Parse(line2);

            Console.WriteLine("Give the third number");
            string line3;
            int nmb3;
            line3 = Console.ReadLine();
            nmb3 = int.Parse(line3);

            int average = (nmb1 + nmb2 + nmb3) / 3;

            Console.WriteLine(average);


        }
    }
}
