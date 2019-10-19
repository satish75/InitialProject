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
        public void CompleteCarMade()
        {
            //// here create object of car
            CarName carName = new CarName();

            //// set value to car name
            carName.carName = "Farary";

            ////set value to car model
            carName.modelNumber = "488";

            ////called the method
            carName.CarNameWithModel();

            //// create car color object
            CarColor carColor = new CarColor();

            //// assign color as red
            carColor.color = "Red";

            //// create engine object
            CarEngine engine = new CarEngine();

            //// called  get color method  
            carColor.getColor();

            //// create car engine class
            CarEngine carEngineObject = new CarEngine();

            //// set  car engine object here
            carEngineObject.carEngine = "Ghibli";

            //// called gengine method here
            carEngineObject.getEngine();
        }
    }
}