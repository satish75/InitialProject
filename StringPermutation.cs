// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringPermutation.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// This Is String Permutation Class
    /// </summary>
    public class StringPermutation
    {
        /// <summary>
        /// The Hash Set Class Object Declared here.
        /// </summary>
       private HashSet<string> myhash1 = new HashSet<string>();

        /// <summary>
        /// Strings the permutation iteratively.
        /// </summary>
        public void StringPermutationIteratively()
        {
            Console.WriteLine("Enter String For Permution\n");
            string permuteString = Console.ReadLine();
            Console.WriteLine("............\n");
            char[] c = permuteString.ToCharArray();
      
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = i; j < c.Length; j++)
                {
                    char[] temparray = new char[c.Length];
                    Array.Copy(c, temparray, c.Length);
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                    string s = new string(temparray);
                    this.Swap(s);
                }
            }

            Console.WriteLine("**********");
            foreach (string str in this.myhash1)
            {
                Console.WriteLine(str);
            }
        }

        /// <summary>
        /// Swaps the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        public void Swap(string s)
        {
            char[] c = s.ToCharArray();
           
            for (int i = 1; i < c.Length; i++)
            {
                for (int j = i; j < c.Length; j++)
                {
                    char[] temparray = new char[c.Length];
                    Array.Copy(c, temparray, c.Length);
                    char temp = temparray[i];
                    temparray[i] = temparray[j];
                    temparray[j] = temp;
                    string s1 = new string(temparray);
                   //// Console.WriteLine(s1);
                    this.myhash1.Add(s1);
                }
            }
        }
    }
}
