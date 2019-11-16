using CommonEF.Model;
using RepositoryEF.Context;
using RepositoryEF.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Services
{
    public class RepositoryEF : IRepositoryEF
    {
        private readonly StudentContext _studentContext;
        public RepositoryEF(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public async Task<bool> Add(Student user)
        {
         
            if(user != null)
            {
                var studentData = new Student()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Address = user.Address
                };
               var results =   _studentContext.Add(studentData);
                await _studentContext.SaveChangesAsync();
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
