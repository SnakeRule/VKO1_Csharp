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
            int guess_number = 0;
            bool loop = true;
            int fails = 0;
            char[] input = new char[1];

        

            while (loop == true)
            {
                Console.WriteLine();
                Console.WriteLine(guesses);
                Console.WriteLine(underlines);
                Console.WriteLine();
                Console.Write("Enter a CAPITAL letter: ");
                
                input[0] = Console.ReadKey().KeyChar;
                Console.WriteLine();
                for (int i = 0; i != 10; i++)
                {
                    if (input[0] == word[i])
                    {
                        guess_number = i;
                        guesses[i] = word[i];
                        underlines[i] = ' ';
                    }
                }

                if (guesses[guess_number] == guesses_last[guess_number])
                {
                    Console.WriteLine(" Wrong");
                    fails++;
                }

                switch (fails)
                {
                    case 1: Console.WriteLine("You can still fail THREE more times!"); break;

                    case 2: Console.WriteLine("You can still fail TWO more times!"); break;

                    case 3: Console.WriteLine("You can still fail ONE more time!"); break;

                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("You're dead!");
                            loop = false;
                            break;
                        }
                }
                for (int i = 0; i != 10; i++)
                {
                    if (guesses[i] == word[i])
                    {
                        if (i == 9)
                        {
                            Console.WriteLine();
                            Console.WriteLine(guesses);
                            Console.WriteLine(underlines);
                            Console.WriteLine();
                            Console.WriteLine("You win!");
                            loop = false;
                            break;
                        }
                    }
     
                    else
                        break;
                }

                    Array.Copy(guesses, guesses_last, 10);
            }


       }
    }
}
