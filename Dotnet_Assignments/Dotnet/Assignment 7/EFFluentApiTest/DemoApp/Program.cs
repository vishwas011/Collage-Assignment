using DemoApp.Company;

var db = new CompanyDbContext();

if(args.Length == 0)
{
    foreach(var department in db.Departments)
        Console.WriteLine("{0, -6}{1, 12:0.00}{2, 12}", department.Id, department.deptname, department.location);
}
else
{
    int dno = int.Parse(args[0]);
    var department = db.Departments
                .Where(p => p.Id == dno)
                .Include(p => p.Employees)
                .FirstOrDefault();
    if(department != null)
    {
        foreach(var employee in department.Employees)
            Console.WriteLine("{0, -6}{1, 12:0.00}{2, 8}{3, 8}", employee.empname, employee.salary, employee.age, employee.DepartmentId);
    }
}

