using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int rndvalue = random.Next(0, 100);
            int input;
            bool loop = true;

            do
            {
                Console.Write("Guess the number 0-100 : ");
                input = int.Parse(Console.ReadLine());

                if (input == rndvalue)
                {
                    Console.WriteLine("Correct!");
                        loop = false;
                }
                else if (input < rndvalue)
                {
                    Console.WriteLine("The number is bigger!");
                }
                else if (input > rndvalue)
                {
                    Console.WriteLine("The number is smaller!");
                }

            } while (loop == true);

            Console.Read();
        }
    }
}
