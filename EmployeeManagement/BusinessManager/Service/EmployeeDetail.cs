////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EmployeeDetail.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace BusinessManager.Service
{
    using System.Collections.Generic;
    using BusinessManager.Interface;
    using CommanLayer;
    using RepositeryManager.Interface;

    /// <summary>
    /// Employee details
    /// </summary>
    /// <seealso cref="BusinessManager.Interface.IEmployee" />
    public class EmployeeDetail : IEmployee
    {
        /// <summary>
        /// The details
        /// </summary>
        private readonly IEmployeeDetails _employeeDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDetail"/> class.
        /// </summary>
        /// <param name="employeeDetails">The details.</param>
       public EmployeeDetail(IEmployeeDetails employeeDetails)
        {
            this._employeeDetails = employeeDetails;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void AddEmployee(EmployeeModel obj)
        {
             this._employeeDetails.AddEmployee(obj); 
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <returns>
        /// returning employee list
        /// </returns>
        public List<EmployeeModel> GetEmployee()
        {
           return this._employeeDetails.GetAllEmployeeList();
        }

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// returning employee list according to id
        /// </returns>
        public List<EmployeeModel> GetEmployeeById(string id)
        {
            return this._employeeDetails.GetEmployeeById(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeModel">The object.</param>
        /// <returns>
        /// returning true if employee details updated
        /// </returns>
        public bool UpdateEmployee(EmployeeModel employeeModel)
        {
            return this._employeeDetails.UpdateEmployee(employeeModel);
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employeeId">The object.</param>
        /// <returns>
        /// returning true if employee details deleted
        /// </returns>
        public bool DeleteEmployee(string employeeId)
        {
            return this._employeeDetails.DeleteEmployee(employeeId);
        }  
    }
}
