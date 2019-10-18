using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class SingletonThreadSafe
    {
        private static int count = 0;
        private static SingletonThreadSafe singletonObject = null;
        private static readonly Object objectLock = new Object();
        public static SingletonThreadSafe GetSingleton
        {
            get
            {
                if(singletonObject==null)
                {
                    lock (objectLock)
                    {
                        if (singletonObject == null)
                        {
                            singletonObject = new SingletonThreadSafe();
                        }
                    }
                }                       
               return singletonObject;
            }
        }
        private SingletonThreadSafe()
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
