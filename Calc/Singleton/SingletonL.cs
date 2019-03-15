using System.Configuration;
using System.IO;

namespace SingletonL
{
    public class SingletonL
    {
        private static SingletonL singleton = null;

        private SingletonL() { }


        public static SingletonL GetSingleton(int a, string b,int c)
        {
            if (singleton == null)
            {
                singleton = new SingletonL();

            }
            singleton.logWriter(a,b,c);
            return singleton;
        }


        public void logWriter(int a,string b, int c) {
            string pathL = ConfigurationManager.AppSettings["FilePath"];
            using ( StreamWriter streamWriter = new StreamWriter(pathL, true))
            {
                streamWriter.WriteLine("First nunmber=" + a);
                streamWriter.WriteLine("Char="+b);
                streamWriter.WriteLine("Second number="+c);


            }




        }
        

     

    }
}
    