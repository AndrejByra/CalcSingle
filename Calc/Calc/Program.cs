using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcL;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
             int a, c;
             string b;

            try
            {
                Console.WriteLine("Enter first number");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter What you want /,*,-,+");
                b = Console.ReadLine();

                Console.WriteLine("Enter second number");
                c = int.Parse(Console.ReadLine());

                
                Calculator calculator = new Calculator(a, b, c);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
                         
            Console.ReadKey();

        }
    }
}
