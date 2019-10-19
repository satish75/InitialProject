// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Main Class 
    /// </summary>
   public class Program
    {
        /// <summary>
        /// This is main method it is entry point of application
        /// </summary>
        /// <param name="args">it take string type argument</param>
        public static void Main(string[] args)
        {
            //// This do While loop use to take user choice to execute particular operation
            char again;
            do
            {
                //// This Print List Of Operation on Console 
                Console.WriteLine("**********************************");
                Console.WriteLine("1. SingleTon \n" + "2. Factory Pattern\n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");

                ////Take Choice from User
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UtilitySingleton.SingletonType();
                        break;
                    case 2:

                        FactoryClient.ClientRequirement();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                //// here Ask for Continue to perform operation
                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');
        }
    }
}
