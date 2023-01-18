using System.ComponentModel.DataAnnotations.Schema;
namespace DemoApp.Company;
[Table("Employee")]
public class Employee
{

    public int Id { get; set; }

    public string EmpName { get; set; }
    [Column("DeptNo")]
    public int DepartmentId { get; set; }

    public int Age { get; set; }

    public int Salary { get; set; }


}