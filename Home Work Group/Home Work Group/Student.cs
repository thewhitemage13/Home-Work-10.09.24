using System.Threading;

namespace Home_Work_Group
{
    internal class Student : Person, ICloneable, IComparable<Student>
    {
        List<int> homeworkGrades = new List<int>();
        List<int> examGrades = new List<int>();
        List<int> termPaperGrades = new List<int>();
        ConsoleStudentManager studentManager = new ConsoleStudentManager();
        int averageGrade;

        public int GetAverageGrade()
        {
            return averageGrade;
        }

        public void PlusAverageGrade(int number)
        {
            this.averageGrade += number;
        }

        public List<int> GetHomeworkGrades()
        {
            return homeworkGrades;
        }

        public List<int> GetExamGrades()
        {
            return examGrades;
        }

        public List<int> GetTermPaperGrades()
        {
            return termPaperGrades;
        }

        public Student(string surname, string name, string lastname, DateTime birthday, string adress, int phonenumber) : base(surname, name, lastname, birthday, adress, phonenumber)
        {
        }

        public Student(int phonenumber) : base("Lolo", "Mukhammed", "Kamel", DateTime.Now, "Vilkovskaya 38", phonenumber)
        {
        }

        public Student(DateTime birthday, string adress, int phonenumber) : base("Lolo", "Mukhammed", "Kamel", birthday, adress, phonenumber)
        {
        }

        //ovreload
        public static bool operator true(Student original)
        {
            return original.averageGrade != 0;
        }

        public static bool operator false(Student original)
        {
            return original.averageGrade == 0;
        }

        //public static bool operator == (Student left, Student right)
        //{
        //    int averageGrade1 = left.averageGrade;
        //    int averageGrade2 = right.averageGrade;

        //    return averageGrade1 == averageGrade2;
        //}

        //public static bool operator != (Student left, Student right)
        //{
        //    return !(left == right);
        //}

        public static bool operator > (Student a, Student b)
        {
            return a.averageGrade > b.averageGrade;
        }

        public static bool operator < (Student a, Student b)
        {
            return a.averageGrade < b.averageGrade;
        }

        public int CompareTo(Student student)
        {
            if (student == null) return 1;
            return this.GetName().CompareTo(student.GetName());
        }

        public object Clone()
        {
            var clonedStudent = new Student(
                GetSurname(), GetName(), GetLastname(), GetBirthday(), GetAdress(), GetPhonenumber())
            {
                homeworkGrades = new List<int>(homeworkGrades),
                examGrades = new List<int>(examGrades),
                termPaperGrades = new List<int>(termPaperGrades)
            };
            return clonedStudent;
        }

        public override string ToString()
        {
            return $"Surname: {GetSurname()}\n" +
                   $"Name: {GetName()}\n" +
                   $"Lastname: {GetLastname()}\n" +
                   $"Birthday: {GetBirthday()}\n" +
                   $"Address: {GetAdress()}\n" +
                   $"Phone Number: {GetPhonenumber()}\n" +
                   $"Average Grade: {studentManager.AverageGrade(this)}\n" +
                   $"Homework Grades: {string.Join(", ", homeworkGrades)}\n" +
                   $"Exam Grades: {string.Join(", ", examGrades)}\n" +
                   $"Term Paper Grades: {string.Join(", ", termPaperGrades)}";
        }
    }
}
