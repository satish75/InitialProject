// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyAdaptee.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CompanyAdaptee
    {
        /// <summary>
        /// this method take list of product of company
        /// </summary>
        /// <returns>it return list of product</returns>
        public List<string> getList()
        {
            //// create list to stored multiple product
            List<string> productList = new List<string>();

            //// here number of product available enter by user or company
            Console.WriteLine("How Many Product Available in Your Company ");
            int noOfProducts = Convert.ToInt32(Console.ReadLine());

            //// here enter company product list one by one
            Console.WriteLine("Enter Your Comapny Product List ");

            //// take list of product 
            for (int i = 0; i < noOfProducts; i++)
            {
                string product = Console.ReadLine();

                //// add product into list of product
                productList.Add(product);
            }

            //// return the list of product
            return productList;
        }          
    }

    /// <summary>
    /// this is target interface it has get product abstract method
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// this is abstract method
        /// </summary>
        /// <returns>list of product</returns>
      public List<string> getProducts();
    }

    /// <summary>
    /// this is adapter class used for communication with classes
    /// </summary>
    public class VenderAdapter : ITarget
    {
        /// <summary>
        /// this method take list of product of company
        /// </summary>
        /// <returns>list of product</returns>
        public List<string> getProducts()
        {
            //// create adaptee object here
            CompanyAdaptee adaptee = new CompanyAdaptee();

            //// return list of product
            return adaptee.getList();
        }
    }
}