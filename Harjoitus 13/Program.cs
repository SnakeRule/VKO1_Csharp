using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];
            int total_points = 0;
            int u;

            for (int i = 0; i != 5; i++)
            {
                Console.Write("Give points: ");
                points[i] = int.Parse(Console.ReadLine());

                total_points = total_points + points[i];
            }

            for (int i = 0; i !=5; i++)
            {
                for (u = 0; u != 5; u++)
                {
                    if (points[i] < points[u])
                        break;
                        if (points[i] >= points[u])
                    {
                        if (u == 4)
                        {
                            total_points = total_points - points[i];
                        }

                    }
                }
                if (u == 5)
                    break;
            }

            for (int i = 0; i != 5; i++)
            {
                for (u = 0; u != 5; u++)
                {
                    if (points[i] > points[u])
                        break;

                    if (points[i] <= points[u])
                    {
                        if (u == 4)
                        {
                            total_points = total_points - points[i];
                            break;
                        }

                    }
                }
                if (u == 4)
                    break;
            }

            Console.WriteLine("The points are {0}", total_points);
        }
    }
}
