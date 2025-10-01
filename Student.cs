// Student.cs
namespace USFLibraryManagement
{
public class Student : Person
{
    public string Major { get; set; }
    public int GraduationYear { get; set; }

    // The 'base(...)' keyword passes the common properties up to the Person class constructor
    public Student(string name, string email, string id, string major, int graduationYear)
        : base(name, email, id)
    {
        Major = major;
        GraduationYear = graduationYear;
    }
}
}