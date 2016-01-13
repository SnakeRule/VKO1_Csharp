using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.Write("Enter a number ");
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i != input; i++)
            {
                for (int u = -1; u != i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
