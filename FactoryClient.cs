// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is client Factory class which has client reqiurment method that provide the choice to user 
    /// to take a particular product at run time. 
    /// </summary>
    public class FactoryClient
    {
        /// <summary>
        /// this method used by client
        /// </summary>
        public static void ClientRequirement()
        {
            ConcreateFactory concreateFactory = new ConcreateFactory();
            Console.WriteLine("Available Product : PC\tLaptop\tServer ");
            Console.WriteLine("Which Product You Want ");
            string productName = Console.ReadLine();
            try
            {
                IComputer computer = concreateFactory.getUserDecidedConfiguration(productName);
                if (computer == null)
                {
                    Console.WriteLine("Your Product Not Made in this Factory");
                }  
                computer.getConfiguration();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }          
        }
    }
}
