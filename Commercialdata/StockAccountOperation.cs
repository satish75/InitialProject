// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccountOperation.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Commercialdata
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class is create to take choice from user to perform operation
    /// </summary>
    public class StockAccountOperation
    {
        /// <summary>
        /// this method take choice from user
        /// </summary>
        public static void StockAccountChoice()
        {
            StockAccount stockAccount = new StockAccount();
            char again;
            do
            {
                ////here print list of operation which is goining to perform
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Create Account \n" + "2. Print Report\n" + "3. Buy Shares\n"
                    + "4. Show My Account \n" + "5. No of Share \n" + "6. Sell\n");
                Console.WriteLine("*********************************** ");

                ////take choice from user
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stockAccount.StockAcountCreate();
                        break;
                    case 2:
                        stockAccount.PrintReport();
                        break;
                    case 3:
                        stockAccount.Buy();
                        break;
                    case 4:
                        stockAccount.ShowMyAccount();
                        break;
                    case 5:
                       Console.WriteLine(stockAccount.ValueOf());
                        break;
                    case 6:
                        stockAccount.Sell();
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