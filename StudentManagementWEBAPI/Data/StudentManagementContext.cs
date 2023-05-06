using Microsoft.EntityFrameworkCore;
using StudentManagementWEBAPI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementWEBAPI.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<StudentManagementUser> Users { get; set; }
        public DbSet<StudentLocation> Locations { get; set; }
    }
}
