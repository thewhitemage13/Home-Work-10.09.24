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

            student1.GradeAchieved += parent1.OnGradeAchieved;
            student1.CourseCompleted += parent1.OnCourseCompleted;

            p26.StudentAdded += director1.OnStudentAdded;
            p26.StudentRemoved += director1.OnStudentRemoved;

            groupManager.AddStudent(p26, student1);
            groupManager.AddStudent(p26, student2);

            studentManager.AddHomeworkGrades(student1, 12);
            studentManager.AddExamGrades(student1, 8);
            studentManager.AddTermPaperGrades(student1, 9);

            groupManager.RemoveStudent(p26, student2);

        }
    }
}
