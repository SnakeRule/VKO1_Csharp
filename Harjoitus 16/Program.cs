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
            int guesses = 0;
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
                    guesses++;
                }
                else if (input > rndvalue)
                {
                    Console.WriteLine("The number is smaller!");
                    guesses++;
                }

            } while (loop == true);

            Console.WriteLine("You guessed {0} Times.", guesses);

            Console.Read();
        }
    }
}
