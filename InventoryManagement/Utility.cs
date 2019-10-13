// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this is utility class which has implementation of all inventory classes
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// it create list of Rice class to stored multiple object.
        /// </summary>
        public IList<Rice> rice { get; set; }

        /// <summary>
        /// it create list of Wheats class to stored multiple object.
        /// </summary>
        public IList<Wheats> wheats { get; set; }

        /// <summary>
        /// it create list of Pulses class to stored multiple object.
        /// </summary>
        public IList<Pulses> pulses { get; set; }

        /// <summary>
        /// this method take inventory details 
        /// </summary>
        public static void InventoryManagementReport()
        {
           ////this variable hold total price of rice.
            double totalRicePrice = 0;

            ////this variable hold total price of wheats.
            double totalWheatsPrice = 0;

            ////this variable hold total price of pulses.
            double totalPulsesPrice = 0;

            ////file path
            string path = "C:\\Users\\bridgeit\\Desktop\\Satya\\Rice.json";

            ////to read data from file
            StreamReader streamReader = new StreamReader(path);

            ////read into string variable
            string readString = streamReader.ReadToEnd();

            ////convert into utility type of object
            Utility utility = (Utility)JsonConvert.DeserializeObject(readString, typeof(Utility));

            ////take one by one object 
            foreach (Rice objeRice in utility.rice)
            {
                ////take name of Rice
                string name = objeRice.name;

                ////take current price of rice
                double price = objeRice.price;

                ////it hold weight of total rice
                double weight = objeRice.weight;

                ////calulate total price of rice
                totalRicePrice = totalRicePrice + price*weight;

                ////print details of rice
                Console.WriteLine("Name Of Rice " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }

            ////here print total amount of rice
            Console.WriteLine("Total Amount Of Rice  " + totalRicePrice);
            Console.WriteLine("*********************");

            ////take one by one object 
            foreach (Wheats objWheats in utility.wheats)
            { 
                ////take current name of wheats
                string name = objWheats.name;

                ////take current price of wheats
                double price = objWheats.price;

                ////it hold weight of wheats
                double weight = objWheats.weight;

                ////hold total price of wheats
                totalWheatsPrice = totalWheatsPrice + price * weight;

                ////print all details of wheats
                Console.WriteLine("Name Of Wheats " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n\n");
            }

            ////print total amount of wheats       
            Console.WriteLine("Total Amount Of Wheats  " + totalWheatsPrice);
            Console.WriteLine("*********************");

            ////take one by one object
            foreach (Pulses objPulses in utility.pulses)
            {
                ////it hold current name of pulses
                string name = objPulses.name;

                ////it hold current price of pulses
                double price = objPulses.price;

                ////it hold weight of pulses
                double weight = objPulses.weight;

                ////it hold total pulses price
                totalPulsesPrice = totalPulsesPrice +  price*weight;

                ////here print all details of pulses            
                Console.WriteLine("Name Of Pulses " + name);
                Console.WriteLine("Price " + price);
                Console.WriteLine("Weight " + weight + "\n");
            }

            ////here print total amount of pulses
            Console.WriteLine("Total Amount Of Pulses   " + totalPulsesPrice);
        }
    }
}