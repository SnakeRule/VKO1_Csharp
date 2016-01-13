using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;

            do
            {
                Console.Write("Please enter a number : ");
                input = int.Parse(Console.ReadLine());
                sum = sum + input;
            } while (input != 0);

            Console.Write("The sum of the numbers you entered is {0}", sum);

            Console.Read();
        }
    }
}
