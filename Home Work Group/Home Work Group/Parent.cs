using System.Xml.Linq;

namespace Home_Work_Group
{
    public class Parent
    {
        string name;

        List<Student> students = new List<Student>();

        public Parent() { }

        public Parent(string name)
        {
            this.name = name;
        }
        public void OnGradeAchieved(object sender, StudentEventArgs e)
        {
            Console.WriteLine($"Parent {name} has been notified: {e.Info}");
        }
        public void OnCourseCompleted(object sender, StudentEventArgs e)
        {
            Console.WriteLine($"Parent {name} has been notified: {e.Info}");
        }
    }
}
