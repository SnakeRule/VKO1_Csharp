using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int input_half;

            Console.Write("Enter a number");
            input = int.Parse(Console.ReadLine());
            input_half = input / 2;

            for(int i = 0; i != input; i++)
            {
                for (int o = input_half; o != 0; o--)
                {
                    Console.Write(" ");
   
                }

                for(int u = 0; u != i; u++)
                {
                    Console.Write("*");
                }
                input_half--;
                Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
