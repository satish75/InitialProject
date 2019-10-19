// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarName.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This car class which has properties name and model number
    /// </summary>
    public class CarName
    {
        /// <summary>
        /// this variable hold name of car
        /// </summary>
        public string carName { get; set; }

        /// <summary>
        /// it hold model number of car
        /// </summary>
        public string modelNumber { get; set; }

        /// <summary>
        /// it display name and model number
        /// </summary>
        public void CarNameWithModel()
        {
            Console.WriteLine("Car Name : {0} , Model : {1}", carName, modelNumber);
        }
    }

    /// <summary>
    /// this class provide the color properties
    /// </summary>
    public class CarColor
    {
        /// <summary>
        /// it hold color name
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// this method print color
        /// </summary>
        public void getColor()
        {
            Console.WriteLine("Color : " + this.color);
        }
    }

    /// <summary>
    /// this engine class it has engine properties
    /// </summary>
    public class CarEngine
    {
        /// <summary>
        /// it hold engine property
        /// </summary>
        public string carEngine { get; set; }

        /// <summary>
        /// this method print engine on console
        /// </summary>
        public void getEngine()
        {
            Console.WriteLine("Engine : " + this.carEngine);
        }
    }
}