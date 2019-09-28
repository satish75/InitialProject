// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    ///  MergeSort class which contains all generic(s) methods..
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Merge the sort method.
        /// </summary>
        public static void MergeSortMethod()
        {
            Console.WriteLine("Enter String For Sorting ");
            string message = Console.ReadLine();
            string[] messagearray = message.Split(' ');
            int start = 0;
            int end = messagearray.Length - 1;
            string[] originalmessage = new string[end + 1];
            Divide(messagearray, start, end, originalmessage);
        }

        /// <summary>
        /// Divides the specified message array.
        /// </summary>
        /// <param name="messagearray">The message array.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="originalmessage">The original message.</param>
        public static void Divide(string[] messagearray, int start, int end, string[] originalmessage)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Divide(messagearray, start, mid, originalmessage);
               //// Divide(messagearray, mid+1, end);
                Merge(messagearray, start, mid, end, originalmessage);
            }
        }

        /// <summary>
        /// Merges the specified message array.
        /// </summary>
        /// <param name="messagearray">The message array.</param>
        /// <param name="start">The start.</param>
        /// <param name="mid">The mid.</param>
        /// <param name="end">The end.</param>
        /// <param name="originalmessage">The original message.</param>
        public static void Merge(string[] messagearray, int start, int mid, int end, string[] originalmessage)
        {
            int leftlength = mid - start + 1;
            int rightlength = end - mid;
            string[] leftarray = new string[leftlength];
            string[] rightarray = new string[rightlength];
          
            for (int m = 0; m < leftlength - 1; m++)
            {
                leftarray[m] = messagearray[start + m];
            }

            for (int l = 0; l < leftlength; l++)
            {
                rightarray[l] = messagearray[mid + 1 + l];
            }

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftlength && j < rightlength)
            {
                if (messagearray[i].CompareTo(messagearray[j]) <= 0)
                {
                    originalmessage[k] = messagearray[i];
                    i++;
                }
                else
                {
                    originalmessage[k] = messagearray[j];
                    j++;
                }

                k++;
            }

            while (i < leftlength)
            {
                originalmessage[k] = messagearray[i];
                i++;
                k++;
            }

            while (j < rightlength)
            {
                originalmessage[k] = messagearray[j];
                j++;
                k++;
            }

            foreach (string s in originalmessage)
            {
                Console.WriteLine(s);
            }
        }
    }
}
