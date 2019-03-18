using System;
using System.Configuration;
using System.IO;

namespace CalcL
{
    public class Function
    {
        public static void vrat(int a, int c)
        {

            if (c == 0 || a == 0)
            {
                Exception zero = new Exception("nulov sa neda delit");
                string pathc = ConfigurationManager.AppSettings["FilePath"];

                using (StreamWriter writer = new StreamWriter(pathc, true))
                {
                    while (zero != null)
                    {
                        writer.WriteLine(zero.GetType().FullName);
                        writer.WriteLine("Message : " + zero.Message);

                        zero = zero.InnerException;
                    }
                }
                throw zero;
            }
            else
            {
                int d = a / c;
                Console.WriteLine(d);
            }

        }









    }
}
