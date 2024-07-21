using LSP.Student;

namespace AplicandoLSP.Course;

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        Console.WriteLine($"Estudiante {std.Name} suscrito al curso offline: {Title}");
    }
}