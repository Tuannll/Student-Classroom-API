using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace TH5.Data
{
    public class AppDbContext : DbContext
    {
        // Giải thích 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Studnets { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudentClassroom> StudentClassrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}