global using Microsoft.EntityFrameworkCore;

namespace Demoapp.Company;

public class CompanyDbContext : DbContext
{
    public DbSet<Employee> Employee { get; set; }

    public DbSet<Department> Department { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\METIIT;Database=Company");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
                .Property(p => p.Id)
                .HasColumnName("DeptNo");
        modelBuilder.Entity<Employee>()
                .Property(p => p.DepartmentId)
                .HasColumnName("DeptNo");

    }


}