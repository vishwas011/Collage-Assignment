using System.ComponentModel.DataAnnotations.Schema;
namespace DemoApp.Company;

[Table("Department")]
public class Department
{
    [Column("DeptNo")]
    public int Id { get; set; }
    
    public string DeptName { get; set; }

    public string Location { get; set; }

    public List<Employee> Emp { get; set; }
}