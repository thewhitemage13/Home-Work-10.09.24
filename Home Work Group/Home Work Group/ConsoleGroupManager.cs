namespace Home_Work_Group
{
    public class GroupEventArgs : EventArgs
    {
        public string Info { get; set; }
    }

    internal class ConsoleGroupManager : IGroupManager<Group, Student>
    {
        private ConsoleStudentManager studentConsoleManager = new ConsoleStudentManager();
        public void Expel(Group group)
        {
            if (group.GetStudent().Count == 0)
            {
                Console.WriteLine("The group is empty.");
                return;
            }
            int minGradeIndex = 0;
            for (int i = 1; i < group.GetStudent().Count; i++)
            {
                if (studentConsoleManager.AverageGrade(group.GetStudent()[i]) < studentConsoleManager.AverageGrade(group.GetStudent()[minGradeIndex]))
                {
                    minGradeIndex = i;
                }
            }
            group.GetStudent().RemoveAt(minGradeIndex);

            Console.WriteLine("The student with the lowest grade point average is dropped from the group.");
        }

        public void FlunkedOut(Group group)
        {
            for (int i = group.GetStudent().Count - 1; i >= 0; i--)
            {
                int countOfLowGrades = group.GetStudent()[i].GetTermPaperGrades().Count(grade => grade < 3);
                
                if (countOfLowGrades > 2)
                {
                    group.GetStudent().RemoveAt(i);
                }
            }
            Console.WriteLine("Students with more than two low grades have been expelled.");
        }

        public void AddStudent(Group group,Student student)
        {
            group.SetCountOfStudents(group.GetStudent().Count + 1);
            group.GetStudent().Add(student);
            group.OnStudentAdded(student);
        }

        public void RemoveStudent(Group group, Student student) 
        {
            group.GetStudent().Remove(student);
            group.OnStudentRemoved(student);
        }

        public void TransferStudent(Group group1, Group group2, Student student)
        {
            RemoveStudent(group1, student);
            AddStudent(group2, student);
        }
    }
}
