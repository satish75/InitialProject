using BussinessLayer.Interface;
using Common.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    public class BussinessRegister : IBussinessRegister
    {
        private readonly IRepository _repository;
        public BussinessRegister(IRepository repository)
        {
            _repository = repository;
        }
    
        public async Task<bool> AddUserDetails(RegistrationModel user)
        {
            try
            {
                if (user != null)
                {
                    return await _repository.AddUserDetails(user);
                }
                else
                {
                    throw new Exception("User is empty");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
