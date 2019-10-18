// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonLazy.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is lazy class which create one object
    /// </summary>
   public class SingletonLazy
    {
        /// <summary>
        /// this variable used to count object 
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// this is lazy object creation
        /// </summary>
        private static readonly Lazy<SingletonLazy> singletonObject = new Lazy<SingletonLazy>(() => new SingletonLazy());

        /// <summary>
        /// this is getter to return object
        /// </summary>
        public static SingletonLazy GetSingleton
        {
            get
            {
                //// return object here
                return singletonObject.Value;
            }
        }

        /// <summary>
        /// this is private constructor of class
        /// </summary>
        private SingletonLazy()
        {
            //// increament if multiple object created
            count++;
            Console.WriteLine("Number Of Object " + count);
        }

        /// <summary>
        /// this method display message on console
        /// </summary>
        /// <param name="message">it take message to print</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}