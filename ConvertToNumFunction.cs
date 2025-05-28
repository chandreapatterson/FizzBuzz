using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // Static since multiple instances will not be needed each run
    public static class ConvertToNumFunction
    {
        public static double GetNum(string userInput)
        {
            // Convert user input to double type
            double numInput = Convert.ToDouble(userInput);

            // Return numInput double
            return numInput;
        }
    }
}
