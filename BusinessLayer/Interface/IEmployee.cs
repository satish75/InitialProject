using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IEmployee
    {
         Task<bool> AddEmployeeAsync(EmployeeModel employeeModel);
        Task<bool> UpdateEmployeeAsync(EmployeeModel employeeModel);
        Task<bool> DeleteEmployeeAsync(EmployeeModel employeeModel);
        IList<EmployeeModel> GetByIdEmployeeAsync(int id);
        IList<EmployeeModel> GetAllEmployeeAsync();
    }
}
