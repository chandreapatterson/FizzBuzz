using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class ExitFunction
    {
        public static void exitProg()
        {
            Console.WriteLine("The program will now exit.");
            Environment.Exit(0);
        }
    }
}
