using CommonLayer.Model;
using RepositoryLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.ServiceRepository
{
   public class EmployeeOperation : IEmployeeRepository
    {
        
        private static readonly string connectionVariable = "server=(LocalDb)/LocalDbDemo;database=EmployeeDatabase;Trusted_Connection=true";
        SqlConnection sqlConnection = new SqlConnection(connectionVariable);

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            SqlCommand sqlCommand=new SqlCommand("InsertEmployeeProcedure", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", employeeModel.Id);
            sqlCommand.Parameters.AddWithValue("@Name", employeeModel.Name);
            sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);
            sqlCommand.Parameters.AddWithValue("@Address", employeeModel.Addresss);
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            if(row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
