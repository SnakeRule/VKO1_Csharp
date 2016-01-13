using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program.Main();

namespace PrintNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysytään käyttäjältä luku
            Console.Write("Anna luku 1-3 : ");
            string rivi = Console.ReadLine(); // "1"
            // int luku = int.Parse(rivi); // 1
            int luku;
            bool onnistuiko = int.TryParse(rivi, out luku);
            if (onnistuiko)
            {
                // tulostetaan luku "sanana"
                switch (luku)
                {
                    case 1: Console.WriteLine("Yksi"); break;

                    case 2: Console.WriteLine("Kaksi"); break;

                    case 3: Console.WriteLine("Kolme"); break;

                    default: Console.WriteLine("Joku muu luku"); break;
                }
            }
            else
            {
                Console.WriteLine("Et antanut lukua, pelle");
            }

            Console.ReadLine();
        }
    }
}
