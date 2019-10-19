// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeCar.cs" company="Bridgelabz">
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
/// this is facade class which has car name and car model properties
/// </summary>
    public class FacadeCar
    {
        /// <summary>
        /// this method takes all details about car 
        /// </summary>
        public static void CompleteCarMade()
        {
            //// here create object of car
            CarName carName = new CarName();

            //// set value to car name

            Console.WriteLine("Enter Car Name");
            string name = Console.ReadLine();
            carName.carName = name;

            //// set  car engine object here
            Console.WriteLine("Enter Car Engine");
            string engineSet = Console.ReadLine();
           

            //// assign color as red
            Console.WriteLine("Enter Color Of Car");
            string color = Console.ReadLine();
           

            ////set value to car model
            Console.WriteLine("Enter Car Model Number");
            string model = Console.ReadLine();
            carName.modelNumber = model;

            ////called the method
            carName.CarNameWithModel();

            //// create car color object
            CarColor carColor = new CarColor();

            carColor.color = color;

            //// create engine object
            CarEngine engine = new CarEngine();

            //// called  get color method  
            carColor.getColor();

            //// create car engine class
            CarEngine carEngineObject = new CarEngine();
            carEngineObject.carEngine = engineSet;

            //// called gengine method here
            carEngineObject.getEngine();
        }
    }
}