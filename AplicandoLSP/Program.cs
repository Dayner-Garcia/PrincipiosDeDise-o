using AplicandoLSP.Course;
using LSP.Student;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student{ Name = "John Doe" };

        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Online Course" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Offline Course" };
        
        OnlineCourse specificOnlineCourse = new OnlineCourse { CourseId = 1, Title = "Specific Online Course" };
        OfflineCourse specificOfflineCourse = new OfflineCourse { CourseId = 2, Title = "Specific Offline Course" };

        Course hybridCourse = new HybridCourse(specificOfflineCourse, specificOnlineCourse) { CourseId = 3, Title = "Hybrid Course" };
        
        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}