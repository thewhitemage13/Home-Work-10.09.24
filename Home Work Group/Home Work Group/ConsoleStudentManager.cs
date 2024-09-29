using System.Xml.Linq;

namespace Home_Work_Group
{
    public class StudentEventArgs : EventArgs
    {
        public string Info { get; set; }
    }

    internal class ConsoleStudentManager : IStudentManager<Student>
    {
        public int AverageGrade(Student student)
        {
            for (int i = 0; i < student.GetExamGrades().Count; i++)
            {
                int r = student.GetExamGrades()[i] / student.GetExamGrades().Capacity;
                student.PlusAverageGrade(r);
            }
            return student.GetAverageGrade();
        }

        public void CompleteCourse(Student student, string courseName)
        {
            student.OnCourseCompleted(courseName);
        }

        public void AddHomeworkGrades(Student student, int grade)
        {
            student.GetHomeworkGrades().Add(grade);
            student.OnGradeAchieved(grade);
        }

        public void AddExamGrades(Student student, int grade)
        {
            student.GetExamGrades().Add(grade);
            student.OnGradeAchieved(grade);
        }

        public void AddTermPaperGrades(Student student, int grade)
        {
            student.GetTermPaperGrades().Add(grade);
            student.OnGradeAchieved(grade);
        }
    }
}
