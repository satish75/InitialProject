using Common.Models;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
   public class RegisterRepository : IRepository
    {
        private UserManager<ApplicationModel> _userManager;
        public RegisterRepository(UserManager<ApplicationModel> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<bool> AddUserDetails(RegistrationModel user)
        {
            var applicationUser = new ApplicationModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber=user.Mobile,
                Email = user.Email,
                UserName=user.UserName,  

            };
            try
            {
                var result = await _userManager.CreateAsync(applicationUser, user.Password);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }
    }
}
