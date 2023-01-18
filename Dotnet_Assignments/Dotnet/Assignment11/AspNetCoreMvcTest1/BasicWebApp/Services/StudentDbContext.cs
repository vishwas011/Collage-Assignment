global using Microsoft.EntityFrameworkCore;

namespace BasicWebApp.Services;

public class StudentDbContext : DbContext,IDbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
   
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DACIIT;Database=studentandcourse");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
            .ToTable("course")
            .Property(p => p.Id)
            .HasColumnName("courseid");
        modelBuilder.Entity<Student>()
            .ToTable("students")
            .Property(p => p.Id)
            .HasColumnName("studentrollno");
        modelBuilder.Entity<Student>()
            .Property(p => p.CourseId)
            .HasColumnName("courseid");
    }
}