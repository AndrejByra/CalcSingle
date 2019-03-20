using CalcL;
using System;
using System.Text.RegularExpressions;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
           Checking checking = new Checking();
           checking.proces();
           Console.ReadKey();
        }
    }
}
