global using Microsoft.EntityFrameworkCore;
namespace BasicWebApp.Services;
public interface IDbContext
{
    public DbSet<Course>Courses {get; set;}
    public DbSet<Student>Students {get; set;}
}