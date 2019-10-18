using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
     class SigletonLazyWithSealed
    {
        private static int count = 0;
        private static readonly Lazy<SigletonLazyWithSealed> singletonObject = new Lazy<SigletonLazyWithSealed>(() => new SigletonLazyWithSealed());
        public static SigletonLazyWithSealed GetSingleton
        {
            get
            {
                return singletonObject.Value;
            }
        }
        private SigletonLazyWithSealed()
        {
            count++;
            Console.WriteLine("count " + count);
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public class SingletonNested : SigletonLazyWithSealed
        {

        }
    }
   
}
