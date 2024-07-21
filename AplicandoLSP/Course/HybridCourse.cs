namespace LSP.Class;

public class HybridCourse : Course
{
    private OfflineCourse _offline;
    private OnlineCourse _online;

    public HybridCourse(OfflineCourse offlineCourse, OnlineCourse onlineCourse)
    {
        this._offline = offlineCourse;
        this._online = onlineCourse;
    }
    public override void Subscribe(Student.Student std)
    {
        Console.WriteLine($"");
    }
}