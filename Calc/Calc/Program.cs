using CalcL;
using System;
using System.Text.RegularExpressions;

namespace Calc
{

    

    class Program
    {

        public static bool Checker(string a)
        {
            string regex = @"^\d+$";
            Match match = Regex.Match(a, regex);
           
            
            if (match.Success)
            {
                return true;
            }
            else
            {
                Console.WriteLine("You enter wrong number");
                return false;            }

        }


        static void Main(string[] args)
        {
            string a, c;
            string b;

            
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter first number");
                    if (!Checker(a=Console.ReadLine())){
                        continue;
                    }

                    Console.WriteLine("Enter What you want /,*,-,+");
                    b = Console.ReadLine();

                    Console.WriteLine("Enter second number");
                    if(!Checker(c = Console.ReadLine())){
                        continue;
                    }

                    Calculator calculator = new Calculator(int.Parse(a), b, int.Parse(c));

                    int d = calculator.calc();


                    SingletonL.SingletonL.GetSingleton(int.Parse(a), b, int.Parse(c), d);

                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }


            Console.ReadKey();

        }



       
    }
}
