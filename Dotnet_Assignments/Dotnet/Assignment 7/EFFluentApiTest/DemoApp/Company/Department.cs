namespace DemoApp.Company;

public class Department
{
    public int Id { get; set; }

    public string deptname { get; set; }

    public string location { get; set; }

    //navigation property
    public List<Employee> Employees { get; set; }
}