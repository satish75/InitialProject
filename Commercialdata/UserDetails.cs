// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
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
    /// This class take user details and stored into file.
    /// </summary>
    public class UserDetails
    {
/// <summary>
/// this variable hold the account holder name 
/// </summary>
        public string accountHolderName;

        /// <summary>
        /// this variable hold the total balance of account holder.
        /// </summary>
        public double totalAmountAccountHolder;

        /// <summary>
        /// this variable hold the total share buy by user and initially it is zero.
        /// </summary>
        public int noOfShareBuyUser = 0;

        /// <summary>
        /// this method take all user detail which required to create account.
        /// </summary>
        
            public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }

        public void UseGetInput()
        {
            ////here user enter user name
             Console.WriteLine("Enter Account Holder UserName");
             accountHolderName = Console.ReadLine();

            ////here user initial balance enter by user
            Console.WriteLine("How Many Doller Do You Have (Total Amount)");
             totalAmountAccountHolder = Convert.ToInt32(Console.ReadLine());
        }
    }
}