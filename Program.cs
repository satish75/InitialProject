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
    class Program
    {
        public static void Main(string[] args)
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. SingleTon \n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UtilitySingleton.SingletonType();
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
    }
}
