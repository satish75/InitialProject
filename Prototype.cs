// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prototype.cs" company="Bridgelabz">
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
    /// this is prototype class
    /// </summary>
    public class Prototype
    {
    }

    /// <summary>
    /// this is employee interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// this is abstract method of Employee
        /// </summary>
        /// <returns> it return object</returns>
        IEmployee Clone();

        /// <summary>
        /// this is abstract method get details of employee
        /// </summary>
        void getDetails();
    }

    /// <summary>
    /// this class implemented by employee
    /// </summary>
    public class Developer : IEmployee
    {
        /// <summary>
        /// it hold the employee id
        /// </summary>
       public int employeeId { set; get; }

        /// <summary>
        /// it hold employee name
        /// </summary>
        public string employeeName { set; get; }

        /// <summary>
        /// it hold employee salary
        /// </summary>
        public int employeeSalary { get; set; }

        /// <summary>
        /// this method used to create clone of employee
        /// </summary>
        /// <returns>it return employee object</returns>
        public IEmployee Clone()
        {
            ////This Is Shallow Copy of Developer
             return (IEmployee)MemberwiseClone();

          ////  Developer developer = (Developer)this.MemberwiseClone();
          ////  developer.employeeName = (IEmployee)this.employeeName.Clone();
          ////  return developer;
        }

        /// <summary>
        /// this method print employee details
        /// </summary>
        public void getDetails()
        {
            Console.WriteLine("Developer :\nId : {0}, Name : {1}, Salary :{2}", employeeId, employeeName, employeeSalary);
        }
    }

    /// <summary>
    /// this Tester class implemented from employee interface
    /// </summary>
    public class Tester : IEmployee
    {
        /// <summary>
        /// it hold employee id
        /// </summary>
        public int employeeId { set; get; }

        /// <summary>
        /// it hold employee name
        /// </summary>
        public string employeeName { set; get; }

        /// <summary>
        /// it hold employee salary
        /// </summary>
        public int employeeSalary { get; set; }

        /// <summary>
        /// this method create clone of employee
        /// </summary>
        /// <returns>it return clone object</returns>
        public IEmployee Clone()
        {
            //// return clone of employee object
             return (IEmployee)MemberwiseClone();
           
          ////  return (IEmployee)this.Clone();
        }

        /// <summary>
        /// this method print employee details
        /// </summary>
        public void getDetails()
        {
            Console.WriteLine("Tester : \nId : {0} Name {1} :{1} Salary :{2}", this.employeeId, this.employeeName, this.employeeSalary);
        }
    }
}