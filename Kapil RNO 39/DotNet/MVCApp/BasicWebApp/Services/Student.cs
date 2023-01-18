global using MySql.Data;
using System.ComponentModel.DataAnnotations.Schema;
namespace BasicWebApp.Services;

[Table("StudentInfo")]
public class Student
{
    
    [Column("RollNo")]
    public int Id { get; set; } 

    public string StudentName { get; set; }
     
    public int Age { get; set; }

   // [Column("CourseId")]
    public int CourseId {get; set; }

    public string Grade { get; set; }

    
}