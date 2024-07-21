using OCP.Student;

namespace AplicandoOCP.Course;

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        Console.WriteLine(".");
    }
}