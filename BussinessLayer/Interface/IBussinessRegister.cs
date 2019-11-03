using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interface
{
   public interface IBussinessRegister
    {
       Task<bool> AddUserDetails(RegistrationModel user);
    }
}
