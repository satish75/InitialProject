// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.RegularExpresion
{
    using System;
    using ObjectOriented.InventoryManagement;
    using ObjectOriented.StockReport;
    using ObjectOriented.Commercialdata;

    /// <summary>
    /// this is Main Class .
    /// </summary>
    public class Program
    {
     /// <summary>
    /// This main Method which is the entry point of excution of Application.
    /// </summary>
    /// <param name="args">it takes string type arguments</param>
        public static void Main(string[] args)
        {
            StockAccount stockAccount = new StockAccount();
       
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Create Account \n" + "2. Print Report\n" + "3. Buy Shares\n"
                    +"4. Show My Account \n");
                Console.WriteLine("*********************************** ");
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
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');


            //  stockAccount.UpdateFile();
            //  Utility.InventoryManagementReport();
            //  StockPortfolio.StockReport();
            /*   JsonInventoryManagement curd = new JsonInventoryManagement();
               // curd.GetDetails();
               // curd.AddItem();
               Console.WriteLine("Update Operation");
               curd.UpdateFile();
               Console.WriteLine("Delete Operation");
               curd.DeleteFileItem();
               Console.ReadKey();
               */
            Console.ReadKey();
        }
    }
}
