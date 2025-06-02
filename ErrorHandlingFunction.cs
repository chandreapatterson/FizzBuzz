using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class ErrorHandlingFunction
    {
        public static bool NumTry(string userInput)
        {
            try {
                Convert.ToDouble(userInput);
                bool errorPresent = false;
                return errorPresent;
            }
            catch {
                bool errorPresent = true;
                return errorPresent;
            }
        }
    }
}
