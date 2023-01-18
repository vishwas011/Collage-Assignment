using System.ComponentModel;

namespace DemoApp.Company;



public class DepartmentBindings : INotifyPropertyChanged
{
    private CompanyDbContext _db= new CompanyDbContext();
    private Department _currentDepartment;

    public event PropertyChangedEventHandler PropertyChanged;
    public IEnumerable<Department> Department => _db.Department.ToList();
    public Department CurrentDepartment
    {
        get => _currentDepartment;
        set
        {
            _currentDepartment = value;
            _db.Entry(_currentDepartment).Collection(p => p.Emp).Load();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDepartment"));
        }
    }
}
