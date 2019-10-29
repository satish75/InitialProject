using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.InterfaceRepository
{
   public interface IEmployeeRepository
    {
        Task<int> AddEmployeeAsync(EmployeeModel employeeModel);
        Task<int> UpdateEmployeeAsync(EmployeeModel employeeModel);
        Task<int> DeleteEmployeeAsync(EmployeeModel employeeModel);
        IList<EmployeeModel> GetByIdEmployeeAsync(int id);
        IList<EmployeeModel> GetAllEmployeeAsync();
    }
}
