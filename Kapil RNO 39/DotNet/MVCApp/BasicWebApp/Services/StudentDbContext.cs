global using Microsoft.EntityFrameworkCore;

namespace BasicWebApp.Services;

public class StudentDbContext : DbContext
{
    public DbSet<Student> StudentInfo { get; set; }

    public DbSet<Course> CourseInfo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseMySQL("Server=localhost;Database=college;User ID=root;Password=root");
    }
}