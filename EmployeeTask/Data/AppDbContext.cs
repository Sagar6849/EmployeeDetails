using EmployeeTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}