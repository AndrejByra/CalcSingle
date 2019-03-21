using CalcL;
using System;
using System.Text.RegularExpressions;
using SingletonL;

namespace Calc
{
    class Checking
    {
        
        string a, c;
        string b;
        int d;
        

        private readonly LoggerInterface logeri;

        public  Checking(LoggerInterface logeri)
        {
            this.logeri = logeri;
                
        }


        public void proces()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter first number");
                    if (!Checker(a = Console.ReadLine()))
                    {
                        continue;
                    }

                    Console.WriteLine("Enter What you want /,*,-,+");
                    b = Console.ReadLine();

                    Console.WriteLine("Enter second number");
                    if (!Checker(c = Console.ReadLine()))
                    {
                        continue;
                    }

                    //Calculator calculator = new Calculator(int.Parse(a), b, int.Parse(c));
                    CalculatorInterface calsInterface = new Calculator(int.Parse(a), b, int.Parse(c));
                     d = calsInterface.calc();



                    //SingletonL.SingletonL.GetSingleton(int.Parse(a), b, int.Parse(c), d);
                    
                    logeri.logWriter(int.Parse(a), b, int.Parse(c), d);

                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }



        }




        private static bool Checker(string a)
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
                return false;
            }

        }
    }
}
