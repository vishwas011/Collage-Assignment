namespace BasicWebApp.Services;

public class Course
{
   
    public int Id { get; set; }

    public string name { get; set; }

    public int fees { get; set; }

    //navigation property
    public List<Student> Students { get; set; }
}