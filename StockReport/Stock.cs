// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.StockReport
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// this is stock class take stock input from user 
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// it hold name of share of stock
        /// </summary>
        public string nameOfShare;

        /// <summary>
        /// it hold number of share of stock
        /// </summary>
       public int numberOfShare;

        /// <summary>
        /// this hold price of share
        /// </summary>
       public double sharePrice;

        /// <summary>
        /// this method get stock details as input
        /// </summary>
        public void StockGetInput()
        {
            try
            {
                ////here enter name of stock
                Console.WriteLine("Enter Name of Share/Stock ");
                this.nameOfShare = Console.ReadLine();

                ////here enter number of share
                Console.WriteLine("Enter Number of Share ");
                this.numberOfShare = Convert.ToInt32(Console.ReadLine());

                ////enter price of share here
                Console.WriteLine("Enter Price of Per Share ");
                this.sharePrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (InvalidCastException i)
            {
                Console.WriteLine("Please Enter Valide Input " + i);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valide Input" + e);
            }
          
        }
    }
}
