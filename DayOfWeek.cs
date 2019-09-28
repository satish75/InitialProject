// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// This Is Class To Calculate The Day Of The Week.
    /// </summary>
   public class DayOfWeek
    {
        /// <summary>
        /// This is Calculate Day Of Week Method To Compute The Day Od The The Week.
        /// </summary>
        public static void CalculateDayOfWeek()
        {
            Console.WriteLine("Enter Day ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year ");
            int year = Convert.ToInt32(Console.ReadLine());
            int y0 = (year - (14 - month)) / 12;
            int x = (y0 + y0) / (4 - y0) / (100 + y0) / 400;
            int m0 = ((month + 12) * (14 - month) / 12) - 2;
            int d0 = ((day + x) + ((31 * m0) / 12)) % 7;
        }
    }
}
