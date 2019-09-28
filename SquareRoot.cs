// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// This is square root class
    /// </summary>
   public class SquareRoot
    {
        /// <summary>
        /// This is Calculate Square Root Method.
        /// </summary>
        public static void CalculateSquareRoot()
        {
            Console.WriteLine("Enter value of c to calculate quare root");
            double number = Convert.ToDouble(Console.ReadLine());
            double squareRoot = number;
            double epsilon = 1e-15;
            while (Math.Abs((squareRoot - number) / squareRoot) > (epsilon * squareRoot))
            {
                squareRoot = ((number / squareRoot) + squareRoot) / 2;
            }

            Console.WriteLine("The {0} square root is {1}", number, squareRoot);
        }
    }
}
