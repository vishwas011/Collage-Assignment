using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Company;

[Table("employee")]
public class Employee
{
    [Column("empno")]
    public int Id { get; set; }

    public string empname { get; set; }

   
    public decimal salary { get; set; }

 
    public int age { get; set; }

   [Column("deptno")]
    public int DepartmentId { get; set; }
}
