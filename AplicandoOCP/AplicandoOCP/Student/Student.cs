namespace OCP.Student;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public Student(int studentId, string name)
    {
        this.StudentId = studentId;
        this.Name = name;
    }
}