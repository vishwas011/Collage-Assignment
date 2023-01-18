global using MySql.Data;
using System.ComponentModel.DataAnnotations.Schema;
namespace BasicWebApp.Services;

[Table("CourseInfo")]
public class Course
{

    [Column("CourseId")]
    public int Id { get; set; }

    public string CourseName { get; set; }

    public int Fees { get; set; }

    public List<Student> StudentInfo { get; set; }

}