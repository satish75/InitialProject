using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class SingletonEager
    {
        private static int count = 0;
        private static readonly SingletonEager singletonObject = new SingletonEager();     
        public static SingletonEager GetSingleton
        {
            get
            {                
                return singletonObject;
            }
        }
        private SingletonEager()
        {
            count++;
            Console.WriteLine("Number Of Object " + count);
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
