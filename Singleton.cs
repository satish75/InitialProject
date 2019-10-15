using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public class Singleton
    {
        private static int count=0;
        private static Singleton singletonObject=null;
        public static Singleton GetSingleton
        {
            get
            {
                if (singletonObject == null)
                {
                    singletonObject = new Singleton();
                }
                return singletonObject;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("count " + count);
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
