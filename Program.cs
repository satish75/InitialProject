﻿using System;
using System.Threading.Tasks;
namespace DesignPattern
{
    class Program
    {
       public static void Main(string[] args)
        {
            FactoryPattern concreateFactory = new ConcreateFactory();
            Console.WriteLine("Available Product : 1.PC    2.Laptop   3. Server\n");
            Console.WriteLine("Enter Product Which You Want ");
            string product = Console.ReadLine();
            switch (product)
            {
                case "PC":
                    IComputer pcProduct = concreateFactory.getUserDecidedConfiguration("PC");
                    pcProduct.getConfiguration("8Gb", "2Tb", "I5");
                    break;
                case "Laptop":
                    IComputer laptopProduct = concreateFactory.getUserDecidedConfiguration("Laptop");
                    laptopProduct.getConfiguration("4Gb", "1Tb", "I3");
                    break;
                case "Server":
                    IComputer serverProduct = concreateFactory.getUserDecidedConfiguration("Server");
                    serverProduct.getConfiguration("Intel Xeon", "120Tb", "Dual");
                    break;
            }
           

        
























            /*  Parallel.Invoke( ()=> firstMessage(),
                  ()=>secondMessage()
                  );

                /*
                ////Static class Example
                ///
                double radius = 10;
                double length = 3;
                double width = 6;
                Console.WriteLine(StaticClass.AreaOfCircle(radius));
                Console.WriteLine(StaticClass.AreaOfRectangle(length, width));


          /*      SigletonLazyWithSealed.SingletonNested threadSafeFirst = new SigletonLazyWithSealed.SingletonNested();
                threadSafeFirst.Message("Using Sealed First");       
                SigletonLazyWithSealed.SingletonNested threadSafeSecond = new SigletonLazyWithSealed.SingletonNested();
                threadSafeFirst.Message("Using Sealed Second");



                /*Sigleton Program
                 *Singleton singletoneFirstMsg= Singleton.GetSingleton;
                 Singleton singletoneSecondMsg = Singleton.GetSingleton;
                 singletoneFirstMsg.Message("This if First Message");
                 singletoneSecondMsg.Message("This if Second Message");
                 */


            Console.ReadKey();
        }
     /*   private static void firstMessage()
        {
            ////   SingletonLazy threadSafeFirst = SingletonLazy.GetSingleton;
         
           // threadSafeFirst.Message("This is First Message");
        }
        private static void secondMessage()
        {
           //// SingletonLazy threadSafeSecond = SingletonLazy.GetSingleton;
          ////  threadSafeSecond.Message("This is Second Message");         
        }
     */
    }
}
