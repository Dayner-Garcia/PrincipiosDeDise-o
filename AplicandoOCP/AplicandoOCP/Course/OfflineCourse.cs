using OCP.Student;

namespace AplicandoOCP.Course;

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        Console.WriteLine(".");
    }
}