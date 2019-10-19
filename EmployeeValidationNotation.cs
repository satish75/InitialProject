// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeValidationNotation.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// --------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// this is employee validation class which has name and age properties
    /// </summary>
    public class EmployeeValidationNotation
    {
        /// <summary>
        /// this is validation for age variable
        /// </summary>
       [Range(20, 40, ErrorMessage = "Age Should Be Between 20 and 40")]
        public int age { get; set; }

        /// <summary>
        /// it hold employee name
        /// </summary>
        string employeeName { get; set; }
       
        /// <summary>
        /// this is validation for employee name and give error
        /// </summary>
        [Required(ErrorMessage = "Name Must Be Required")]

        //// name must be 10 legth
        [StringLength(10)]

        //// employee name must start with capital letter 
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,10}$")]

        //// it set name and return name value
        public string EmployeeName
        {
            get
            {
                //// return name 
                return this.employeeName;
            }

            set
            {
                //// set the employee name value
                this.employeeName = value;
            }
        }

        //// it set Age and return name Age
        public int Age
        {
            get
            {
                //// return age
                return this.age;
            }

            set
            {
                //// ste value for age
                this.age = value;
            }
        }

        /// <summary>
        /// display employee name
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Name Of Emp " + this.employeeName);
        }
    }
}