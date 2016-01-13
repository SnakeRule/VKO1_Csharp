using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            int[] table1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] table2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] table3 = new int[10];

            for (int i = 0; i !=5; i++)
            {
                table3[i] = table1[i];
            }

            for (int i = 5; i !=10; i++)
            {
                table3[i] = table2[o];
                o++;
            }

            Array.Sort(table3);

            for (int i = 0; i != 10; i++)
            {
                Console.WriteLine(table3[i]);
            }
        }
    }
}
