using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// This is Class Without Sealed If we Aply Sealed Keyword in This class then Only Single object created
    /// </summary>
     class SigletonLazyWithoutSeal
    {
        private static int count = 0;
        private static readonly Lazy<SigletonLazyWithoutSeal> singletonObject = new Lazy<SigletonLazyWithoutSeal>(() => new SigletonLazyWithoutSeal());
        public static SigletonLazyWithoutSeal GetSingleton
        {
            get
            {
                return singletonObject.Value;
            }
        }
        private SigletonLazyWithoutSeal()
        {
            count++;
            Console.WriteLine("Number Of Object " + count);
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public class SingletonNested : SigletonLazyWithoutSeal
        {

        }
    }
   
}
