using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IRepository
    {
        Task<bool> AddUserDetails(RegistrationModel user);
    }
}
