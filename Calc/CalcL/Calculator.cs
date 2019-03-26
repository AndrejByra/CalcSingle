using System;

namespace CalcL
{
    public class Calculator:CalculatorInterface
    {
        private int a, c;
        private String b;
        private int d;
      
        public Calculator(int a, String b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int calc()
        {
            switch (b)
            {
                case "-":
                     d = a - c;
                    Console.WriteLine(d);
                     return d;
                    break;
                case "+":
                    d = a + c;
                    Console.WriteLine(d);
                    return d;
                    break;
                case "/":
                    Function.vrat(a, c);
                    return d;
                    break;
                case "*":
                    d = a * c;
                    Console.WriteLine(d);
                    return d;
                    break;
            }
            return 0;
        }
    }       

}