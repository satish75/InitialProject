////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "IEmployee.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace BusinessManager.Interface
{
    using System.Collections.Generic;
    using CommanLayer;

    /// <summary>
    /// Employee interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        void AddEmployee(EmployeeModel obj);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>returning true if employee details updated</returns>
        bool UpdateEmployee(EmployeeModel obj);

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>returning employee list according to id</returns>
        List<EmployeeModel> GetEmployeeById(string id);

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <returns>returning employee list</returns>
        List<EmployeeModel> GetEmployee();

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>returning true if employee details deleted</returns>
        bool DeleteEmployee(string obj);
    }
}
