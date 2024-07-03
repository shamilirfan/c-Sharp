class Department
{
    public int departmentId { get; set; }
    public string? departmentName { get; set; }
    public List<Course> courses { get; set; }
}
class Course
{
    public int courseId { get; set; }
    public string? courseName { get; set; }
    public string? courseDuration { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        Course course1 = new Course();
        course1.courseId = 1;
        course1.courseName = "C#";
        course1.courseDuration = "3 month";

        Course course2 = new Course();
        course2.courseId = 2;
        course2.courseName = "Python";
        course2.courseDuration = "4 month";

        Department department1 = new Department();
        department1.departmentId = 1;
        department1.departmentName = "CSE";
        department1.courses = new List<Course>();
        department1.courses.Add(course1);
        department1.courses.Add(course2);



    }
}

/*

dotnet run 

*/