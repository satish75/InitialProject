using BussinessEF.Interface;
using CommonEF.Model;
using RepositoryEF.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessEF.Services
{
    public class BussinessEF : IBussinessEF
    {
        private readonly IRepositoryEF _repository;
        public BussinessEF(IRepositoryEF repositoryEF)
        {
            _repository = repositoryEF;
        }
        public async Task<bool> Add(Student user)
        {
           if(user != null)
            {
                var results =await _repository.Add(user);
                if (results != null)
                    return true;
                else
                    return false;
            }
           else
            {
                return false;
            }
        }
    }
}
