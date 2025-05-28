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

                // Check user input for number or q to quit
                if (!userInput.Equals("q"))
                {
                    // Convert input to double data type and perform mod
                    double numInput = ConvertToNumFunction.GetNum(userInput);
                    CalcModFunction.calcMod(numInput);
                }
                else
                {
                    // Break out of loop
                    break;
                }
            }

            // Quit program with exit code 0
            ExitFunction.exitProg();
        }
    }
}
