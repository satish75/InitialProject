using Common.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.ContextDb
{
   public class ContextDB : IdentityDbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationModel> User { get; set; }
    }
}
