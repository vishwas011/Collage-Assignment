global using Microsoft.EntityFrameworkCore;
//global using MySql.EntityFrameworkCore;

namespace DemoApp.Company;

public class CompanyDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost; Database=employee3; User ID=root; Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .ToTable("department")
            .Property(p => p.Id)
            .HasColumnName("deptno");
        modelBuilder.Entity<Employee>()
            .ToTable("employee")
            .Property(p => p.Id)
            .HasColumnName("empno");
        modelBuilder.Entity<Employee>()
            .Property(p => p.DepartmentId)
            .HasColumnName("deptno");
    }
}