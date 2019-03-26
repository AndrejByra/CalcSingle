using System;
using System.Configuration;
using SingletonL;

namespace Calc
{
    class Program
    {
        private static  LoggerInterface logeri;

        static void Main(string[] args)
        {
           logeri = SingletonL.SingletonL.GetSingleton(ConfigurationManager.AppSettings["FilePath"]);
           Checking checking = new Checking(logeri);
           checking.proces();

           Console.ReadKey();
            
        }
    }
}
