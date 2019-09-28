// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// This is Monthly Payment Class Which Calculate Rate Of Interest. 
    /// </summary>
   public class MonthlyPayment
    {
        /// <summary>
        /// This is Calculate Monthly Payment Method.
        /// </summary>
        public static void CalculateMonthlyPayment()
        {
            Console.WriteLine("Enter principle");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate Of percentage for principle");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter No. of Years");
            double years = Convert.ToDouble(Console.ReadLine());
            double n = 12 * years;
            double r = rate / (12 * 100);
            double payment = principle * r / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("The Monthly Payment Is :" + payment); 
        }
    }
}
