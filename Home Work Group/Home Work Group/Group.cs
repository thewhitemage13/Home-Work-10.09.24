using System.Collections;
using System.Runtime.Serialization;

namespace Home_Work_Group
{
    [DataContract]
    public enum Spaciality { SoftwareDeveloper, Designer }
    [DataContract]
    public class Group : ICloneable, IEnumerable
    {
        [DataMember]
        private string groupName;
        [DataMember]
        private int countOfStudent = 0;
        [DataMember]
        private Spaciality spaciality;
        [DataMember]
        private int course;
        [DataMember]
        private List<Student> students = new List<Student>();
        
        public event EventHandler<GroupEventArgs> StudentAdded;
        public event EventHandler<GroupEventArgs> StudentRemoved;

        public void OnStudentAdded(Student student)
        {
            StudentAdded?.Invoke(this, new GroupEventArgs { Info = $"{student.GetName()} added to the group {groupName}" });
        }

        public void OnStudentRemoved(Student student)
        {
            StudentRemoved?.Invoke(this, new GroupEventArgs { Info = $"{student.GetName()} ungrouped {groupName}" });
        }

        public void SetCountOfStudents(int countOfStudent)
        {
            this.countOfStudent = countOfStudent;
        }

        public List<Student> GetStudent()
        {
            return students;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }

        public int GetCourse()
        {
            return course;
        }

        public void SetSpaciality(Spaciality spaciality)
        {
            this.spaciality = spaciality;
        }

        public Spaciality GetSpaciality()
        {
            return spaciality;
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void SetGroupName(string groupName)
        {
            this.groupName = groupName;
        }

        public string GetGroupName()
        {
            return groupName;
        }

        public Group(string groupName, Spaciality spaciality, int course)
        {
            SetGroupName(groupName);
            SetSpaciality(spaciality);
            SetCourse(course);
        }

        //public static bool operator == (Group left, Group right)
        //{
        //    string averageGrade1 = left.GetGroupName();
        //    string averageGrade2 = right.GetGroupName();

        //    return averageGrade1 == averageGrade2;
        //}

        //public static bool operator != (Group left, Group right)
        //{
        //    return !(left == right);
        //}

        public Group(Group group)
        {
            this.groupName = group.groupName;
            this.spaciality = group.spaciality;
            this.course = group.course;
            this.students = new List<Student>();
            foreach (Student student in group.students)
            {
                this.students.Add((Student)student.Clone());
            }
        }

        public Group(List<Student> students)
        {
            this.students = students;
        }
        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //public int CompareTo(Group group)
        //{
        //    if (group == null) return 1;
        //    return this.GetCountOfStudents().CompareTo(group.GetCountOfStudents());
        //}

        public object Clone()
        {
            return new Group(this);
        }

        //public override string ToString()
        //{
        //    var studentsInfo = students.Count > 0
        //        ? string.Join("\n", students)
        //        : "No students in the group.";

        //    return $"Group Name: {groupName}\n" +
        //           $"Speciality: {spaciality}\n" +
        //           $"Course: {course}\n" +
        //           $"Number of Students: {students.Count}\n" +
        //           $"Students:\n{studentsInfo}";
        //}
    }

    
}
