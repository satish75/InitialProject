using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
   public class ApplicationModel : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
