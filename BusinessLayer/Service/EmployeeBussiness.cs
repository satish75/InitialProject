using BusinessLayer.Interface;
using CommonLayer;
using CommonLayer.Model;
using RepositoryLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class EmployeeBussiness : IEmployee
    {
        private readonly IEmployeeRepository _employeeRepository;
        ErrorMessages errorMessages = new ErrorMessages();
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBussiness"/> class.
        /// </summary>
        /// <param name="employeeRepository">The employee repository.</param>
        public EmployeeBussiness(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">
        /// </exception>
        public async Task<bool> AddEmployeeAsync(EmployeeModel employeeModel)
         {
            try
            {
                if (employeeModel != null)
                {
                    var response = await _employeeRepository.AddEmployeeAsync(employeeModel);
                    if(response > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception(errorMessages.detailsNotFoundError);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

       public async Task<bool> UpdateEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                if (employeeModel != null)
                {
                    var response = await _employeeRepository.UpdateEmployeeAsync(employeeModel);
                    if (response > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception(errorMessages.detailsNotFoundError);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the employee asynchronous.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception">
        /// </exception>
        public async Task<bool> DeleteEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                if (employeeModel != null)
                {
                    var response = await _employeeRepository.DeleteEmployeeAsync(employeeModel);
                    if (response > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception(errorMessages.detailsNotFoundError);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Gets the by identifier employee asynchronous.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception">
        /// </exception>
        public IList<EmployeeModel> GetByIdEmployeeAsync(int id)
        {
            try
            {
               
                 var response =  this._employeeRepository.GetByIdEmployeeAsync(id);
                 return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public IList<EmployeeModel> GetAllEmployeeAsync()
        {
            try
            {

                var response = this._employeeRepository.GetAllEmployeeAsync();
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

    }
}
