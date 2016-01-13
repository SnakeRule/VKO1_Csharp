using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for(int i = 0; i < 9; i++)
            {
                Console.Write(numbers[i]);
                if (numbers[i] % 2 == 0)
                    Console.Write("HEP");
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
