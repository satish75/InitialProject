using CommonEF.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessEF.Interface
{
    public interface IBussinessEF
    {
        public Task<bool> Add(Student user);

    }
}
