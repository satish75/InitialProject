// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonThreadSafe.cs" company="Bridgelabz">
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
    /// this class provide the thread safe solution in which multiple thread use same object
    /// </summary>
   public class SingletonThreadSafe
    { 
        /// <summary>
      /// this variable used to count object 
      /// </summary>
        private static int count = 0;

        /// <summary>
        /// initially object null which is static
        /// </summary>
        private static SingletonThreadSafe singletonObject = null;

        /// <summary>
        /// create single object with read only keyword
        /// </summary>
        private static readonly Object objectLock = new Object();

        /// <summary>
        /// it return the object 
        /// </summary>
        public static SingletonThreadSafe GetSingleton
        {
            get
            {
                //// here check the object is null
                if (singletonObject == null)
                {
                    ////provide the lock to avoid the other thread interaction
                    lock (objectLock)
                    {
                        if (singletonObject == null)
                        {
                            ////create the object here
                            singletonObject = new SingletonThreadSafe();
                        }
                    }
                }    
                
                ////return actual object
               return singletonObject;
            }
        }

        /// <summary>
        /// this is private constructor of class
        /// </summary>
        private SingletonThreadSafe()
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