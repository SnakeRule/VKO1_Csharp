using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i !=5; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The numbers are: ");

            for (int i = 4; i != -1; i--)
            {
                Console.Write("{0}, ", numbers[i]);
            }

            Console.Read();
        }
    }
}
