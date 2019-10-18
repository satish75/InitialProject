using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{

    //Sigleton Program
               
                  
    public class UtilitySingleton
    {

        public static void SingletonType()
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. SingleTon \n" + "2. Eager Singleton\n" + "3. Lazy Singleton\n"
                     + "4. Singleton Without Sealed\n" + "5. Singleton Thread Safe\n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SingleTone();
                        break;
                    case 2:
                        EagerSingleton();
                        break;
                    case 3:
                        LazySingleton();
                        break;
                    case 4:
                       SingletonWithoutSealed();
                        break;
                    case 5:
                        SingleTonThreadSafe();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

        }

        /// <summary>
        /// Simple singletone Create Only One Object But Thread Not Safe in this Method
        /// </summary>
        public static void SingleTone()
        {
            SingletonSimple singletoneFirstMsg = SingletonSimple.GetSingleton;
            SingletonSimple singletoneSecondMsg = SingletonSimple.GetSingleton;
            Parallel.Invoke(() => firstMessage(),
                   () => secondMessage()
                   );
            singletoneFirstMsg.Message("This if First Message");
             singletoneSecondMsg.Message("This if Second Message");
        }

        /// <summary>
        /// This method used by Simple Singleton
        /// </summary>
        private static void firstMessage()
        {
              SingletonLazy threadSafeFirst = SingletonLazy.GetSingleton;

            threadSafeFirst.Message("This is First Message");
        }

        /// <summary>
        /// This method used by Simple Singleton
        /// </summary>
        private static void secondMessage()
        {
             SingletonLazy threadSafeSecond = SingletonLazy.GetSingleton;
             threadSafeSecond.Message("This is Second Message");         
        }

        /// <summary>
        /// Eager Singleton
        /// </summary>
       public static void EagerSingleton()
        {
            ////  SingletonEager singletonEager = new SingletonEager();
            SingletonEager singletonObject = SingletonEager.GetSingleton;
            singletonObject.Message("This Is Eager Singletone");
        }
        /// <summary>
        /// Lazy Singleton
        /// </summary>
        public static void LazySingleton()
        {
            ////Provide Error Here
            ////  SingletonLazy singletonLazy = new SingletonLazy();
            SingletonLazy singletonLazy = SingletonLazy.GetSingleton;
            singletonLazy.Message("This Is Lazy Singleton");
        }
        /// <summary>
        /// Singleton Without Sealed
        /// </summary>
        public static void SingletonWithoutSealed()
        {
            SigletonLazyWithoutSeal.SingletonNested threadSafeFirst = new SigletonLazyWithoutSeal.SingletonNested();
            threadSafeFirst.Message("Without Sealed First with Nested Class");
            SigletonLazyWithoutSeal.SingletonNested threadSafeSecond = new SigletonLazyWithoutSeal.SingletonNested();
            threadSafeFirst.Message("Without Sealed Second with Nested Class");
        }

        public static void SingleTonThreadSafe()
        {
            ////This is Unaccessible because we aply lock
            ///SingletonThreadSafe singletonThreadSafe = new SingletonThreadSafe();
            SingletonThreadSafe singletonThreadSafe = SingletonThreadSafe.GetSingleton;
            singletonThreadSafe.Message("This Is Singleton Thread Safe");
        }
    }
}
