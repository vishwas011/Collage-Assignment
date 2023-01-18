using System.ComponentModel;

namespace DemoApp;

using Company;

public class DepartmentBindings : INotifyPropertyChanged
{
    private ShopDbContext _db = new ShopDbContext();
    private Department _currentDepartment;

    public event PropertyChangedEventHandler PropertyChanged;

    public IEnumerable<Department> Dep => _db.Dep.ToList();

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
