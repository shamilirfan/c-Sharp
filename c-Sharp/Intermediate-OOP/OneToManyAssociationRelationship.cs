using System;

// 12
class Department
{
    public int departmentId { get; set; }
    public string? departmentName { get; set; }
    public List<Course> courses { get; set; }

    public Department()
    {
        courses = new List<Course>();
    }

    public string DisplayInfo()
    {
        string info = "";
        foreach (Course course in courses)
        {
            info += course.DisplayInfo() + Environment.NewLine;
        }
        return info;
    }
}

class Course
{
    public int courseId { get; set; }
    public string? courseName { get; set; }
    public string? courseDuration { get; set; }

    public string DisplayInfo()
    {
        return $"ID: {courseId}, Name: {courseName}, Duration: {courseDuration}";
    }
}

class OneToManyAssociationRelationship
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

        //
        Department department1 = new Department();
        department1.departmentId = 1;
        department1.departmentName = "CSE";
        department1.courses.Add(course1);
        department1.courses.Add(course2);

        //
        Console.WriteLine($"{department1.DisplayInfo()}");
    }
}
