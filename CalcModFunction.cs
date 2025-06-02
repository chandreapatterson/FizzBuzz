using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class CalcModFunction
    {
        public static void calcMod(double calcNumMod)
        {

            // Check if input is divisible by 3
            if (calcNumMod % 3 is 0)
            {
                // Output Fizz if input divisible by 3
                Console.WriteLine("Fizz!");
            }

            // Check if input is divisible by 5
            if (calcNumMod % 5 is 0)
            {
                // Output Buzz if input divisible by 5
                Console.WriteLine("Buzz!");
            }

            // Check if not divisible by 3 or 5
            if ((!(calcNumMod % 3 is 0)) & (!(calcNumMod % 5 is 0)))
            {
                // Output message if not divisible by 3 or 5
                Console.WriteLine("Not divisible by 3 or 5");
            }
        }
    }
}

