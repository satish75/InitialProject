// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperaturConversion.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// This is Temperature conversion class.
    /// </summary>
    public class TemperaturConversion
    {
        /// <summary>
        /// This is Temperature Conversion From Celsius To Fahrenheit
        /// </summary>
        public static void TemperatureConversionFromCelciusToFerhenite()
        {
            Console.WriteLine("Enter celcius temperature");
            double celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter ferheniet temperature");
            double ferheniet = Convert.ToDouble(Console.ReadLine());
            double celciusToFerheniet = (celcius * 9 / 5) + 32;
            double ferhenietToCelcius = (ferheniet - 32) * (5 / 9);
            Console.WriteLine("Celcius {0} to ferheniet {1}", celcius, celciusToFerheniet);
            Console.WriteLine("ferheniet {0} to Celcius {1}", ferheniet, ferhenietToCelcius);
        }
    }
}
