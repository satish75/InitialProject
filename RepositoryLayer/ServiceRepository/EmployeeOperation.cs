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

        /// <summary>
        /// Adds the employee asynchronous.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> AddEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertEmployeeProcedure", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               //// sqlCommand.Parameters.AddWithValue("@Id", employeeModel.Id);
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
        /// <summary>
        /// Updates the employee asynchronous.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<int> UpdateEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateEmployeeById", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", employeeModel.Id);
                sqlCommand.Parameters.AddWithValue("@Name", employeeModel.Name);
                sqlCommand.Parameters.AddWithValue("@Salary", employeeModel.Salary);
                sqlCommand.Parameters.AddWithValue("@address", employeeModel.Address);
                sqlConnection.Open();
                var respone = await sqlCommand.ExecuteNonQueryAsync();
                return respone;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public async Task<int> DeleteEmployeeAsync(EmployeeModel employeeModel)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteById", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", employeeModel.Id);      
                sqlConnection.Open();
                var respone = await sqlCommand.ExecuteNonQueryAsync();
                return respone;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Gets the by identifier employee asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IList<EmployeeModel> GetByIdEmployeeAsync(int id)
        {
            try
            {
                IList<EmployeeModel> list = new List<EmployeeModel>();
                SqlCommand sqlCommand = new SqlCommand("GetById", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlConnection.Open();
                SqlDataReader dataReader =  sqlCommand.ExecuteReader();
                EmployeeModel model = null;
                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        model = new EmployeeModel();
                        model.Id = Convert.ToInt32(dataReader["Id"]);
                        model.Name = dataReader["Name"].ToString();
                        model.Salary = Convert.ToInt32(dataReader["Salary"]);
                        model.Address = dataReader["Address"].ToString();
                        list.Add(model);
                    }
                }
                
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Gets all employee asynchronous.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IList<EmployeeModel> GetAllEmployeeAsync()
        {
            try
            {
                IList<EmployeeModel> list = new List<EmployeeModel>();
                SqlCommand sqlCommand = new SqlCommand("GetAllEmployeesData", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;      
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                EmployeeModel model = null;
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        model = new EmployeeModel();
                        model.Id = Convert.ToInt32(dataReader["Id"]);
                        model.Name = dataReader["Name"].ToString();
                        model.Salary = Convert.ToInt32(dataReader["Salary"]);
                        model.Address = dataReader["Address"].ToString();
                        list.Add(model);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }



    }
}

