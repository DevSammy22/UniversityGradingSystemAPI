using Microsoft.EntityFrameworkCore;
using System;
using UniversityGradingSystem.Models.Entities;

namespace UniversityGradingSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
