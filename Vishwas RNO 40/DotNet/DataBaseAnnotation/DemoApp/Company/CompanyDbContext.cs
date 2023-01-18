global using Microsoft.EntityFrameworkCore;

namespace DemoApp.Company;

public class CompanyDbContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    public DbSet<Department> Department { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\METIIT;Database=Company");

    }


}