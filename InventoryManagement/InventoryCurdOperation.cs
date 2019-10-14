// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class perform curd operation on file.
    /// </summary>
    public class InventoryCurdOperation
    {
        public static void InventoryManagementCurdOpeartion()
        {
            JsonInventoryManagement JsonInventoryManagement = new JsonInventoryManagement();
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Get Details Of Inventory \n" + "2. Update File Item\n" + "3. Delete File item\n"
                    + "4. Add Into File \n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        JsonInventoryManagement.GetDetails();
                        break;
                    case 2:
                        JsonInventoryManagement.UpdateFile();
                        break;
                    case 3:
                        JsonInventoryManagement.DeleteFileItem();
                        break;
                    case 4:
                        JsonInventoryManagement.AddItem();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
                if (again == ' ')
                {
                    Console.WriteLine("Please Enter Valide Input");
                    break;
                }
            }
            while (again == 'Y' || again == 'y');
        }
    }
}
