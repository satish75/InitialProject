// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UtilitySingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this is singleton utility this class provide choice to user
    /// </summary>
    public class UtilitySingleton
    {
        /// <summary>
        /// this method display list of operation to perform
        /// </summary>
        public static void SingletonType()
        {
            try
            {
                ////this variable take charecter type value from user
                char again;

                ////this do while loop use for repeating operation
                do
                {
                    ////this is list of operation
                    Console.WriteLine("**********************************");
                    Console.WriteLine("1. SingleTon \n" + "2. Eager Singleton\n" + "3. Lazy Singleton\n"
                         + "4. Singleton Without Sealed\n" + "5. Singleton Thread Safe\n");
                    Console.WriteLine("*********************************** ");

                    ////user enter his choice to perform operation
                    Console.WriteLine("Enter Your Choice To Run Operation ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    ////this switch execute the particular operation
                    switch (choice)
                    {
                        case 1:
                            ////here perform simple singleton operation
                            SingleTone();
                            break;
                        case 2:
                            ////here perform Eager singleton operation
                            EagerSingleton();
                            break;
                        case 3:
                            ////here perform Lazy singleton operation
                            LazySingleton();
                            break;
                        case 4:
                            ////here perform Without Sealed singleton operation
                            SingletonWithoutSealed();
                            break;
                        case 5:
                            ////here perform singleton with thread safe operation
                            SingleTonThreadSafe();
                            break;
                        default:
                            Console.WriteLine("Please Enter Valide Number");
                            break;
                    }

                    ////here ask to user for continue
                    Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                    again = Console.ReadLine()[0];
                }
                while (again == 'Y' || again == 'y');
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please Enter Valide Input "+e);
            }
            
        }

        /// <summary>
        /// Simple singleton Create Only One Object But Thread Not Safe in this Method
        /// </summary>
        public static void SingleTone()
        {
            ////here hold the first object whatever return getSingleton method
            SingletonSimple singletoneFirstMsg = SingletonSimple.GetSingleton;

            ////here hold the Second object whatever return getSingleton method
            SingletonSimple singletoneSecondMsg = SingletonSimple.GetSingleton;

            ////here takes two thread simultaneously to perform operation
            Parallel.Invoke(() => firstMessage(),
                   () => secondMessage());

            ////here call the Message method and pass the argument as string
            singletoneFirstMsg.Message("This if First Message");
             singletoneSecondMsg.Message("This if Second Message");
        }

        /// <summary>
        /// This method used by Simple Singleton
        /// </summary>
        private static void firstMessage()
        {
            ////it hold object of type SingletonLazy
              SingletonLazy threadSafeFirst = SingletonLazy.GetSingleton;

            ////called Message Method with passing string argument
            threadSafeFirst.Message("This is First Message");
        }

        /// <summary>
        /// This method used by Simple Singleton
        /// </summary>
        private static void secondMessage()
        {   ////it hold object of type SingletonLazy
            SingletonLazy threadSafeSecond = SingletonLazy.GetSingleton;

            ////called Message Method with passing string argument
            threadSafeSecond.Message("This is Second Message");         
        }

        /// <summary>
        /// Eager Singleton it create single object only
        /// </summary>
       public static void EagerSingleton()
        {    //// here generate error
            ////  SingletonEager singletonEager = new SingletonEager();
            
            ////it hold Singleton Eager Object
            SingletonEager singletonObject = SingletonEager.GetSingleton;

            ////called Message Method with passing string argument
            singletonObject.Message("This Is Eager Singletone");
        }

        /// <summary>
        /// Lazy Singleton it create object once and stored into memory for future use
        /// </summary>
        public static void LazySingleton()
        {
            ////Provide Error Here
            ////  SingletonLazy singletonLazy = new SingletonLazy();
            SingletonLazy singletonLazy = SingletonLazy.GetSingleton;

            ////called Message Method with passing string argument
            singletonLazy.Message("This Is Lazy Singleton");
        }

        /// <summary>
        /// Singleton Without Sealed
        /// </summary>
        public static void SingletonWithoutSealed()
        {
            ////here create object of nested class to check multiple object created or not
            SigletonLazyWithoutSeal.SingletonNested threadSafeFirst = new SigletonLazyWithoutSeal.SingletonNested();

            ////called Message Method with passing string argument
            threadSafeFirst.Message("Without Sealed First with Nested Class");

            ////here create object of nested class to check multiple object created or not
            SigletonLazyWithoutSeal.SingletonNested threadSafeSecond = new SigletonLazyWithoutSeal.SingletonNested();

            ////called Message Method with passing string argument
            threadSafeFirst.Message("Without Sealed Second with Nested Class");
        }

        /// <summary>
        /// this method provide thread safe implementation
        /// </summary>
        public static void SingleTonThreadSafe()
        {
            ////This is Unaccessible because we aply lock and generate compile time error
           //// SingletonThreadSafe singletonThreadSafe1 = new SingletonThreadSafe();
         
            ////it hold singleton thread type object
            SingletonThreadSafe singletonThreadSafe = SingletonThreadSafe.GetSingleton;

            ////called Message Method with passing string argument
            singletonThreadSafe.Message("This Is Singleton Thread Safe");
        }
    }
}