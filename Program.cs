using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            double numInput = ConvertToNumFunction.GetNum();

            CalcModFunction.calcMod(numInput);

            // Added to leave console open even if started without debugging
            Console.ReadLine();
        }
    }
}
