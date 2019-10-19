// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
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
    /// Atm class used as proxy user which consist all properties of customer
    /// </summary>
    public class AtmUserProxy
    {
        /// <summary>
        /// This method used to perform operation
        /// </summary>
        public static void AtmWithdrawal()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Available Balance");
            Customer.AvailableBalance = Convert.ToDouble(Console.ReadLine());
            AtmProxy atmProxy = new AtmProxy();
            Console.WriteLine("ATM Object Performing Operation");
            Console.WriteLine("Available Balance After Withdrawal : " + atmProxy.WithdrawCash());        
        }
    }
}
