using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Penyia.Models;

namespace Penyia.DataAccess
{
    public class ScoolContext : DbContext
    {
        public ScoolContext()
            : base("ScoolContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        
    }
}