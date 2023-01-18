global using Microsoft.EntityFrameworkCore;

namespace DemoApp.Company;

public class ShopDbContext : DbContext
{
    public DbSet<Department> Dep { get; set; }

    public DbSet<Employee> Emp { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DACIIT;Database=employee3");
    }
}