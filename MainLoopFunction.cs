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
            string userInput = UserInputFunction.getStr();
            double numInput = ConvertToNumFunction.GetNum(userInput);
        }
    }
}
