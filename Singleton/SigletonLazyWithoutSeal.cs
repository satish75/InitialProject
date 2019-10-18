// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SigletonLazyWithoutSeal.cs" company="Bridgelabz">
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
    /// This is Class Without Sealed If we Apply Sealed Keyword in This class then Only Single object created
    /// </summary>
   public class SigletonLazyWithoutSeal
    {
        /// <summary>
        /// This Variable count the number of created object
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// this line create Lazy Object
        /// </summary>
        private static readonly Lazy<SigletonLazyWithoutSeal> singletonObject = new Lazy<SigletonLazyWithoutSeal>(() => new SigletonLazyWithoutSeal());

        /// <summary>
        /// here use getter to take object
        /// </summary>
        public static SigletonLazyWithoutSeal GetSingleton
        {
            get
            {
                //// it return object
                return singletonObject.Value;
            }
        }

        /// <summary>
        /// This is Private constructor which restrict the object creation
        /// </summary>
        private SigletonLazyWithoutSeal()
        {
            //// increament if new object is created
            count++;
            Console.WriteLine("Number Of Object " + count);
        }

        /// <summary>
        /// This method print the message on console 
        /// </summary>
        /// <param name="message"> it takes message</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// This is nested class use to check multiple object is created or not
        /// </summary>
        public class SingletonNested : SigletonLazyWithoutSeal
        {
        }
    }  
}