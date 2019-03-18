using CalcL;
using System;


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
                b = Console.ReadLine() ;

                Console.WriteLine("Enter second number");
                c = int.Parse(Console.ReadLine());

                
                Calculator calculator = new Calculator(a, b, c);

                int d= calculator.calc();


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
