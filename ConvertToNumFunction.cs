using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlayground
{
    // Static since multiple instances will not be needed each run
    public static class ConvertToNumFunction
    {
        public static double GetNum()
        {
            // Prompt user to enter number
            Console.WriteLine("Enter a number: ");

            // Store user input
            string userInput = Console.ReadLine();

            // Convert user input to double type
            double numInput = Convert.ToDouble(userInput);

            return numInput;
        }
    }
}
