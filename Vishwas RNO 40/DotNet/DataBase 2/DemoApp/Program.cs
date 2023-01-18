using Demoapp.Company;

var db = new CompanyDbContext();

if (args.Length == 0)
{
    foreach (var department in db.Department)
        Console.WriteLine("{0, -6}{1, -12}{2, -15}", department.Id, department.DeptName, department.Location);
}
else
{
    int deptno = int.Parse(args[0]);
    var dep = db.Department
                    .Where(p => p.Id == deptno)
                    .Include(p => p.Emp)
                    .FirstOrDefault();
    if (dep != null)
    {
        foreach (var emp in dep.Emp)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Id, emp.EmpName, emp.Age, emp.Salary);
    }

}