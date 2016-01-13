using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seconds : ");
            string input;
            input = Console.ReadLine();
            int seconds;
            seconds = int.Parse(input);
            int hours = 0;
            int minutes = 0;

            while (seconds > 3600)
            {
                    hours++;
                    seconds = seconds - 3600;
            }
            while (seconds > 60)
            {
                minutes++;
                seconds = seconds - 60;
            }

            Console.Write(hours);
            Console.Write(" hours, ");
            Console.Write(minutes);
            Console.Write(" minutes and ");
            Console.Write(seconds);
            Console.WriteLine(" seconds.");

            Console.Read();
        }
    }
}
