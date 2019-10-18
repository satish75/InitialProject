// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonSimple.cs" company="Bridgelabz">
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
    /// This is Simple Singleton Class Example
    /// </summary>
    public class SingletonSimple
    {
        /// <summary>
        /// this variable used to count the created object
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// initially Singleton Object null
        /// </summary>
        private static SingletonSimple singletonObject = null;

        /// <summary>
        /// It return the Singleton Object
        /// </summary>
        public static SingletonSimple GetSingleton
        {
            get
            {
                if (singletonObject == null)
                {
                    ////create the object
                    singletonObject = new SingletonSimple();
                }

                //// return object
                return singletonObject;
            }
        }

        /// <summary>
        /// This is Private Constructor used to create or initialize object
        /// </summary>
        private SingletonSimple()
        {
            count++;
            Console.WriteLine("Number Of Object " + count);
        }

        /// <summary>
        /// This method used to print message on console
        /// </summary>
        /// <param name="message">It take message</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}