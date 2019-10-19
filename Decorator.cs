// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Decorator.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------

namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Decorator
    {
    }

    /// <summary>
    /// this is abstract class it has abstract method which print product details
    /// </summary>
    public abstract class ILaptop
    {
    /// <summary>
    /// setter getter for name
    /// </summary>
        public string name { get; set; }

        /// <summary>
        ///  setter getter for Price
        /// </summary>
        public double price { get; set; }

        /// <summary>
        ///  setter getter for manufacture year
        /// </summary>
        public int manufacturingYear { get; set; }

        /// <summary>
        /// this is abstract method which is declared
        /// </summary>
       public abstract void GetDetails();
    }

    /// <summary>
    /// HP class extend from laptop class
    /// </summary>
    public class HP : ILaptop
    {
        ////this is abstract method implementation 
        public override void GetDetails()
        {
            Console.WriteLine("Name : {0}\tPrice : {1}\tManufacture Year : {2}", name, price, manufacturingYear);         
        }
    }

    /// <summary>
    /// this is abstract class extend from laptop
    /// </summary>
    public abstract class DecoratorLaptop : ILaptop
    {
        /// <summary>
        /// here create laptop reference
        /// </summary>
        ILaptop laptop;

        /// <summary>
        /// this is constructor which initialize the object
        /// </summary>
        /// <param name="lapi">it takes Laptop object</param>
        public DecoratorLaptop(ILaptop lapi)
        {
            //// this is constructor which initilaize the object
            laptop = lapi;
        }

        /// <summary>
        /// here override the method
        /// </summary>
        public override void GetDetails()
        {
            //// called the abstract class method
            laptop.GetDetails();
        }
    }

    /// <summary>
    /// this class extends from Decorator Laptop class
    /// </summary>
    public class ConcreateDecoratorHp : DecoratorLaptop
    {
        /// <summary>
        /// price increase variable
        /// </summary>

        /// <summary>
        /// getter used to  return the increasing price
        /// </summary>
      
        /// <summary>
        /// This is Constructor
        /// </summary>
        /// <param name="valueObject"> take Laptop object as parameter</param>
        public ConcreateDecoratorHp(ILaptop valueObject) : base(valueObject)
        {
            Console.WriteLine("Enter Increase Price  ");
            double priceIncrease = Convert.ToDouble(Console.ReadLine());
        //// here update the price value
        valueObject.price = valueObject.price + priceIncrease;
        }
        
        /// <summary>
        /// override the base class method
        /// </summary>
        public override void GetDetails()
        {    
            //// called base class method here
            base.GetDetails();
        }
    }
}