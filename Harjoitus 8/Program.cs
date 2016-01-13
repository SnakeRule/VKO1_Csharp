using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmb1;
            int nmb2;
            int nmb3;

            Console.WriteLine("Please enter three numbers");

            nmb1 = int.Parse(Console.ReadLine());
            nmb2 = int.Parse(Console.ReadLine());
            nmb3 = int.Parse(Console.ReadLine());

            if (nmb1 > nmb2 && nmb1 > nmb3)
                Console.WriteLine("{0} is the biggest number!", nmb1);

            else if (nmb2 > nmb1 && nmb2 > nmb3)
                Console.WriteLine("{0} is the biggest number!", nmb2);

            else
                Console.WriteLine("{0} is the biggest number!", nmb3);
        }
    }
}
