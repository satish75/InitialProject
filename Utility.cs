// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This Is Utility Class.
    /// </summary>
    public class Utility
    {
/// <summary>
/// This Is Flip Coin Method To Calculate the Percentage of head and tail 
/// </summary>
        public void FlipCoinMethod()
        {
            Console.WriteLine("How Many Times Do You Want To Flip Coin ");
            int numberofflip = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int head = 0, tail = 0;
            int headpercentage = 0, tailpercentage = 0;
            for (int i = 0; i < numberofflip; i++)
            {
                double result = random.NextDouble();
                if (result < 0.5)
                {
                 head++;
                }
                else
                {
                 tail++;
                }
            }

            headpercentage = head * 100 / numberofflip;
            tailpercentage = tail * 100 / numberofflip;
            Console.WriteLine("Head Percentage :{0}", headpercentage);
            Console.WriteLine("Tail Percentage :{0}", tailpercentage);
        }

      /// <summary>
      /// This is Leap Year Logic. Its Check Year Is Leap Or Not
      /// </summary>
        public void IsLeapYear()
        {
            int year;
           Console.WriteLine("Enter Year to check leap ");
            year = Convert.ToInt32(Console.ReadLine());
            if (this.IsValid(year))
            {
                if (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0))
                {
                 Console.WriteLine("{0} Is  Leap Year", year);
                }
                else
                {
                 Console.WriteLine("{0} Is Not Leap Year", year);
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valide Year ");
            }
        }

        /// <summary>
        /// This Method Check You Entered Year Is Valid or Not.
        /// </summary>
        /// <param name="year">integer type return parameter.</param>
        /// <returns>Returns the status object.</returns>
        public bool IsValid(int year)
        {
            int count = 0, rem = 0;
            while (year > 0)
            {
                rem = year % 10;
                count++;
                year /= 10;
            }

            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        /// <summary>
        /// This is Power Of 2 Method Which Print Table of 2's Power
        /// </summary>
        public void PowerOf2Method()
        {
            Console.WriteLine("Enter The Value 'N' to Calculate the porwe of 2");
            int powerResult;
            int n = Convert.ToInt32(Console.ReadLine());
            uint range = (uint)Math.Pow(2, 31);
        
            for (int i = 1; i < n; i++)
            {
                powerResult = (int)Math.Pow(2, i);
                if (powerResult >= 0 && powerResult < range)
                {
                    Console.Write(" " + powerResult);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// This Is Harmonic Method Which Calculate Nth Harmonic Series
        /// </summary>
        public void HarmonicNumberMethod()
        {
            Console.WriteLine("Enter The Range To Calculate the Harmonic");
            double range = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (double i = 1; i <= range; i++)
            {
                sum = sum + (double)(1 / i);
                Console.Write(" " + 1 + "/" + i);
                if (i < range)
                {
                    Console.Write(" +");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n The N 'Th Harmonic Value is :{0} ", sum);
        }

        /// <summary>
        /// This Is Prime Factor Method Which Prints The Prime Factor Of A Number.
        /// </summary>
        public void PrimeFactorMethod()
        {
            Console.WriteLine("Enter Number For Factorization ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(" " + i);
                    number /= i;
                }
            }
        }

        /// <summary>
        /// This Method Generate Random coupon unique.
        /// </summary>
        public void RandomMethod()
        {
            Random random = new Random();
            string value = "0123456789abcdefghijklmnopqr";
            StringBuilder stringBuilder;
            Console.WriteLine("Enter A Number How Many Coupans Do You Want To Genarate : ");
            int number = Convert.ToInt32(Console.ReadLine());
            HashSet<StringBuilder> listcoupon = new HashSet<StringBuilder>();
            for (int j = 0; j < number; j++)
            {
             stringBuilder = new StringBuilder();
             for (int i = 0; i < 10; i++)
               {
                 stringBuilder.Append(value.ElementAt(random.Next(value.Length)));
               }

                listcoupon.Add(stringBuilder);
            }

        foreach (object obj in listcoupon)
        {
        Console.WriteLine(obj);
        }
  }
        
        /// <summary>
        /// This Is 2D Array Method.
        /// </summary>
        public void Array2DMethod()
        {
            Console.WriteLine("Enter Rows Size of Array");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Column Size of Array");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] intarray = new int[row, column];
            double[,] doublearray = new double[row, column];
            bool[,] boolarray = new bool[row, column];
           //// This Is Integer Array
            Console.WriteLine("Enter Integer Array Element ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    intarray[i, j] = Convert.ToInt32(Console.ReadLine());
                }  
            }
           ////********Array Double***********
            Console.WriteLine("Enter Double Array Element ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    doublearray[i, j] = Convert.ToDouble(Console.ReadLine());
                }  
            }

            ////********Array Boolean***********
            Console.WriteLine("Enter Boolean Array Element ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    boolarray[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }

            ////********Integer Array***********
            Console.WriteLine("*********Integer Array***********");
            foreach (int a in intarray)
            {
                Console.Write("  " + a);
            }

            Console.WriteLine();
            Console.WriteLine("*********Double Array***********");
            foreach (double a in doublearray)
            {
                Console.Write("  " + a);
            }

            Console.WriteLine();
            Console.WriteLine("*********Boolean Array***********");
            foreach (bool a in boolarray)
            {
                Console.Write("  " + a);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// This Is Sum Of Three Integer Method Using Array.
        /// </summary>
        public void SumofThreeMethod()
        {
            Console.WriteLine("Enter Size Of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Array Elements ");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            ////********Actual Logic***********
            int count = 0;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            count++;
                            Console.WriteLine("{0}  {1}  {2} ", array[i], array[j], array[k]);
                        }
                    }
                }
            }

            Console.WriteLine("Count : " + count);
        }

       /// <summary>
       /// This is Euclidean Distance Method
       /// </summary>
        public void DistanceMethod()
        {
            Console.WriteLine("Enter Point 'x' Value ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Point 'y' Value ");
            double y = Convert.ToDouble(Console.ReadLine());
           double squareX = Math.Pow(x, x);
           double squareY = Math.Pow(y, y);
            double euclideanDistance = Math.Sqrt(squareX + squareY);
            Console.WriteLine("Euclidean Distance Is " + euclideanDistance);
        }

        /// <summary>
        /// This Is Method For To Calculate Wind Chill.
        /// </summary>
        public void WindChillMethod()
        {
            Console.WriteLine("Enter Tempreture ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Speed ");
            double v = Convert.ToDouble(Console.ReadLine());
            double w;
            if (t < 50 && v < 120 && v > 3)
            {
                w = 35.74 + (0.6215 * t) + (((0.4275 * t) - 35.75) * Math.Pow(v, 0.16));
                Console.WriteLine("Wind Chill : " + w);
            }
            else
            {
                Console.WriteLine("Enter Valide Tempreture Or Speed ");
            }
        }

        /// <summary>
        /// This is Root Calculation Method 
        /// </summary>
        public void QuadraticMethod()
        {
            Console.WriteLine("Enter Value Of a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of b");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of c");
            double c = Convert.ToInt32(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Root 1 :{0}", root1);
            Console.WriteLine("Root 2 :{0}", root2);
        }

        /// <summary>
        /// This Is Method For To Calculate The Elapse Time
        /// </summary>
        public void StopWatchMethod()
        {
            Console.WriteLine("Enter 1 To Start Watch ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Watch has been Starting............. ");
            Console.WriteLine("Enter 0 To Stop Watch ");
            int stop = Convert.ToInt32(Console.ReadLine());
            int elapsetime = 0;
            int starttime = 0;
            int stoptime = 0;
            if (start == 1)
            {
                starttime = this.Startmethod();
            }

            if (stop == 0)
            {
                stoptime = this.Stopmethod();
            }

            elapsetime = stoptime - starttime;
            Console.WriteLine("Elapse Time Is :{0}", elapsetime);
        }

        /// <summary>
        /// Start methods this instance.
        /// </summary>
        /// <returns>Returns the status object.</returns>
        public int Startmethod()
        {
            var curdate1 = DateTime.Now;
            int start = curdate1.Millisecond;
            return start;
        }

        /// <summary>
        /// Stop methods this instance.
        /// </summary>
        /// <returns>Returns the status object.</returns>
        public int Stopmethod()
        {
            var curdate2 = DateTime.Now;
            int stop = curdate2.Millisecond;
            return stop;
        }
    }
}
