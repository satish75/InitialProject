using Microsoft.EntityFrameworkCore;
using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Registration> registrations { get; set; }
    }
}
