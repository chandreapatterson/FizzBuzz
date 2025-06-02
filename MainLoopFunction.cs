using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class MainLoopFunction
    {
        public static void runLoop()
        {   
            // Continuous loop
            while (true) {

                // Store user input
                string userInput = UserInputFunction.getStr();

                // Check for non-number
                bool errorPresent = ErrorHandlingFunction.NumTry(userInput);

                // Check user input for number or q to quit
                if (userInput.Equals("0"))
                {
                    Console.WriteLine("Number must be an integer greater than 0.");
                    continue;
                }
                else if (!userInput.Equals("q") & !errorPresent)
                {
                    // Convert input to double data type
                    double numInput = ConvertToNumFunction.GetNum(userInput);

                    // Perform mod
                    CalcModFunction.calcMod(numInput);
                }
                else if (!userInput.Equals("q") & errorPresent)
                {
                    Console.WriteLine("Please enter a number or enter q to quit...");
                    // Continue
                    continue;
                }
                else
                {
                    // Quit program
                    ExitFunction.exitProg();
                }
            }
        }
    }
}
