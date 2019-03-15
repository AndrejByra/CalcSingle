using System;

namespace CalcL
{
    public class Calculator
    {

        private int a, c;
        private String b;
      

        public Calculator(int a, String b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }



        public void calc()
        {
            switch (b)
            {
                case "-":
                    Console.WriteLine(a - c);
                    break;
                case "+":
                    Console.WriteLine(a + c);
                    break;
                case "/":
                    Function.vrat(a, c);
                    break;
                case "*":
                    Console.WriteLine(a * c);
                    break;
            }
        }

        



    }       

}






