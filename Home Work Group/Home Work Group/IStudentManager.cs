namespace Home_Work_Group
{
    internal interface IStudentManager<T>
    {
        public int AverageGrade(T obj);
        public void AddHomeworkGrades(T obj, int grade);
        public void AddExamGrades(T obj, int grade);
        public void AddTermPaperGrades(T obj, int grade);
    }
}
