using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class UserInputFunction
    {
        public static string getStr()
        {
            // Prompt user to enter number
            Console.WriteLine("Enter a number: ");

            // Store user input
            string userInput = Console.ReadLine();

            // Return userInput string
            return userInput;
        }
    }
}
