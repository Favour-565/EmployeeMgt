using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMgt.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<Employee> Employees {get; set;}
    }
}
