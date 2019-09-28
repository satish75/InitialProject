// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    ///  DecimalToBinary class which contains all generic(s) methods..
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// This is decimal to binary conversion method.
        /// </summary>
        public static void DecimalToBinaryConversion()
        {
            Console.WriteLine("Enter Number For Binary Conversion");
            int decimalnumber = Convert.ToInt32(Console.ReadLine());
            int[] binaryarray = new int[8];
            for (int j = 0; j < binaryarray.Length; j++)
            {
                binaryarray[j] = 0;
            }

            int k = 0;
            while (decimalnumber > 0)
            {
                binaryarray[k] = decimalnumber % 2;
                decimalnumber /= 2;
                k++;
            }

            ////This For loop print the actual binary conversion.
            for (int i = 0; i < binaryarray.Length / 2; i++)
            {
                int temp = binaryarray[i];
                binaryarray[i] = binaryarray[binaryarray.Length - 1 - i];
                binaryarray[binaryarray.Length - 1 - i] = temp;
            }
            
            for (int i = 0; i < binaryarray.Length; i++)
            {
                Console.Write(" " + binaryarray[i]);
            }
               
            int m = 0;
            Console.WriteLine("****************** ");
           
            while (m < 4)
            {
                int temp = 0;

                for (int n = 0; n < binaryarray.Length - 1; n++)
                {
                    temp = binaryarray[0];
                    binaryarray[n] = binaryarray[n + 1];
                }

                m++;
                binaryarray[binaryarray.Length - 1] = temp;
            }

            for (int i = 0; i < binaryarray.Length; i++)
            {
                Console.Write(" " + binaryarray[i]);
            }    
        }
    }
}
