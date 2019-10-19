// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Injection.cs" company="Bridgelabz">
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
    /// this is injection class
    /// </summary>
    class Injection
    {
    }

    /// <summary>
    /// this is interface which has employee details abstract method
    /// </summary>
    public interface Employee
    {
        /// <summary>
        /// declared abstract method
        /// </summary>
        public void employeeDetails();
    }

    /// <summary>
    /// This is Constructor Dependency
    /// </summary>
    public class Permanent : Employee
    {
        /// <summary>
        /// display employee details here
        /// </summary>
        public void employeeDetails()
        {
            Console.WriteLine("Enter Employee Name ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Position ");
            string employeePosition = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary ");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name : {0}\tPosition : {1}\tSalary : {2}", employeeName, employeePosition, employeeSalary);
        }      
    }

    /// <summary>
    /// this class construct the injection
    /// </summary>
    public class ConstructorInjection
    {
        /// <summary>
        /// create the permanent class object
        /// </summary>
        Permanent permanent;

        /// <summary>
        /// constructor of this class
        /// </summary>
        /// <param name="permanent"> take object</param>
        public ConstructorInjection(Permanent permanent)
        {
            //// set object to current class
            this.permanent = permanent;
        }

        /// <summary>
        /// get details of employee
        /// </summary>
        public void employeeDetailsByConstructor()
        {
            //// called method
            this.permanent.employeeDetails();
        }
    }
    
    /// <summary>
    /// Property Injection
    /// </summary>
    public class PropertyClient
    {
        /// <summary>
        /// create employee class reference
        /// </summary>
        Employee newEmpObject { get; set; }

        /// <summary>
        /// apply setter and getter on employee object
        /// </summary>
       public Employee NewEmployee
        {
            get
            {
                //// return employee object
                return newEmpObject;
            }

            set
            {
                //// set employee object
                newEmpObject = value;
            }
        }

        /// <summary>
        /// this method use to called employee details
        /// </summary>
         public void PropertyInjection()
        {
            newEmpObject.employeeDetails();
        }    
    }

    /// <summary>
    /// Method Injection
    /// </summary>
    public class MethodClient
    {
       /// <summary>
       /// this method called employee details method
       /// </summary>
       /// <param name="newEmpObject"> take employee type object</param>
        public void MethodClientInjection(Employee newEmpObject)
        {
            //// print employee details
            newEmpObject.employeeDetails();
        }
    }
}