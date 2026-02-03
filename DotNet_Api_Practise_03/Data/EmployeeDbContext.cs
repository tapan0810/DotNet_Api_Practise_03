using DotNet_Api_Practise_03.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Api_Practise_03.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}
