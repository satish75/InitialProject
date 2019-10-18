using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
   public class SingletonSimple
    {
        private static int count=0;
        private static SingletonSimple singletonObject =null;
        public static SingletonSimple GetSingleton
        {
            get
            {
                if (singletonObject == null)
                {
                    singletonObject = new SingletonSimple();
                }
                return singletonObject;
            }
        }
        private SingletonSimple()
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
