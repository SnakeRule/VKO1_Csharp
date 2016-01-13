using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = new char[10] { 'H', 'E', 'L', 'L', 'O', 'W', 'O', 'R', 'L', 'D' };
            char[] underlines = new char[10] { '¯', '¯', '¯', '¯', '¯', '¯', '¯', '¯', '¯', '¯' };
            char[] guesses = new char[10];
            char[] guesses_last = new char[10];
            bool loop = true;
            int fails = 0;
            char[] input = new char[1];

            while (loop == true)
            {
                Console.Write("Enter a CAPITAL letter: ");
                input[0] = Console.ReadKey().KeyChar;

                for(int i = 0; i != 10; i++)
                {
                    if (input[0] == word[i])
                    {
                        guesses[i] = word[i];
                        underlines[i] = ' ';
                    }
                }
                if (guesses == guesses_last)
                {
                    Console.WriteLine("Wrong!");
                    fails++;
                }

                guesses = guesses_last;

                Console.WriteLine();
                Console.WriteLine(guesses);
                Console.WriteLine(underlines);
            }


       }
    }
}
