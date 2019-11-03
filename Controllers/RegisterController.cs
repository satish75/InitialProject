using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Interface;
using Common.Models;

namespace Fundoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IBussinessRegister _bussinessRegister;
        public RegisterController(IBussinessRegister bussinessRegister)
        {
            _bussinessRegister = bussinessRegister;
        }

        [HttpPost]
        [Route("Add")]

        public async Task<bool> AddUserDetail(RegistrationModel details)
        {
            var result = await _bussinessRegister.AddUserDetails(details);
            return result;
        }
    }
}