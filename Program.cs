// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// This Is Main Program.
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
             Console.WriteLine("1. Flip Coin \n2. Leap Year\n3. Power Of 2\n4. Harmonic Series \n5. Prime Factor\n6. Genarate Coupon\n7. 2D Array Printing\n8. Sum Of Integer\n9. Euclidean Distance\n10. Wind Chill\n11. Root Calculation\n12. Stop Watch");
             Console.WriteLine("*********************************** ");
             Console.WriteLine("Enter Your Choice To Run Operation ");
             int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.FlipCoinMethod();
                        break;
                    case 2:
                        LeapYear leapyear = new LeapYear();
                        leapyear.Isleapyear();
                        break;
                    case 3:
                        PowerOf2 powerof2 = new PowerOf2();
                        powerof2.PowerOf2Method();
                        break;
                    case 4:
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.HarmonicMethod();
                        break;
                    case 5:
                        PrimeFactor primefactor = new PrimeFactor();
                        primefactor.PrimeFactorMethod();
                        break;
                    case 6:
                        CouponNumbers coupon = new CouponNumbers();
                        coupon.CouponMethod();
                        break;
                    case 7:
                        Array2D array = new Array2D();
                        array.ArrayMethod();
                        break;
                    case 8:
                        SumOfThreeInteger sumOfThreeInteger = new SumOfThreeInteger();
                        sumOfThreeInteger.SumOfInteger();
                        break;
                    case 9:
                        Distance distance = new Distance();
                        distance.DistanceMethod();
                        break;
                    case 10:
                        WindChill windChill = new WindChill();
                        windChill.WindChillMethod();
                        break;
                    case 11:
                        Quadratic quadratic = new Quadratic();
                        quadratic.QuadraticMethod();
                        break;
                    case 12:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.StopWatchMethod();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("Do You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');
            Console.ReadKey();
        }
    }
}
