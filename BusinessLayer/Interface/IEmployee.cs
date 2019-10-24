using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IEmployee
    {
         bool AddEmployee(EmployeeModel employeeModel);
    }
}
