using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.DataContext
{
    internal class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() { }
        
        public DbSet<Employee> Employees { get; set; }

        protected override  void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server=ANAMIKA\\SQLSERVER;database=pract1Db;integrated security=true;TrustServerCertificate=True");
        }
    }
}
