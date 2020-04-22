/* Nathan Peereboom
 * April 22, 2020
 * Problem J2: Mod Inverse
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312840ModInverse
{
    class Program
    {
        //global variables
        static int x;
        static int m;
        static int modInverse;
        static bool foundInverse = false;

        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Enter x:");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter m:");
            int.TryParse(Console.ReadLine(), out m);

            //Find modular inverse
            for (int n = 1; n < m; n++)
            {
                //If n is modular inverse
                if ((x * n) % m == 1)
                {
                    foundInverse = true;
                    modInverse = n;
                    break;
                }
            }

            //Output
            if (foundInverse)
            {
                Console.WriteLine();
                Console.WriteLine(modInverse);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No such integer exists");
            }

            //End program
            Console.ReadLine();
        }
    }
}
