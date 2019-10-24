using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
   public class EmployeeBussiness :IEmployee
    {
     private readonly IEmployeeRepository _employeeRepository;
      public  EmployeeBussiness (IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                if(employeeModel !=null)
                {
                    return _employeeRepository.AddEmployee(employeeModel);
                }
                else
                {
                    throw new Exception("Employee Is Empty ");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
