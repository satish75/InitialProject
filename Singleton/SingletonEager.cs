// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonEager.cs" company="Bridgelabz">
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
    /// This is Eager Class which is create only one object but not thread safe
    /// </summary>
    public class SingletonEager
    {
        /// <summary>
        /// this variable used to compute the number of object
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// here create one object which is read only
        /// </summary>
        private static readonly SingletonEager singletonObject = new SingletonEager();   
        
        /// <summary>
        /// here getter used to return the object
        /// </summary>
        public static SingletonEager GetSingleton
        {
            get
            {   ////here return object             
                return singletonObject;
            }
        }

        /// <summary>
        /// this is private constructor which cant allow to overload the constructor
        /// </summary>
        private SingletonEager()
        {
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