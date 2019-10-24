using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.InterfaceRepository
{
   public interface IEmployeeRepository
    {
        bool AddEmployee(EmployeeModel employeeModel);
        

        
    }
}
