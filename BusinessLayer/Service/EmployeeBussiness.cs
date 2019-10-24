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
    }
}
