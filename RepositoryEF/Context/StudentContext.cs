using CommonEF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryEF.Context
{
   public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
       public DbSet<Student> studentsEF { get; set; }
    }
}
