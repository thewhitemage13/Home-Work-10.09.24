using System.Runtime.Serialization.Json;

namespace Home_Work_Group
{
    internal class Program
    {
        private static ConsoleStudentManager studentManager = new ConsoleStudentManager();
        private static ConsoleGroupManager groupManager = new ConsoleGroupManager();

        static void Main(string[] args)
        {
            Director director1 = new Director();
            Parent parent1 = new Parent();

            Group p26 = new Group("p26", Spaciality.SoftwareDeveloper, 3);

            Student student1 = new Student("Smith", "John", "Michael", new DateTime(2001, 5, 12), "123 Main St, Kyiv", 380671234);
            Student student2 = new Student("Johnson", "Alex", "James", new DateTime(2000, 8, 22), "45 Green St, Lviv", 380679876);
            Student student3 = new Student("Williams", "Emily", "Elizabeth", new DateTime(2002, 1, 15), "78 Oak Ave, Odesa", 380673456);
            Student student4 = new Student("Brown", "David", "Robert", new DateTime(1999, 11, 30), "10 Pine St, Kharkiv", 380665432);
            Student student5 = new Student("Taylor", "Sophia", "Marie", new DateTime(2003, 3, 5), "56 Maple St, Dnipro", 380667890);

            p26.Add(student1);
            p26.Add(student2);
            p26.Add(student3);
            p26.Add(student4);
            p26.Add(student5);

            studentManager.AddExamGrades(student1, 10);
            studentManager.AddExamGrades(student1, 11);
            studentManager.AddExamGrades(student1, 11);
            studentManager.AddExamGrades(student1, 12);

            studentManager.AddExamGrades(student2, 10);
            studentManager.AddExamGrades(student2, 11);
            studentManager.AddExamGrades(student2, 11);
            studentManager.AddExamGrades(student2, 12);

            var js = new DataContractJsonSerializer(typeof(Group));
            var fs = new FileStream(@"C:\1\json.txt", FileMode.Create, FileAccess.Write);
            js.WriteObject(fs, p26);
            fs.Close();

            fs = new FileStream(@"C:\1\json.txt", FileMode.Open, FileAccess.Read);
            Group copy = (Group)js.ReadObject(fs);

            Console.WriteLine("Group Name: " + copy.GetGroupName());
            Console.WriteLine("Spaciality: " + copy.GetSpaciality());
            Console.WriteLine("Course: " + copy.GetCourse());
            Console.WriteLine("Students: " + "\n");

            foreach(Student student in copy.GetStudent())
            {
                Console.WriteLine(student + "\n\n");
            }
        }
    }
}
