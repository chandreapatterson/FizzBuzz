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
            while (true) {

                string userInput = UserInputFunction.getStr();

                if (!userInput.Equals("q"))
                {
                    double numInput = ConvertToNumFunction.GetNum(userInput);
                    CalcModFunction.calcMod(numInput);
                }
                else
                {
                    break;
                }
            }

            ExitFunction.exitProg();

        }
    }
}
