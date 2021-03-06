﻿using System.Configuration;
using System.IO;

namespace SingletonL
{
    public class SingletonL: LoggerInterface
    {
        public static string path;
        private static SingletonL singleton = null;
       
        private SingletonL() { }

        public static SingletonL GetSingleton(string pathL)
        {
            if (singleton == null)
            {
                singleton = new SingletonL();
            }

             path = pathL;
            return singleton;
        }

        public void logWriter(int a,string b, int c,int d) {
            using ( StreamWriter streamWriter = new StreamWriter(path,true))
            {
                streamWriter.WriteLine("First nunmber= " + a);
                streamWriter.WriteLine("Char= "+b);
                streamWriter.WriteLine("Second number= "+c);
                streamWriter.WriteLine("result= "+d);
            }
        }
    }
}