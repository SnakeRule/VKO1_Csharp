using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[6];
            bool loop = true;
            int input;
            int i = 0;

            Console.WriteLine("You can stop entering grades by typing 6.");

            do
            {
                Console.Write("Enter grade 0-5 : ");
                input = int.Parse(Console.ReadLine());
                if (input == 6)
                    break;
                if (input < 0 || input > 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                grades[input]++;

            } while (loop == true);


            Console.WriteLine("Grades:");

            for (i = 0; i != 6; i++)
            {
                Console.Write("{0}: ", i);
                for (int u = 0; u != grades[i]; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
