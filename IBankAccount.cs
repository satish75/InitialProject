// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBankAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------

namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this interface has withdrawal method 
    /// </summary>
    interface IBankAccount
    {
        /// <summary>
        /// this is abstract method
        /// </summary>
        /// <returns> it return available balance</returns>
        public double WithdrawCash();
    }

    /// <summary>
    /// this is customer class implemented from bank account
    /// </summary>
   public class Customer : IBankAccount
    {
        /// <summary>
        /// this variable hold the bank balance
        /// </summary>
        public static double AvailableBalance { get; set; }

        /// <summary>
        /// this is withdrawal method
        /// </summary>
        /// <returns>it return available balance</returns>
        public double WithdrawCash()
        {      
            //// take input from user to withdrwal  
            Console.WriteLine("Enter Cash To Withdraw ");
            double cashWithdraw = Convert.ToDouble(Console.ReadLine());

            //// update the available balance
            AvailableBalance = AvailableBalance - cashWithdraw;

            //// return the balance
            return AvailableBalance;
        }
    }

    /// <summary>
    /// this is proxy class implemented from Bank Account
    /// </summary>
    public class AtmProxy : IBankAccount
    {
        /// <summary>
        /// this method override 
        /// </summary>
        /// <returns>it return available balance</returns>
        public double WithdrawCash()
        {
            //// create customer object here
            Customer customer = new Customer();   
            
            //// return available balance here
           return customer.WithdrawCash();
        }
    }
}