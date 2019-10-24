using CommonLayer.Model;
using RepositoryLayer.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.ServiceRepository
{
    public class EmployeeOperation : IEmployeeRepository
    {

        private static readonly string connectionVariable = "Server=(LocalDb)\\LocalDbDemo;Database=EmployeeDatabase;Trusted_Connection=true;MultipleActiveResultSets=True";
        SqlConnection sqlConnection = new SqlConnection(connectionVariable);


        public async Task<int> AddEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertEmployeeProcedure", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", employeeModel.Name);
                sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);
                sqlCommand.Parameters.AddWithValue("@address", employeeModel.Address);
                sqlConnection.Open();
                var respone = await sqlCommand.ExecuteNonQueryAsync();
                return respone;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

