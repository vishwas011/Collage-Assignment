namespace Demoapp.Company;

public class Department
{
    public int Id { get; set; }

    public string DeptName { get; set; }

    public string Location { get; set; }

    public List<Employee> Emp { get; set; }
}