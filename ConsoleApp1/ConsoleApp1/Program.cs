using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 32767;
            double firstDouble = 3276.7;

            double myDouble = firstInt;
            int SecondInt = (int)firstDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(SecondInt);
        }
    }
}
