// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryDataManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace ObjectOriented.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class take the inventory details and stored into file.
    /// </summary>
    public class InventoryDataManagement
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
    }

    /// <summary>
    /// This is Rice class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Rice
    {
        /// <summary>
        /// this variable set the rice name 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// this variable take the price of rice
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// this variable take weight of rice.
        /// </summary>
        public double weight { get; set; }
    }


    /// <summary>
    /// This is Wheats class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Wheats
    {
        /// <summary>
        /// this variable set the Wheats name 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// this variable take the price of Wheats
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// this variable take weight of Wheats.
        /// </summary>
        public double weight { get; set; }
    }

    /// <summary>
    /// This is Pulses class  here setter and getter use to set value Rice properties and get value from Rice
    /// </summary>
    public class Pulses
    {
    /// <summary>
     /// this variable set the Pulses name 
     /// </summary>
        public string name { get; set; }

        /// <summary>
        /// this variable take the price of Pulses
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// this variable take weight of Pulses.
        /// </summary>
        public double weight { get; set; }
    }
}
