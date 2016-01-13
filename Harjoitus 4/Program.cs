using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageinput;
            int age;
            Console.WriteLine("Please enter your age.");
            ageinput = Console.ReadLine();
            age = int.Parse(ageinput);

            if (age < 18)
            {
                Console.WriteLine("Underage");
            }
            else if (age > 17 && age < 66)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior");
            }
            Console.Read();
        }
    }
}
