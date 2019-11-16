using CommonEF.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEF.Interface
{
   public interface IRepositoryEF
    {
        Task<bool> Add(Student user);
    }
}
