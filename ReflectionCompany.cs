// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionCompany.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this reflection class has properties like name, year, turn over, number of employee
    /// </summary>
    public class ReflectionCompany
    {
        /// <summary>
        /// this variable hold name of company
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// this variable hold establish year of company
        /// </summary>
        public int companyEstablishYear { get; set; }

        /// <summary>
        /// this variable hold number of employee of company
        /// </summary>
        public int numberOfEmployee { get; set; }

        /// <summary>
        /// this variable hold turn over of company
        /// </summary>
        public double turnOver { get; set; }

       /// <summary>
       /// this method print the details of company on console
       /// </summary>
       public void ComapanyDetails()
        {
            //// this line print details
            Console.WriteLine("Company Name : {0}\tCompany Establish Year : {1}\tTotal Employee : {2}\tYearly TurnOver : {3}", this.companyName,
               this.companyEstablishYear, this.numberOfEmployee, this.turnOver);
        }
    }
}