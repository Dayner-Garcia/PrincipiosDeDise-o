using LSP.Student;

namespace AplicandoLSP.Course;

public class HybridCourse : Course
{
    private OfflineCourse _offline;
    private OnlineCourse _online;

    public HybridCourse(OfflineCourse offlineCourse, OnlineCourse onlineCourse)
    {
        this._offline = offlineCourse;
        this._online = onlineCourse;
    }
    public override void Subscribe(Student std)
    {
        _online.Subscribe(std);
        _offline.Subscribe(std);
        Console.WriteLine($"Student {std.Name} suscrito al curso hybrido: {Title}");
    }
}