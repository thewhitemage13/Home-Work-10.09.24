using System.Xml.Linq;

namespace Home_Work_Group
{
    public class Director
    {
        private string name;

        public Director() { }

        public Director(string name)
        {
            this.name = name;
        }
        public void OnStudentAdded(object sender, GroupEventArgs e)
        {
            Console.WriteLine($"Director {name} has been notified: {e.Info}");
        }

        public void OnStudentRemoved(object sender, GroupEventArgs e)
        {
            Console.WriteLine($"Director {name} has been notified: {e.Info}");
        }
    }
}
