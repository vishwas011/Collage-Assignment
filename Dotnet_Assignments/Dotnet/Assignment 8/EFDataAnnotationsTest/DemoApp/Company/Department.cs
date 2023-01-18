using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Company;

[Table("department")]
public class Department
{
    [Column("deptno")]
    public int Id { get; set; }

    public string deptname { get; set; }

    
    public string location { get; set; }

    public List<Employee> Emp { get; set; }
}
