using CalcL;
using System;
using System.Text.RegularExpressions;

namespace Calc
{

    

    class Program
    {

        public static void checker(int a, int c)
        {
            string regex = "^[0 - 9] *$";
            Match match = Regex.Match(a.ToString(), regex);
            Match match1 = Regex.Match(c.ToString(), regex);
            
            if (match.Success || match1.Success)
            {

            }
            else
            {
                Console.WriteLine("You enter wrong number");

            }

        }


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

                int d = calculator.calc();


                SingletonL.SingletonL.GetSingleton(a, b, c, d);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }


            Console.ReadKey();

        }



       
    }
}
