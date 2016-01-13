using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year;
            year = int.Parse(Console.ReadLine());

             if (year % 400 == 0)
                Console.WriteLine("The year {0} is a leap year!", year);

            else if (year % 100 == 0)
                Console.WriteLine("The year {0} is NOT a leap year!", year);

            else if (year % 4 == 0)
                Console.WriteLine("The year {0} is a leap year!", year);

            else
                Console.WriteLine("The year {0} is NOT a leap year!", year);
        }
    }
}
