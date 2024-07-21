using LSP.Student;

namespace AplicandoLSP.Course;

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        Console.WriteLine($"Estudiante {std.Name} suscrito al curso online: {Title}");
    }
}