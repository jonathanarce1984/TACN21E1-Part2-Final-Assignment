using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkCode_FirstAssignmentApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }   
}

