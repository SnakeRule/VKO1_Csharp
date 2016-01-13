using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGrades_Tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string points;
            Console.Write("Enter points 0-12 : ");
            points = Console.ReadLine();
            int grade;
            bool success = int.TryParse(points, out grade);

            if (success)
            {

                switch (grade)
                {
                    case 0:

                    case 1: Console.WriteLine("0"); break;

                    case 2:

                    case 3: Console.WriteLine("1"); break;

                    case 4:

                    case 5: Console.WriteLine("2"); break;

                    case 6:

                    case 7: Console.WriteLine("3"); break;

                    case 8:

                    case 9: Console.WriteLine("4"); break;

                    case 10:

                    case 11:

                    case 12: Console.WriteLine("5"); break;

                    default: Console.WriteLine("Invalid input!"); break;
                }
            }
            else Console.WriteLine("Invalid input!");

            Console.ReadLine();
        }
    }
}
