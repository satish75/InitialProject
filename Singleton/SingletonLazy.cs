using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
     class SingletonLazy
    {
        private static int count = 0;
        private static readonly Lazy<SingletonLazy> singletonObject = new Lazy<SingletonLazy>(()=>new SingletonLazy());
        public static SingletonLazy GetSingleton
        {
            get
            {
                return singletonObject.Value;
            }
        }
        private SingletonLazy()
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
