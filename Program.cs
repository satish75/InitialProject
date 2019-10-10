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
            //  Utility.InventoryManagementReport();
            StockPortfolio.StockReport();
            Console.ReadKey();
        }
    }
}
