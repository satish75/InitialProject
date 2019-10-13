// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.RegularExpresion
{
    using System;
    using ObjectOriented.Commercialdata;
    using ObjectOriented.InventoryManagement;
    using ObjectOriented.StockReport;
  
    /// <summary>
    /// this is Main Class .
    /// </summary>
    public class Program
    {
     /// <summary>
    /// This main Method which is the entry point of execution of Application.
    /// </summary>
    /// <param name="args">it takes string type arguments</param>
        public static void Main(string[] args)
        {
          ////this charector take choice from user.       
            char again;

            try
            {
                ////do while loop use to continue the operation
                do
                {
                    ////here print the list of opeartion
                    Console.WriteLine("**********************************");
                    Console.WriteLine("1. Inventory Management Report \n" + "2. Inventory CURD Operation\n" + "3. Stock Portfolio\n" + "4. Commercial Proccessing\n" + "5. Regular Expression\n");
                    Console.WriteLine("*********************************** ");

                    ////here user enter theire choice to continue operation
                    Console.WriteLine("Enter Your Choice To Run Operation ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    ////switch case use to perform different operation base on user choice
                    switch (choice)
                    {
                        case 1:
                            ////here call the object of utility to print inventory report
                            Utility.InventoryManagementReport();
                            break;
                        case 2:
                            ////here call the method with class name to perform curd operation
                            InventoryCurdOperation.InventoryManagementCurdOpeartion();
                            break;
                        case 3:
                            ////here print stock portfolio report
                            StockPortfolio.StockReport();
                            break;
                        case 4:
                            ////here perform account stock operation like buy share ,sell share.
                            StockAccountOperation.StockAccountChoice();
                            break;
                        case 5:
                            ////here check pattern
                            RegularExpression.RegularExpressionChecker();
                            break;
                        default:
                            ////this is invalide case
                            Console.WriteLine("Please Enter Valide Number");
                            break;
                    }

                    ////here asked to user Do continue or not.
                    Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                    again = Console.ReadLine()[0];
                }
                while (again == 'Y' || again == 'y');

                ////it hold the console untill press the key
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valide Input ..." + e);
            }         
        }
    }
}
