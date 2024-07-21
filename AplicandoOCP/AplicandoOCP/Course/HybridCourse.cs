using OCP.Student;

namespace AplicandoOCP.Course
{
    public class HybridCourse : Course
    {
        private OnlineCourse _onlineCourse;
        private OfflineCourse _offlineCourse;

        public HybridCourse(OnlineCourse onlineCourse, OfflineCourse offlineCourse)
        {
            this._onlineCourse = onlineCourse;
            this._offlineCourse = offlineCourse;
        }

        public override void Subscribe(Student std)
        {
            Console.WriteLine("Hybrid");
        }
    }
}