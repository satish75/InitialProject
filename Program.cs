// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This Class Contain Main Method
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. To Check Anagram \n" + "2. To Check Prime Numbers\n" + "3. BinarySerach For Integer\n" + "4. BinarySerach For String\n" +
                    "5. Insertion Sort For Integer\n" + "6. Insertion Sort For String\n" + "7. Bubble Sort For Integer\n" + "8. Bubble Sort For String\n" + "9. Find Your Number \n" +
                    "10. Search Word From String Using File");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Anagram anagram = new Anagram();
                        anagram.IsAnagram();
                        break;
                    case 2:
                        PrimeNumberRange primeNumberRange = new PrimeNumberRange();
                        primeNumberRange.PrimeNumber();
                        break;
                    case 3:
                        BinarySearch binarySearchInt = new BinarySearch();
                        binarySearchInt.IntegerSearch();
                        break;
                    case 4:
                        BinarySearch binarySearchString = new BinarySearch();
                        binarySearchString.StringSearch();
                        break;
                    case 5:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.InsertionSortInteger();
                        break;
                    case 6:
                        InsertionSort insertionSortstring = new InsertionSort();
                        insertionSortstring.InsertionSortString();
                        break;
                    case 7:
                        BubbleSort bubbleSortint = new BubbleSort();
                        bubbleSortint.BubbleSortInteger();
                        break;
                    case 8:
                        BubbleSort bubbleSortString = new BubbleSort();
                        bubbleSortString.BubbleSortString();
                        break;
                    case 9:
                        FindYourNumber findYourNumber = new FindYourNumber();
                        findYourNumber.FindNumberMethod();
                        break;
                    case 10:
                        SearchWordFromFile searchWordFromFile = new SearchWordFromFile();
                        searchWordFromFile.SearchWordFromMethod();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

            StringPermutation s = new StringPermutation();
            s.StringPermutationIteratively();
            Console.ReadKey();
        }
    }
}
